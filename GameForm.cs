using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_CW
{
    public partial class GameForm : Form
    {
        private List<QuestionBank> banks = new List<QuestionBank>();
        private int currentQuestionIndex = 0;
        private int score = 0;

        public GameForm(List<QuestionBank> createdQuestions)
        {
            InitializeComponent();

            // Lấy danh sách câu hỏi từ CreatorForm
            banks = createdQuestions;

            // Hiển thị câu hỏi đầu tiên
            DisplayCurrentQuestion();
        }



        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < banks.Count)
            {
                var question = banks[currentQuestionIndex];
                tbQuestionforPlayer.Text = question.QuestionText;
                

                // Cập nhật hướng dẫn tùy theo loại câu hỏi
                if (question is multipleChoice)
                {
                    var mcQuestion = question as multipleChoice;
                    tbPlayerAnswer.Text = $"Enter a number between 1 and 4\nChoices:\n1. {mcQuestion.Choices[0]}\n2. {mcQuestion.Choices[1]}\n3. {mcQuestion.Choices[2]}\n4. {mcQuestion.Choices[3]}";
                }
                else if (question is trueFalseQuestion)
                {
                    tbPlayerAnswer.Text = "Enter true or false";
                }
                else if (question is openQuestion)
                {
                    tbPlayerAnswer.Text = "Enter your answer";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submit button clicked!"); // Kiểm tra khi người chơi nhấn Submit.

            var playerAnswer = tbPlayerAnswer.Text.Trim(); // Người chơi nhập câu trả lời vào đây
            bool isCorrect = false;
            var currentQuestion = banks[currentQuestionIndex];

            if (currentQuestion is multipleChoice)
            {
                // Đảm bảo người chơi nhập đúng một số từ 1 đến 4
                if (int.TryParse(playerAnswer, out int choice) && choice >= 1 && choice <= 4)
                {
                    var mcQuestion = currentQuestion as multipleChoice;
                    isCorrect = mcQuestion.CheckAnswer(playerAnswer); // So sánh với đáp án đúng
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1 and 4.");
                    return;
                }
            }
            else if (currentQuestion is openQuestion)
            {
                isCorrect = currentQuestion.CheckAnswer(playerAnswer);
            }
            else if (currentQuestion is trueFalseQuestion)
            {
                if (playerAnswer.ToLower() == "true" || playerAnswer.ToLower() == "false")
                {
                    isCorrect = currentQuestion.CheckAnswer(playerAnswer);
                }
                else
                {
                    MessageBox.Show("Please enter 'true' or 'false'.");
                    return;
                }
            }

            if (isCorrect)
            {
                score++;
            }

            currentQuestionIndex++;

            // Hiển thị câu hỏi tiếp theo hoặc kết thúc game
            if (currentQuestionIndex < banks.Count)
            {
                DisplayCurrentQuestion();
            }
            else
            {
                MessageBox.Show($"Game Over! Your score is {score}");
                btnStartOver.Enabled = true;  // Kích hoạt nút "Start Over"
            }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            score = 0;
            currentQuestionIndex = 0;
            DisplayCurrentQuestion();
            btnStartOver.Enabled = false;
        }

        public void SetNameToLabel(string name)
        {
            lbPlName.Text = name; // label1 là tên Label trong Form2
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Loaded");
        }

        
    }
}
