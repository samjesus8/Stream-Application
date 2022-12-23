namespace StreamLab
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.quoteBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repeatTrackBar = new System.Windows.Forms.TrackBar();
            this.appendButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.jsonWriteButton = new System.Windows.Forms.Button();
            this.jsonLoadButton = new System.Windows.Forms.Button();
            this.member1Box = new System.Windows.Forms.TextBox();
            this.member2Box = new System.Windows.Forms.TextBox();
            this.member3Box = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.repeatTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quote";
            // 
            // quoteBox
            // 
            this.quoteBox.Location = new System.Drawing.Point(46, 29);
            this.quoteBox.Margin = new System.Windows.Forms.Padding(2);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.Size = new System.Drawing.Size(293, 20);
            this.quoteBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repeats";
            // 
            // repeatTrackBar
            // 
            this.repeatTrackBar.Location = new System.Drawing.Point(61, 72);
            this.repeatTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.repeatTrackBar.Name = "repeatTrackBar";
            this.repeatTrackBar.Size = new System.Drawing.Size(336, 45);
            this.repeatTrackBar.TabIndex = 3;
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(352, 10);
            this.appendButton.Margin = new System.Windows.Forms.Padding(2);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(56, 57);
            this.appendButton.TabIndex = 4;
            this.appendButton.Text = "Append to .txt";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.appendButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(15, 309);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(56, 58);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load from .txt";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 104);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 104);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 104);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "10";
            // 
            // jsonWriteButton
            // 
            this.jsonWriteButton.Location = new System.Drawing.Point(258, 196);
            this.jsonWriteButton.Margin = new System.Windows.Forms.Padding(2);
            this.jsonWriteButton.Name = "jsonWriteButton";
            this.jsonWriteButton.Size = new System.Drawing.Size(56, 57);
            this.jsonWriteButton.TabIndex = 20;
            this.jsonWriteButton.Text = "Append to .json";
            this.jsonWriteButton.UseVisualStyleBackColor = true;
            this.jsonWriteButton.Click += new System.EventHandler(this.jsonWriteButton_Click);
            // 
            // jsonLoadButton
            // 
            this.jsonLoadButton.Location = new System.Drawing.Point(77, 309);
            this.jsonLoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.jsonLoadButton.Name = "jsonLoadButton";
            this.jsonLoadButton.Size = new System.Drawing.Size(56, 58);
            this.jsonLoadButton.TabIndex = 21;
            this.jsonLoadButton.Text = "Load from .json";
            this.jsonLoadButton.UseVisualStyleBackColor = true;
            this.jsonLoadButton.Click += new System.EventHandler(this.jsonLoadButton_Click);
            // 
            // member1Box
            // 
            this.member1Box.Location = new System.Drawing.Point(74, 177);
            this.member1Box.Name = "member1Box";
            this.member1Box.Size = new System.Drawing.Size(161, 20);
            this.member1Box.TabIndex = 22;
            // 
            // member2Box
            // 
            this.member2Box.Location = new System.Drawing.Point(74, 215);
            this.member2Box.Name = "member2Box";
            this.member2Box.Size = new System.Drawing.Size(161, 20);
            this.member2Box.TabIndex = 23;
            // 
            // member3Box
            // 
            this.member3Box.Location = new System.Drawing.Point(74, 253);
            this.member3Box.Name = "member3Box";
            this.member3Box.Size = new System.Drawing.Size(161, 20);
            this.member3Box.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Member 1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Member 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Member 3";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(15, 381);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(543, 175);
            this.outputBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(570, 568);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.member3Box);
            this.Controls.Add(this.member2Box);
            this.Controls.Add(this.member1Box);
            this.Controls.Add(this.jsonLoadButton);
            this.Controls.Add(this.jsonWriteButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.appendButton);
            this.Controls.Add(this.repeatTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Stream Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repeatTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quoteBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar repeatTrackBar;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button jsonWriteButton;
        private System.Windows.Forms.Button jsonLoadButton;
        private System.Windows.Forms.TextBox member1Box;
        private System.Windows.Forms.TextBox member2Box;
        private System.Windows.Forms.TextBox member3Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox outputBox;
    }
}

