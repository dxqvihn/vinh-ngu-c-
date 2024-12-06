using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_CW
{
    public partial class OpenQuestion : Form
    {
        private List<QuestionBank> banks = new List<QuestionBank>();
        public OpenQuestion(List<QuestionBank> banks)
        {
            InitializeComponent();
            this.banks = banks;
        }

        private void OpenQuestion_Load(object sender, EventArgs e)
        {

        }

        private void btnaddopenquestion_Click(object sender, EventArgs e)
        {
            string questionText = tbopenquestion.Text;
            string correctAnswer = tbanswerquestion.Text;
            if (string.IsNullOrEmpty(questionText))
            {
                MessageBox.Show("Please enter a question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            var openQuestions = new openQuestion(questionText, correctAnswer);
            banks.Add(openQuestions);
            MessageBox.Show("Open Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
