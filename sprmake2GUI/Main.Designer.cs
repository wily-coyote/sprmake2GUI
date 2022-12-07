namespace sprmake2GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sprmake2Control = new System.Windows.Forms.TextBox();
            this.sprmake2Label = new System.Windows.Forms.Label();
            this.consoleOutputControl = new System.Windows.Forms.TextBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.vvControl = new System.Windows.Forms.CheckBox();
            this.vControl = new System.Windows.Forms.CheckBox();
            this.vqControl = new System.Windows.Forms.CheckBox();
            this.qControl = new System.Windows.Forms.CheckBox();
            this.pControl = new System.Windows.Forms.CheckBox();
            this.fControl = new System.Windows.Forms.CheckBox();
            this.cControl = new System.Windows.Forms.CheckBox();
            this.inputControl = new System.Windows.Forms.TextBox();
            this.outputControl = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTypeControl = new System.Windows.Forms.ComboBox();
            this.sprmake2BrowseControl = new System.Windows.Forms.Button();
            this.inputBrowseControl = new System.Windows.Forms.Button();
            this.outputBrowseControl = new System.Windows.Forms.Button();
            this.compileControl = new System.Windows.Forms.Button();
            this.commandPreviewControl = new System.Windows.Forms.TextBox();
            this.clearControl = new System.Windows.Forms.Button();
            this.clearOptionControl = new System.Windows.Forms.CheckBox();
            this.txt2defControl = new System.Windows.Forms.CheckBox();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sprmake2Control
            // 
            this.sprmake2Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sprmake2Control.Location = new System.Drawing.Point(78, 12);
            this.sprmake2Control.Name = "sprmake2Control";
            this.sprmake2Control.Size = new System.Drawing.Size(421, 20);
            this.sprmake2Control.TabIndex = 3;
            // 
            // sprmake2Label
            // 
            this.sprmake2Label.Location = new System.Drawing.Point(12, 10);
            this.sprmake2Label.Name = "sprmake2Label";
            this.sprmake2Label.Size = new System.Drawing.Size(60, 22);
            this.sprmake2Label.TabIndex = 2;
            this.sprmake2Label.Text = "sprmake2:";
            this.sprmake2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // consoleOutputControl
            // 
            this.consoleOutputControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOutputControl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleOutputControl.Location = new System.Drawing.Point(12, 269);
            this.consoleOutputControl.Multiline = true;
            this.consoleOutputControl.Name = "consoleOutputControl";
            this.consoleOutputControl.ReadOnly = true;
            this.consoleOutputControl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutputControl.Size = new System.Drawing.Size(568, 292);
            this.consoleOutputControl.TabIndex = 0;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.txt2defControl);
            this.optionsGroupBox.Controls.Add(this.clearOptionControl);
            this.optionsGroupBox.Controls.Add(this.vvControl);
            this.optionsGroupBox.Controls.Add(this.vControl);
            this.optionsGroupBox.Controls.Add(this.vqControl);
            this.optionsGroupBox.Controls.Add(this.qControl);
            this.optionsGroupBox.Controls.Add(this.pControl);
            this.optionsGroupBox.Controls.Add(this.fControl);
            this.optionsGroupBox.Controls.Add(this.cControl);
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 99);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(568, 135);
            this.optionsGroupBox.TabIndex = 1;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // vvControl
            // 
            this.vvControl.Location = new System.Drawing.Point(252, 42);
            this.vvControl.Name = "vvControl";
            this.vvControl.Size = new System.Drawing.Size(240, 17);
            this.vvControl.TabIndex = 6;
            this.vvControl.Text = "Very verbose (-V)";
            this.vvControl.UseVisualStyleBackColor = true;
            // 
            // vControl
            // 
            this.vControl.Location = new System.Drawing.Point(252, 19);
            this.vControl.Name = "vControl";
            this.vControl.Size = new System.Drawing.Size(240, 17);
            this.vControl.TabIndex = 5;
            this.vControl.Text = "Verbose (-v)";
            this.vControl.UseVisualStyleBackColor = true;
            // 
            // vqControl
            // 
            this.vqControl.Location = new System.Drawing.Point(6, 111);
            this.vqControl.Name = "vqControl";
            this.vqControl.Size = new System.Drawing.Size(240, 17);
            this.vqControl.TabIndex = 4;
            this.vqControl.Text = "Very quiet (no errors) (-Q)";
            this.vqControl.UseVisualStyleBackColor = true;
            // 
            // qControl
            // 
            this.qControl.Location = new System.Drawing.Point(6, 88);
            this.qControl.Name = "qControl";
            this.qControl.Size = new System.Drawing.Size(240, 17);
            this.qControl.TabIndex = 3;
            this.qControl.Text = "Quiet (except warnings and errors) (-q)";
            this.qControl.UseVisualStyleBackColor = true;
            // 
            // pControl
            // 
            this.pControl.Location = new System.Drawing.Point(6, 65);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(240, 17);
            this.pControl.TabIndex = 2;
            this.pControl.Text = "Link duplicate palettes (-p)";
            this.pControl.UseVisualStyleBackColor = true;
            // 
            // fControl
            // 
            this.fControl.Location = new System.Drawing.Point(6, 42);
            this.fControl.Name = "fControl";
            this.fControl.Size = new System.Drawing.Size(240, 17);
            this.fControl.TabIndex = 1;
            this.fControl.Text = "Link duplicate files (-f)";
            this.fControl.UseVisualStyleBackColor = true;
            // 
            // cControl
            // 
            this.cControl.Location = new System.Drawing.Point(6, 19);
            this.cControl.Name = "cControl";
            this.cControl.Size = new System.Drawing.Size(240, 17);
            this.cControl.TabIndex = 0;
            this.cControl.Text = "Automatically crop (-c)";
            this.cControl.UseVisualStyleBackColor = true;
            // 
            // inputControl
            // 
            this.inputControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputControl.Location = new System.Drawing.Point(78, 41);
            this.inputControl.Name = "inputControl";
            this.inputControl.Size = new System.Drawing.Size(421, 20);
            this.inputControl.TabIndex = 4;
            // 
            // outputControl
            // 
            this.outputControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputControl.Location = new System.Drawing.Point(204, 70);
            this.outputControl.Name = "outputControl";
            this.outputControl.Size = new System.Drawing.Size(295, 20);
            this.outputControl.TabIndex = 5;
            // 
            // inputLabel
            // 
            this.inputLabel.Location = new System.Drawing.Point(12, 39);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(60, 22);
            this.inputLabel.TabIndex = 6;
            this.inputLabel.Text = "DEF input:";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 70);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(60, 22);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "Output to:";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputTypeControl
            // 
            this.outputTypeControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputTypeControl.FormattingEnabled = true;
            this.outputTypeControl.Items.AddRange(new object[] {
            "From DEF",
            "Custom"});
            this.outputTypeControl.Location = new System.Drawing.Point(78, 70);
            this.outputTypeControl.Name = "outputTypeControl";
            this.outputTypeControl.Size = new System.Drawing.Size(120, 21);
            this.outputTypeControl.TabIndex = 8;
            // 
            // sprmake2BrowseControl
            // 
            this.sprmake2BrowseControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sprmake2BrowseControl.Location = new System.Drawing.Point(505, 12);
            this.sprmake2BrowseControl.Name = "sprmake2BrowseControl";
            this.sprmake2BrowseControl.Size = new System.Drawing.Size(75, 23);
            this.sprmake2BrowseControl.TabIndex = 9;
            this.sprmake2BrowseControl.Text = "Browse...";
            this.sprmake2BrowseControl.UseVisualStyleBackColor = true;
            // 
            // inputBrowseControl
            // 
            this.inputBrowseControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBrowseControl.Location = new System.Drawing.Point(505, 41);
            this.inputBrowseControl.Name = "inputBrowseControl";
            this.inputBrowseControl.Size = new System.Drawing.Size(75, 23);
            this.inputBrowseControl.TabIndex = 10;
            this.inputBrowseControl.Text = "Browse...";
            this.inputBrowseControl.UseVisualStyleBackColor = true;
            // 
            // outputBrowseControl
            // 
            this.outputBrowseControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBrowseControl.Location = new System.Drawing.Point(505, 70);
            this.outputBrowseControl.Name = "outputBrowseControl";
            this.outputBrowseControl.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseControl.TabIndex = 11;
            this.outputBrowseControl.Text = "Browse...";
            this.outputBrowseControl.UseVisualStyleBackColor = true;
            // 
            // compileControl
            // 
            this.compileControl.Location = new System.Drawing.Point(12, 240);
            this.compileControl.Name = "compileControl";
            this.compileControl.Size = new System.Drawing.Size(75, 23);
            this.compileControl.TabIndex = 12;
            this.compileControl.Text = "Compile";
            this.compileControl.UseVisualStyleBackColor = true;
            // 
            // commandPreviewControl
            // 
            this.commandPreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandPreviewControl.Location = new System.Drawing.Point(174, 240);
            this.commandPreviewControl.Name = "commandPreviewControl";
            this.commandPreviewControl.ReadOnly = true;
            this.commandPreviewControl.Size = new System.Drawing.Size(406, 20);
            this.commandPreviewControl.TabIndex = 13;
            // 
            // clearControl
            // 
            this.clearControl.Location = new System.Drawing.Point(93, 240);
            this.clearControl.Name = "clearControl";
            this.clearControl.Size = new System.Drawing.Size(75, 23);
            this.clearControl.TabIndex = 14;
            this.clearControl.Text = "Clear output";
            this.clearControl.UseVisualStyleBackColor = true;
            // 
            // clearOptionControl
            // 
            this.clearOptionControl.Location = new System.Drawing.Point(252, 88);
            this.clearOptionControl.Name = "clearOptionControl";
            this.clearOptionControl.Size = new System.Drawing.Size(240, 17);
            this.clearOptionControl.TabIndex = 7;
            this.clearOptionControl.Text = "Clear output before compiling";
            this.clearOptionControl.UseVisualStyleBackColor = true;
            // 
            // txt2defControl
            // 
            this.txt2defControl.Location = new System.Drawing.Point(252, 65);
            this.txt2defControl.Name = "txt2defControl";
            this.txt2defControl.Size = new System.Drawing.Size(240, 17);
            this.txt2defControl.TabIndex = 8;
            this.txt2defControl.Text = "Convert sffv1 to sffv2 (-txt2def)";
            this.txt2defControl.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 573);
            this.Controls.Add(this.clearControl);
            this.Controls.Add(this.commandPreviewControl);
            this.Controls.Add(this.compileControl);
            this.Controls.Add(this.outputBrowseControl);
            this.Controls.Add(this.inputBrowseControl);
            this.Controls.Add(this.sprmake2BrowseControl);
            this.Controls.Add(this.outputTypeControl);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputControl);
            this.Controls.Add(this.inputControl);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.consoleOutputControl);
            this.Controls.Add(this.sprmake2Control);
            this.Controls.Add(this.sprmake2Label);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Main";
            this.Text = "sprmake2 GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exiting);
            this.optionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sprmake2Control;
        private System.Windows.Forms.Label sprmake2Label;
        private System.Windows.Forms.TextBox consoleOutputControl;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox vvControl;
        private System.Windows.Forms.CheckBox vControl;
        private System.Windows.Forms.CheckBox vqControl;
        private System.Windows.Forms.CheckBox qControl;
        private System.Windows.Forms.CheckBox pControl;
        private System.Windows.Forms.CheckBox fControl;
        private System.Windows.Forms.CheckBox cControl;
        private System.Windows.Forms.TextBox inputControl;
        private System.Windows.Forms.TextBox outputControl;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ComboBox outputTypeControl;
        private System.Windows.Forms.Button sprmake2BrowseControl;
        private System.Windows.Forms.Button inputBrowseControl;
        private System.Windows.Forms.Button outputBrowseControl;
        private System.Windows.Forms.Button compileControl;
        private System.Windows.Forms.TextBox commandPreviewControl;
        private System.Windows.Forms.Button clearControl;
        private System.Windows.Forms.CheckBox clearOptionControl;
        private System.Windows.Forms.CheckBox txt2defControl;
    }
}

