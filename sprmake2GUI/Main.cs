using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace sprmake2GUI
{
    public partial class Main : Form
    {
        private Dictionary<CheckBox, string> arguments = new Dictionary<CheckBox, string>();
        private Dictionary<CheckBox, int> buttmask = new Dictionary<CheckBox, int>();
        private List<Control> stuff = new List<Control>();
        private List<CheckBox> loudness = new List<CheckBox>();
        private string executable = "";
        private string args = "";
        private Process curproc;
        public Main()
        {
            InitializeComponent();
            arguments.Add(txt2defControl, "-txt2def");
            arguments.Add(cControl, "-c");
            arguments.Add(fControl, "-f");
            arguments.Add(pControl, "-p");
            arguments.Add(qControl, "-q");
            arguments.Add(vqControl, "-Q");
            arguments.Add(vControl, "-v");
            arguments.Add(vvControl, "-V");

            buttmask.Add(txt2defControl, 256);
            buttmask.Add(clearOptionControl, 128);
            buttmask.Add(vvControl, 64);
            buttmask.Add(vControl, 32);
            buttmask.Add(vqControl, 16);
            buttmask.Add(qControl, 8);
            buttmask.Add(pControl, 4);
            buttmask.Add(fControl, 2);
            buttmask.Add(cControl, 1);

            foreach (var key in arguments.Keys)
            {
                key.CheckedChanged += delegate (object sender, EventArgs e) { update(); };
            }
            TextBox[] textboxes = new TextBox[] { sprmake2Control, inputControl, outputControl };
            stuff.AddRange(arguments.Keys.ToArray());
            stuff.AddRange(textboxes);
            stuff.AddRange(new Control[] { sprmake2BrowseControl, inputBrowseControl, outputBrowseControl });
            stuff.Add(outputTypeControl);
            stuff.Add(clearOptionControl);
            for (int i = 0; i < textboxes.Length; i++)
            {
                textboxes[i].TextChanged += delegate (object sender, EventArgs e) { update(); };
            }
            sprmake2BrowseControl.Click += delegate (object sender, EventArgs e) { browseFile(sprmake2Control, "executable files (.exe)|*.exe|all files (*.*)|*.*"); };
            inputBrowseControl.Click += delegate (object sender, EventArgs e) { browseFile(inputControl, "sffv2 source file (.def)|*.def|sffv1 source file (.txt)|*.txt|all files (*.*)|*.*"); };
            outputBrowseControl.Click += delegate (object sender, EventArgs e) { browseFile(outputControl, "sffv2 compiled file (.sff)|*.sff|all files (*.*)|*.*"); };
            outputTypeControl.TextChanged += delegate (object sender, EventArgs e) { update(); };
            compileControl.Click += go;
            clearControl.Click += clear;

            /* flags bitmask:
             * 00000000
             * ^ clear before compiling
             *  ^ -V
             *   ^ -v
             *    ^ -Q
             *     ^ -q 
             *      ^ -p
             *       ^ -f
             *        ^ -c
             * */

            // i think i'm going to cry
            loudness.AddRange(new CheckBox[] { vvControl, vControl, vqControl, qControl });
            foreach (var one in loudness)
            {
                one.CheckedChanged += delegate (object sender, EventArgs e)
                {
                    if (one.Checked)
                    {
                        foreach (var two in loudness)
                        {
                            if (one == two) continue;
                            two.Checked = false;
                        }
                    }
                };
            }

            txt2defControl.CheckedChanged += delegate (object sender, EventArgs e) { if (txt2defControl.Checked) { outputTypeControl.Text = "Custom"; outputTypeControl.Enabled = false; } else { outputTypeControl.Enabled = true; } };

            foreach (var thing in buttmask.Keys)
            {
                thing.CheckedChanged += delegate (object sender, EventArgs e) { update(); };
                if ((Properties.Settings.Default.flags & buttmask[thing]) != 0) {
                    thing.Checked = true;
                }
            }

            sprmake2Control.Text = Properties.Settings.Default.sprmake2;
            inputControl.Text = Properties.Settings.Default.input;
            outputControl.Text = Properties.Settings.Default.output;
            outputTypeControl.Text = Properties.Settings.Default.fromDef == true ? "From DEF" : "Custom";
        }

        public void browseFile(TextBox control, string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                control.Text = ofd.FileName;
            }
        }

        public void go(object sender, EventArgs e)
        {
            if(clearOptionControl.Checked == true)
            {
                consoleOutputControl.Clear();
            }
            curproc = new Process();
            foreach (var cool in stuff)
            {
                cool.Enabled = false;
            }
            curproc.StartInfo.FileName = executable;
            curproc.StartInfo.Arguments = args;
            curproc.StartInfo.UseShellExecute = false;
            curproc.StartInfo.RedirectStandardOutput = true;
            curproc.StartInfo.RedirectStandardError = true;
            curproc.StartInfo.CreateNoWindow = true;
            curproc.StartInfo.WorkingDirectory = Path.GetDirectoryName(executable);
            curproc.OutputDataReceived += new DataReceivedEventHandler(cout);
            curproc.ErrorDataReceived += new DataReceivedEventHandler(cout);
            curproc.Start();
            curproc.EnableRaisingEvents = true;
            curproc.Exited += new EventHandler(done);
            curproc.BeginOutputReadLine();
            curproc.BeginErrorReadLine();
            //process.WaitForExit();
        }

        public void clear(object sender, EventArgs e)
        {
            consoleOutputControl.Clear();
        }

        public void cout(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                consoleOutputControl.Invoke(new Action(() => {
                    consoleOutputControl.Text += e.Data + "\r\n";
                }));
            }
        }

        public void done(object sender, EventArgs e)
        {
            consoleOutputControl.Invoke(new Action(() =>
            {
                consoleOutputControl.SelectionStart = consoleOutputControl.TextLength;
                consoleOutputControl.ScrollToCaret();
                foreach (var cool in stuff)
                {
                    cool.Enabled = true;
                }
                update();
            }));
            curproc.Dispose();
        }

        public void update()
        {
            if (txt2defControl.Checked)
            {
                foreach (var key in arguments.Keys)
                {
                    if (key == txt2defControl) continue;
                    key.Checked = false;
                    key.Enabled = false;
                }
            }
            else
            {
                foreach (var key in arguments.Keys)
                {
                    key.Enabled = true;
                }
            }
            if (outputTypeControl.Text == "From DEF")
            {
                outputBrowseControl.Enabled = false;
                outputControl.Enabled = false;
            }
            else
            {
                outputBrowseControl.Enabled = true;
                outputControl.Enabled = true;
            }
            if (String.IsNullOrEmpty(inputControl.Text) || String.IsNullOrEmpty(sprmake2Control.Text))
            {
                compileControl.Enabled = false;
            }
            else
            {
                compileControl.Enabled = true;
            }

            executable = sprmake2Control.Text;
            args = "";
            foreach (var key in arguments.Keys)
            {
                if (key.Checked)
                {
                    args += arguments[key] + " ";
                }
            }
            if(outputTypeControl.Text == "Custom") { 
                args += String.Format("-o \"{0}\" ", outputControl.Text);
            }
            args += String.Format("\"{0}\" ", inputControl.Text);
            args = args.Trim(' ');
            commandPreviewControl.Text = String.Format("\"{0}\" {1}", executable, args);
        }

        private void exiting(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.sprmake2 = sprmake2Control.Text;
            Properties.Settings.Default.input = inputControl.Text;
            Properties.Settings.Default.output = outputControl.Text;
            Properties.Settings.Default.fromDef = outputTypeControl.Text == "From DEF" ? true : false;
            int i = 0;
            foreach (var thing in buttmask.Keys)
            {
                // i dont know if this works
                if (thing.Checked)
                {
                    Properties.Settings.Default.flags = (short)((int)Properties.Settings.Default.flags | buttmask[thing]);
                }
                else
                {
                    Properties.Settings.Default.flags = (short)((int)Properties.Settings.Default.flags & ~buttmask[thing]);
                }
                i++;
            }
            Properties.Settings.Default.Save();
        }
    }
}
