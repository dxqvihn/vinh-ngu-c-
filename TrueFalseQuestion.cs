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
    public partial class TrueFalseQuestion : Form
    {
        private List<QuestionBank> banks = new List<QuestionBank>();
        public TrueFalseQuestion(List<QuestionBank> banks)
        {
            InitializeComponent();
            this.banks = banks;
        }

        private void TrueFalseQuestion_Load(object sender, EventArgs e)
        {

        }

        private void btaddquestiontruefalse_Click(object sender, EventArgs e)
        {
            string questionText = tbTFquestion.Text;

            if (string.IsNullOrEmpty(questionText))
            {
                MessageBox.Show("Please enter a question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbAnswerTFQuestion.SelectedItem == null)
            {
                MessageBox.Show("Please select the correct answer (True/False).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy giá trị đáp án từ ComboBox
            bool correctAnswer = cbAnswerTFQuestion.SelectedItem.ToString() == "True"; // Nếu chọn True thì correctAnswer = true, ngược lại = false

            // Tạo đối tượng trueFalseQuestion
            var TFQuestion = new trueFalseQuestion(questionText, correctAnswer);

            // Thêm câu hỏi vào danh sách banks
            banks.Add(TFQuestion);

            // Hiển thị thông báo thành công
            MessageBox.Show("True/False Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
