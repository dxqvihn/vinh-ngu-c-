using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_CW
{
    public abstract class QuestionBank
    {
        public string QuestionText { get; set; } // Nội dung câu hỏi

        // Phương thức kiểm tra câu trả lời, các lớp con sẽ phải cài đặt phương thức này
        public abstract bool CheckAnswer(string answer);
    }

    public class multipleChoice : QuestionBank
    {
        public string QuestionText { get; set; }
        
        public List<string> Choices { get; set; } // Các lựa chọn
        public string CorrectAnswer { get; set; } // Đáp án đúng

        public multipleChoice(string questionText,string correctAnswer, List<string> choice)
        {
            Choices = choice;
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }

        // Cài đặt phương thức CheckAnswer cho câu hỏi Multiple Choice
        public override bool CheckAnswer(string answer)
        {
            return answer.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class openQuestion : QuestionBank
    {
        public string CorrectAnswer { get; set; } // Đáp án đúng

        public openQuestion(string questionText, string correctAnswer)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }

        // Cài đặt phương thức CheckAnswer cho câu hỏi Open
        public override bool CheckAnswer(string answer)
        {
            return answer.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class trueFalseQuestion : QuestionBank
    {
        public bool CorrectAnswer { get; set; } // Đáp án đúng (true/false)

        public trueFalseQuestion(string questionText, bool correctAnswer)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
        }

        // Cài đặt phương thức CheckAnswer cho câu hỏi True/False
        public override bool CheckAnswer(string answer)
        {
            bool result;
            if (bool.TryParse(answer, out result))
            {
                return result == CorrectAnswer;
            }
            return false;
        }
    }
}
