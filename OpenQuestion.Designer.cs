namespace WindowsFormsApp_CW
{
    partial class OpenQuestion
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
            this.btnaddopenquestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbopenquestion = new System.Windows.Forms.TextBox();
            this.tbanswerquestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddopenquestion
            // 
            this.btnaddopenquestion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnaddopenquestion.ForeColor = System.Drawing.Color.White;
            this.btnaddopenquestion.Location = new System.Drawing.Point(506, 100);
            this.btnaddopenquestion.Name = "btnaddopenquestion";
            this.btnaddopenquestion.Size = new System.Drawing.Size(119, 32);
            this.btnaddopenquestion.TabIndex = 0;
            this.btnaddopenquestion.Text = "Add Question";
            this.btnaddopenquestion.UseVisualStyleBackColor = false;
            this.btnaddopenquestion.Click += new System.EventHandler(this.btnaddopenquestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // tbopenquestion
            // 
            this.tbopenquestion.Location = new System.Drawing.Point(96, 70);
            this.tbopenquestion.Multiline = true;
            this.tbopenquestion.Name = "tbopenquestion";
            this.tbopenquestion.Size = new System.Drawing.Size(380, 83);
            this.tbopenquestion.TabIndex = 2;
            // 
            // tbanswerquestion
            // 
            this.tbanswerquestion.Location = new System.Drawing.Point(96, 226);
            this.tbanswerquestion.Multiline = true;
            this.tbanswerquestion.Name = "tbanswerquestion";
            this.tbanswerquestion.Size = new System.Drawing.Size(380, 88);
            this.tbanswerquestion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(97, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Answer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "3Tgame.com";
            // 
            // OpenQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbanswerquestion);
            this.Controls.Add(this.tbopenquestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddopenquestion);
            this.Name = "OpenQuestion";
            this.Text = "OpenQuestion";
            this.Load += new System.EventHandler(this.OpenQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddopenquestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbopenquestion;
        public System.Windows.Forms.TextBox tbanswerquestion;
        private System.Windows.Forms.Label label3;
    }
}