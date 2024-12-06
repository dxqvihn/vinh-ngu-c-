using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp_CW.GameForm;

namespace WindowsFormsApp_CW
{
    public partial class PlayerForm : Form


    {
        List<QuestionBank> banks = new List<QuestionBank>();
        public PlayerForm(List<QuestionBank> banks)
        {
            InitializeComponent(); // Đảm bảo gọi hàm này
            this.banks = banks;
        }

        public class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }

            // Constructor với tham số tên người chơi
            public Player(string name)
            {
                Name = name;
                Score = 0;  // Khởi tạo điểm ban đầu là 0
            }

            // Phương thức thêm điểm cho người chơi
            public void AddScore()
            {
                Score++;
            }
        }



        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string name = txbPlayerName.Text; // Lấy tên người chơi từ TextBox

            // Tạo đối tượng GameForm
            GameForm gameForm = new GameForm(banks);

            // Gửi tên vào Label trong GameForm
            gameForm.SetNameToLabel(name);

            // Hiển thị GameForm
            gameForm.Show();

            // Ẩn Form hiện tại (Form1)
            this.Hide();



        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

        


