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
    public partial class CreatorForm : Form
    {
       public List<QuestionBank> banks = new List<QuestionBank>();

            public CreatorForm()
            {
                InitializeComponent();
                
                
            }


        // Hàm xử lý khi nhấn nút Thêm câu hỏi
        private void BtnAddQuestion_Click(object sender, EventArgs e)
            {
                    string typequestion = cboQuestionType.Text;
            

            List<string> options = new List<string>(); // Will hold answer choices


            if (typequestion == "Multiple Choice")
            {
                

                MultipleChoice multipleChoice = new MultipleChoice(banks);
                multipleChoice.Show();
                


                }
            else if (typequestion == "Open")
            {
                
                OpenQuestion openQuestion = new OpenQuestion(banks);
                openQuestion.Show();
                
            }
            else
            {
                
                TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(banks);
                trueFalseQuestion.Show();

            }
        }

        

        private void btn_display_Click(object sender, EventArgs e)
        {
            txtAnswer.Clear();  

            if (banks.Count > 0)
            {
                for (int i = 0; i < banks.Count; i++)
                {
                    var currentQuestion = banks[i];
                    if (currentQuestion is multipleChoice multipleChoiceQuestion)

                    {
                        txtAnswer.Text = $"Question: {i + 1} " + Environment.NewLine;

                        for (int j = 0; j < multipleChoiceQuestion.Choices.Count; i++)
                        {
                            txtAnswer.Text += $"{j + 1}. {multipleChoiceQuestion.Choices[j]}" + Environment.NewLine;
                        }
                    }

                    else if (currentQuestion is openQuestion openQuestions)
                    {
                        // In câu hỏi vào TextBox
                        txtAnswer.Text += "Question: " + openQuestions.QuestionText + Environment.NewLine;

                        // Thêm một thông báo yêu cầu trả lời
                        txtAnswer.Text += "Answer: " + openQuestions.CorrectAnswer + Environment.NewLine;
                    }

                    else if (currentQuestion is trueFalseQuestion TFQuestion)
                    {
                        txtAnswer.Text += TFQuestion.QuestionText + Environment.NewLine;
                        txtAnswer.Text += "Answer(true/false): " + TFQuestion.CorrectAnswer  + Environment.NewLine;  // Thêm thông báo yêu cầu trả lời đúng/sai
                    }


                    txtAnswer.Text += Environment.NewLine;
                }
            }
            else
            {
                // Nếu không có câu hỏi nào trong banks
                txtAnswer.Text = "No questions available.";
            }
    }



        // Hàm xử lý khi nhấn nút Sửa câu hỏi
        private void BtnEditQuestion_Click(object sender, EventArgs e)
            {
            // Kiểm tra nếu người dùng đã nhập số câu hỏi hợp lệ
            if (int.TryParse(tbnumberofQuestion.Text, out int questionNumber))
            {
                // Kiểm tra nếu câu hỏi có trong danh sách (indexes bắt đầu từ 0, nên phải trừ 1)
                if (questionNumber > 0 && questionNumber <= banks.Count)
                {
                    // Lấy câu hỏi cần chỉnh sửa từ danh sách
                    var currentQuestion = banks[questionNumber - 1];

                    // Kiểm tra nếu câu hỏi là loại MultipleChoice
                    if (currentQuestion is multipleChoice multipleChoiceQuestion)
                    {
                        // Mở form MultipleChoice và hiển thị câu hỏi hiện tại
                        MultipleChoice multipleChoiceForm = new MultipleChoice(banks);
                        multipleChoiceForm.tbquestionmtp.Text = multipleChoiceQuestion.QuestionText;

                        // Hiển thị các lựa chọn vào các TextBox
                        multipleChoiceForm.tbchoice1.Text = multipleChoiceQuestion.Choices.ElementAtOrDefault(0);
                        multipleChoiceForm.tbchoice2.Text = multipleChoiceQuestion.Choices.ElementAtOrDefault(1);
                        multipleChoiceForm.tbchoice3.Text = multipleChoiceQuestion.Choices.ElementAtOrDefault(2);
                        multipleChoiceForm.tbchoice4.Text = multipleChoiceQuestion.Choices.ElementAtOrDefault(3);

                        // Mở form để người dùng chỉnh sửa
                        multipleChoiceForm.Show();
                    }
                    // Kiểm tra nếu câu hỏi là loại OpenQuestion
                    else if (currentQuestion is openQuestion openQuestion)
                    {
                        // Mở form OpenQuestion và hiển thị câu hỏi hiện tại
                        OpenQuestion openQuestionForm = new OpenQuestion(banks);
                        openQuestionForm.tbopenquestion.Text = openQuestion.QuestionText;

                        // Mở form để người dùng chỉnh sửa
                        openQuestionForm.Show();
                    }
                    // Kiểm tra nếu câu hỏi là loại True/False
                    else if (currentQuestion is trueFalseQuestion trueFalseQuestion)
                    {
                        // Mở form TrueFalseQuestion và hiển thị câu hỏi hiện tại
                        TrueFalseQuestion trueFalseForm = new TrueFalseQuestion(banks);
                        trueFalseForm.tbTFquestion.Text = trueFalseQuestion.QuestionText;

                        // Hiển thị đáp án đúng
                        trueFalseForm.cbAnswerTFQuestion.SelectedItem = trueFalseQuestion.CorrectAnswer ? "True" : "False";

                        // Mở form để người dùng chỉnh sửa
                        trueFalseForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid question number. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid question number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // Hàm xử lý khi nhấn nút Xóa câu hỏi
            private void BtnDeleteQuestion_Click(object sender, EventArgs e)
            {
            // Kiểm tra nếu người dùng đã nhập số câu hỏi hợp lệ
            if (int.TryParse(tbnumberofQuestion.Text, out int questionNumber))
            {
                // Kiểm tra nếu câu hỏi có trong danh sách (indexes bắt đầu từ 0, nên phải trừ 1)
                if (questionNumber > 0 && questionNumber <= banks.Count)
                {
                    // Lấy câu hỏi cần xóa từ danh sách
                    var currentQuestion = banks[questionNumber - 1];

                    // Xóa câu hỏi khỏi danh sách
                    banks.RemoveAt(questionNumber - 1);

                    // Hiển thị thông báo thành công
                    MessageBox.Show($"Question {questionNumber} has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách câu hỏi trên giao diện ngay lập tức
                    txtAnswer.Clear();  // Xóa nội dung cũ trong txtAnswer
                      

                }
                else
                {
                    // Thông báo nếu câu hỏi không tồn tại
                    MessageBox.Show("Invalid question number. Please enter a valid question number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Thông báo nếu số câu hỏi không hợp lệ
                MessageBox.Show("Please enter a valid question number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            // Sự kiện khi form được tải
            private void CreatorForm_Load(object sender, EventArgs e)
            {
                
            }

        

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
    }



    

