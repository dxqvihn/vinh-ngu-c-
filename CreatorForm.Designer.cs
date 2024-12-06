namespace WindowsFormsApp_CW
{
    partial class CreatorForm
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
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.cboQuestionType = new System.Windows.Forms.ComboBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.tbnumberofQuestion = new System.Windows.Forms.TextBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(60, 103);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(500, 200);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // cboQuestionType
            // 
            this.cboQuestionType.FormattingEnabled = true;
            this.cboQuestionType.Items.AddRange(new object[] {
            "Multiple Choice",
            "Open",
            "True/False"});
            this.cboQuestionType.Location = new System.Drawing.Point(60, 59);
            this.cboQuestionType.Name = "cboQuestionType";
            this.cboQuestionType.Size = new System.Drawing.Size(154, 24);
            this.cboQuestionType.TabIndex = 2;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnAddQuestion.Location = new System.Drawing.Point(79, 30);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(100, 23);
            this.btnAddQuestion.TabIndex = 4;
            this.btnAddQuestion.Text = "Add question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.BtnAddQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(262, 30);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(100, 23);
            this.btnEditQuestion.TabIndex = 5;
            this.btnEditQuestion.Text = "Edit question";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.BtnEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(439, 30);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteQuestion.TabIndex = 6;
            this.btnDeleteQuestion.Text = "Delete question";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.BtnDeleteQuestion_Click);
            // 
            // tbnumberofQuestion
            // 
            this.tbnumberofQuestion.Location = new System.Drawing.Point(384, 31);
            this.tbnumberofQuestion.Name = "tbnumberofQuestion";
            this.tbnumberofQuestion.Size = new System.Drawing.Size(30, 22);
            this.tbnumberofQuestion.TabIndex = 7;
            // 
            // btn_display
            // 
            this.btn_display.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_display.Location = new System.Drawing.Point(262, 59);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(100, 23);
            this.btn_display.TabIndex = 8;
            this.btn_display.Text = "Display all";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "3Tgame.com";
            // 
            // CreatorForm
            // 
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.tbnumberofQuestion);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnEditQuestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.cboQuestionType);
            this.Name = "CreatorForm";
            this.Text = "Question Management";
            this.Load += new System.EventHandler(this.CreatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ComboBox cboQuestionType;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.TextBox tbnumberofQuestion;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Label label1;
    }
}