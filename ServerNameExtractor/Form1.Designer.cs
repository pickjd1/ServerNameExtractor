namespace ServerNameExtractor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.instructionLabel = new System.Windows.Forms.Label();
            this.tBxFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.savedLocationInstruction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.instructionLabel.Location = new System.Drawing.Point(298, 128);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(212, 13);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a File to Extract Server Names From:";
            // 
            // tBxFilePath
            // 
            this.tBxFilePath.BackColor = System.Drawing.SystemColors.Info;
            this.tBxFilePath.Location = new System.Drawing.Point(159, 144);
            this.tBxFilePath.Name = "tBxFilePath";
            this.tBxFilePath.Size = new System.Drawing.Size(474, 20);
            this.tBxFilePath.TabIndex = 1;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(368, 170);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath.TabIndex = 2;
            this.btnFilePath.Text = "Browse";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(159, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(474, 331);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(354, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output File Preview:";
            // 
            // savedLocationInstruction
            // 
            this.savedLocationInstruction.AutoSize = true;
            this.savedLocationInstruction.BackColor = System.Drawing.Color.Transparent;
            this.savedLocationInstruction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.savedLocationInstruction.Location = new System.Drawing.Point(275, 596);
            this.savedLocationInstruction.Name = "savedLocationInstruction";
            this.savedLocationInstruction.Size = new System.Drawing.Size(270, 13);
            this.savedLocationInstruction.TabIndex = 5;
            this.savedLocationInstruction.Text = "Files are saved to the same location as the imported file.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(744, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please export server lists via the appropriate ESA page. Then use this tool too c" +
    "onvert the exported file too a Remote Desktop Connection Manager text file. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(239, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "The servers will still need to be sorted into groups within RDCM.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 657);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savedLocationInstruction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.tBxFilePath);
            this.Controls.Add(this.instructionLabel);
            this.Name = "MainForm";
            this.Text = "ESA File Export - Server Name Extraction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.TextBox tBxFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label savedLocationInstruction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

