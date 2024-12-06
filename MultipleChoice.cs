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
    public partial class MultipleChoice : Form
    {
        private List<QuestionBank> banks = new List<QuestionBank>();
        public MultipleChoice(List<QuestionBank> banks)
        {
            InitializeComponent();
            this.banks = banks;
        }

        private void MultipleChoice_Load(object sender, EventArgs e)
        {

        }

        private void btnaddquestionmtp_Click(object sender, EventArgs e)
        {
            string questionText = tbquestionmtp.Text;
            if (string.IsNullOrEmpty(questionText))
            {
                MessageBox.Show("Please enter a question.");
                return;
            }

            var choices = new List<string>
        {
            tbchoice1.Text,
            tbchoice2.Text,
            tbchoice3.Text,
            tbchoice4.Text
        };

            // Kiểm tra nếu có bất kỳ lựa chọn nào bị trống
            if (choices.Exists(choice => string.IsNullOrEmpty(choice)))
            {
                MessageBox.Show("Please fill in all choices.");
                return;
            }

            // Khởi tạo câu hỏi multipleChoice với câu hỏi, đáp án đúng và các lựa chọn
            // (Giả sử bạn đã có phương thức để xác định đáp án đúng, ví dụ là tbCorrectAnswer.Text)
            string correctAnswer = tbCorrectAnswer.Text;  // Đáp án đúng

            if (string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("Please specify the correct answer.");
                return;
            }

            // Tạo đối tượng multipleChoice mới và thêm vào danh sách banks
            var multipleChoiceQuestion = new multipleChoice(questionText, correctAnswer, choices);
            banks.Add(multipleChoiceQuestion);  // Thêm câu hỏi vào danh sách


            MessageBox.Show("Question added successfully!");
           
        }

        
    }
}
