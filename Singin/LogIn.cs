using Singin.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singin
{
    public partial class LogIn : Form
    {
       
       //存資料庫的user
        List<User> users = new List<User>();

        //登入的使用者
        User loginUser = new User();
        
        public LogIn()
        {
            Console.WriteLine("LogIn()");
            InitializeComponent();

            //資料會從資料庫拿到，目前尚未寫
            ReadDataFromDB();
            
        }

        //---------------------------API-----------------------------------------
        //從資料庫讀取所有的user，目前尚未寫
        private void ReadDataFromDB()
        {
            users.Add(new User("John", "2569"));
            users.Add(new User("Marry", "7831"));
            
        }

        //判斷textbox是否為empty
        public bool CheckTextboxEmpty(string userName, string password)
        {
            bool result = false;

            if (userName == "Username" && password == "Password")
            {
                MessageBox.Show("UserName and Password can't be blank !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                result = true;

            }
            else if (userName == "Username")
            {
                MessageBox.Show("UserName can't be blank !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = true;

            }
            else if(password == "Password")
            {
                MessageBox.Show("Password can't be blank !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = true;
            }

            return result;

        }

        //檢查使用者的帳密是否正確
        //需與資料庫比對，未完成
        public bool CheckMember(User user)
        {
            bool isVisible = true;

            for (int i = 0; i < users.Count; i++)
            {
                if ((user.Name == users[i].Name) && (user.Password == users[i].Password))
                {
                    isVisible = false;
                }
            }

            return isVisible;
        }

        //利用bool來宣告BackPage存在或消失
        private void DisplayBtnBack(bool isVisible)
        {
            this.btnBack.Visible = isVisible;
        }

        //利用bool來宣告LoginPage存在或消失
        private void DisplayLoginPage(bool isVisible)
        {
            this.mPanel.Visible = isVisible;
        }


        //---------------------------事件 event-----------------------------------------
        //Textbox一開始就顯示Password的字，所以以下作法為如何讓Textbox輸入字顯示*
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals(""))
                tbPassword.PasswordChar = '*';
            else if(tbPassword.Text.Equals("Password"))
                tbPassword.PasswordChar = '\0';
        }

        //Textbox一開始就顯示Username的字，則按下Textbox的事件
        private void Tb_Username_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
        }

        //讓Textbox一開始就顯示Username的字
        private void Tb_Username_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }
        }

        //Textbox一開始就顯示Password的字，則按下Textbox的事件
        private void Tb_password_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }

        //讓Textbox一開始就顯示Password的字
        private void Tb_password_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
            }
        }

        private void Btn_SingIn_Click(object sender, EventArgs e)
        {

            bool isTextboxEmpty = CheckTextboxEmpty(tbUsername.Text, tbPassword.Text);

            if (!isTextboxEmpty)
            {
                if (loginUser != null)
                {
                    loginUser.Name = tbUsername.Text;
                    loginUser.Password = tbPassword.Text;
                }

                if (!CheckMember(loginUser))
                {
                    //第一頁消失
                    //mPanel.Visible = false;
                    DisplayLoginPage(false);

                    //第二頁顯示
                    DisplayBtnBack(true);
                    lblLoginUserName.Text = "Welcome " + loginUser.Name + " !!";
                }
                else
                {
                    MessageBox.Show("Incorrect Username and Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Be sure to sign out", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DisplayLoginPage(true);
                DisplayBtnBack(false);
            }
        }

        //---------------------------lifecycle-----------------------------------------
        private void Control_HandleCreated(object sender, EventArgs e)
        {
            Console.WriteLine("Control_HandleCreated()");
        }

        private void Control_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Control_BindingContextChanged()");
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1_Load()");
        }

        private void Control_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Control_VisibleChanged()");
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form_Activated()");
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Form_Shown()");
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Form_Closed()");

        }
    }
}
