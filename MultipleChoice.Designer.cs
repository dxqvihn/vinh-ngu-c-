namespace WindowsFormsApp_CW
{
    partial class MultipleChoice
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
            this.tbquestionmtp = new System.Windows.Forms.TextBox();
            this.btnaddquestionmtp = new System.Windows.Forms.Button();
            this.tbchoice1 = new System.Windows.Forms.TextBox();
            this.tbchoice2 = new System.Windows.Forms.TextBox();
            this.tbchoice3 = new System.Windows.Forms.TextBox();
            this.tbchoice4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCorrectAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbquestionmtp
            // 
            this.tbquestionmtp.Location = new System.Drawing.Point(156, 40);
            this.tbquestionmtp.Multiline = true;
            this.tbquestionmtp.Name = "tbquestionmtp";
            this.tbquestionmtp.Size = new System.Drawing.Size(365, 63);
            this.tbquestionmtp.TabIndex = 0;
            // 
            // btnaddquestionmtp
            // 
            this.btnaddquestionmtp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnaddquestionmtp.ForeColor = System.Drawing.Color.White;
            this.btnaddquestionmtp.Location = new System.Drawing.Point(567, 58);
            this.btnaddquestionmtp.Name = "btnaddquestionmtp";
            this.btnaddquestionmtp.Size = new System.Drawing.Size(132, 32);
            this.btnaddquestionmtp.TabIndex = 1;
            this.btnaddquestionmtp.Text = "Add question";
            this.btnaddquestionmtp.UseVisualStyleBackColor = false;
            this.btnaddquestionmtp.Click += new System.EventHandler(this.btnaddquestionmtp_Click);
            // 
            // tbchoice1
            // 
            this.tbchoice1.Location = new System.Drawing.Point(156, 151);
            this.tbchoice1.Name = "tbchoice1";
            this.tbchoice1.Size = new System.Drawing.Size(178, 22);
            this.tbchoice1.TabIndex = 2;
            // 
            // tbchoice2
            // 
            this.tbchoice2.Location = new System.Drawing.Point(156, 196);
            this.tbchoice2.Name = "tbchoice2";
            this.tbchoice2.Size = new System.Drawing.Size(178, 22);
            this.tbchoice2.TabIndex = 3;
            // 
            // tbchoice3
            // 
            this.tbchoice3.Location = new System.Drawing.Point(156, 243);
            this.tbchoice3.Name = "tbchoice3";
            this.tbchoice3.Size = new System.Drawing.Size(178, 22);
            this.tbchoice3.TabIndex = 4;
            // 
            // tbchoice4
            // 
            this.tbchoice4.Location = new System.Drawing.Point(156, 291);
            this.tbchoice4.Name = "tbchoice4";
            this.tbchoice4.Size = new System.Drawing.Size(178, 22);
            this.tbchoice4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(90, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choice 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(90, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choice 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(90, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choice 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(91, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choice 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correct Answer";
            // 
            // tbCorrectAnswer
            // 
            this.tbCorrectAnswer.Location = new System.Drawing.Point(567, 173);
            this.tbCorrectAnswer.Name = "tbCorrectAnswer";
            this.tbCorrectAnswer.Size = new System.Drawing.Size(156, 22);
            this.tbCorrectAnswer.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(714, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "3Tgame.com";
            // 
            // MultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCorrectAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbchoice4);
            this.Controls.Add(this.tbchoice3);
            this.Controls.Add(this.tbchoice2);
            this.Controls.Add(this.tbchoice1);
            this.Controls.Add(this.btnaddquestionmtp);
            this.Controls.Add(this.tbquestionmtp);
            this.Name = "MultipleChoice";
            this.Text = "MultipleChoice";
            this.Load += new System.EventHandler(this.MultipleChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnaddquestionmtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCorrectAnswer;
        public System.Windows.Forms.TextBox tbchoice1;
        public System.Windows.Forms.TextBox tbchoice2;
        public System.Windows.Forms.TextBox tbchoice3;
        public System.Windows.Forms.TextBox tbchoice4;
        public System.Windows.Forms.TextBox tbquestionmtp;
        private System.Windows.Forms.Label label7;
    }
}