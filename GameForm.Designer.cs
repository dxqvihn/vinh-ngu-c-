namespace WindowsFormsApp_CW
{
    partial class GameForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.lbPlName = new System.Windows.Forms.Label();
            this.tbQuestionforPlayer = new System.Windows.Forms.TextBox();
            this.tbPlayerAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Geography Quiz Game";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Orange;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(100, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.BackColor = System.Drawing.Color.Crimson;
            this.btnStartOver.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.ForeColor = System.Drawing.Color.White;
            this.btnStartOver.Location = new System.Drawing.Point(520, 444);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(200, 50);
            this.btnStartOver.TabIndex = 6;
            this.btnStartOver.Text = "StartOver";
            this.btnStartOver.UseVisualStyleBackColor = false;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // lbPlName
            // 
            this.lbPlName.AutoSize = true;
            this.lbPlName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbPlName.Location = new System.Drawing.Point(487, 13);
            this.lbPlName.Name = "lbPlName";
            this.lbPlName.Size = new System.Drawing.Size(111, 41);
            this.lbPlName.TabIndex = 7;
            this.lbPlName.Text = "Hello! ";
            // 
            // tbQuestionforPlayer
            // 
            this.tbQuestionforPlayer.Location = new System.Drawing.Point(47, 97);
            this.tbQuestionforPlayer.Multiline = true;
            this.tbQuestionforPlayer.Name = "tbQuestionforPlayer";
            this.tbQuestionforPlayer.Size = new System.Drawing.Size(307, 320);
            this.tbQuestionforPlayer.TabIndex = 8;
            // 
            // tbPlayerAnswer
            // 
            this.tbPlayerAnswer.Location = new System.Drawing.Point(457, 97);
            this.tbPlayerAnswer.Multiline = true;
            this.tbPlayerAnswer.Name = "tbPlayerAnswer";
            this.tbPlayerAnswer.Size = new System.Drawing.Size(307, 320);
            this.tbPlayerAnswer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(746, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "3Tgame.com";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlayerAnswer);
            this.Controls.Add(this.tbQuestionforPlayer);
            this.Controls.Add(this.lbPlName);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTitle);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Label lbPlName;
        private System.Windows.Forms.TextBox tbQuestionforPlayer;
        private System.Windows.Forms.TextBox tbPlayerAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}