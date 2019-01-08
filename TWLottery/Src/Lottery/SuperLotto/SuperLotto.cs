using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TWLottery.Src.Lottery.SuperLotto
{
    public partial class SuperLotto : Form
    {
        List<Button> LotteryNumber = new List<Button>();
        //儲存按鈕按下時的number
        string prompt;
        //80顆按鈕
        List<Button> buttonBox1 = new List<Button>();
        //對照組按鈕
        List<Button> tempButtonBox1 = new List<Button>();
        //80顆按鈕
        List<Button> buttonBox2 = new List<Button>();
        //對照組按鈕
        List<Button> tempButtonBox2 = new List<Button>();

        public SuperLotto()
        {
            InitializeComponent();
            Panel panelFirstDistrict = DynamicGenerationButton1(4, 10, 38, 40, 40, 165, 80);
            Panel panelSecondDistrict = DynamicGenerationButton2(2, 4, 8, 40, 40, 300, 55);
        }

        private void SuperLotto_Load(object sender, EventArgs e)
        {

        }
        
        //第一區的38顆按鈕
        public void Bt_LotteryNumber1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            //改變按鈕顏色
            prompt += btn.Text + "  ";

            //改變按鈕顏色
            ChangeBtnBackground(btn);

            if (tempButtonBox1 == null)
                tempButtonBox1 = new List<Button>();

            if (buttonBox1 == null)
                buttonBox1 = new List<Button>();

            //若按的按鈕是同一顆，從對照組中移除
            if (tempButtonBox1.Contains(btn))
            {
                tempButtonBox1.Remove(btn);
                //每一顆按鈕都恢復可以按
                if (tempButtonBox1.Count == (6 -1))
                {
                    foreach (Button b in buttonBox1)
                    {
                        b.Enabled = true;
                    }
                }
                return;
            }
            else
            {
                //若對照組沒有此按鈕則加入
                if (tempButtonBox1.Count < 6)
                    tempButtonBox1.Add(btn);
                //若已達上限
                if (tempButtonBox1.Count == 6)
                {
                    //除對照組以外，所有按鈕都不能按
                    foreach (Button b in buttonBox1)
                    {
                        if (tempButtonBox1.Contains(b))
                            b.Enabled = true;
                        else
                            b.Enabled = false;
                    }
                }
            }


            

        }

        private void ChangeBtnBackground(Button btn)
        {
            if (btn.BackColor == Color.Gainsboro)
            {
                btn.BackColor = Color.Orange;
            }
            else
            {
                btn.BackColor = Color.Gainsboro;
            }
        }

        
        //第二區的8顆按鈕
        public void Bt_LotteryNumber2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            prompt += btn.Text + "  ";

            //改變按鈕顏色
            ChangeBtnBackground(btn);

            if (tempButtonBox2 == null)
                tempButtonBox2 = new List<Button>();

            if (buttonBox2 == null)
                buttonBox2 = new List<Button>();

            //若按的按鈕是同一顆，從對照組中移除
            if (tempButtonBox2.Contains(btn))
            {
                tempButtonBox2.Remove(btn);
                //每一顆按鈕都恢復可以按
                if (tempButtonBox2.Count == (1-1))
                {
                    foreach (Button b in buttonBox2)
                    {
                        b.Enabled = true;
                    }
                }
                return;
            }
            else
            {
                //若對照組沒有此按鈕則加入
                if (tempButtonBox2.Count < 1)
                    tempButtonBox2.Add(btn);
                //若已達上限
                if (tempButtonBox2.Count == 1)
                {
                    //除對照組以外，所有按鈕都不能按
                    foreach (Button b in buttonBox2)
                    {
                        if (tempButtonBox2.Contains(b))
                            b.Enabled = true;
                        else
                            b.Enabled = false;
                    }
                }
            }
        }

        private void Btn_ShowLotteryWebsite_Click(object sender, EventArgs e)
        {
            if (button1.Visible == true)
            {
                webBrowser1.Visible = true;
                this.webBrowser1.Navigate("http://www.taiwanlottery.com.tw/Lotto/BINGOBINGO/drawing.aspx");
                button1.Visible = false;
                button2.Visible = true;

            }
        }

        private void Btn_CloseLotteryWebsite_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            webBrowser1.Visible = false;
            button2.Visible = false;
        }

        private void BtnPrize_Click(object sender, EventArgs e)
        {
            List<int> myArray = new List<int>();
            myArray = RandomNumber();
            RandomNumberSort(myArray);
        }
        int temp = 0;
        //隨機產生號碼在lab上
        private List<int> RandomNumber()
        {
            lblprizeNumber.Text = "";
            List<int> myArray = new List<int>();
            int number;
            System.Random num = new Random();

            for (int i = 0; i < 7; i++)
            {
                do
                {
                    number = num.Next(1, 38);
                }
                while (myArray.IndexOf(number) != -1);
                myArray.Add(number);
            }

            
            temp = myArray[6];
            lblprizeSuperNumber.Text = temp.ToString();
            myArray.Remove(myArray[6]);
            

            foreach (int prizeNumber in myArray)
            {
                lblprizeNumber.Text += prizeNumber + ",";
            }

            lblprizeNumber.Text = lblprizeNumber.Text.TrimEnd(',');


            return myArray;
        }
        //搭配RandomNumber涵式做排序
        private void RandomNumberSort(List<int> myArray)
        {
            lblprizeNumberSort.Text = "";
            
            myArray.Sort();

            foreach (int prizeNumber in myArray)
            {
                lblprizeNumberSort.Text += prizeNumber + ",";
            }

            lblprizeNumberSort.Text = lblprizeNumberSort.Text.TrimEnd(',');
            lblprizeSuperNumberSort.Text = temp.ToString();
        }
        
        private void BtnDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            //單選
            
            if (lBoxSelectNumber.SelectedIndex >= 0)
            {
                lBoxSelectNumber.Items.RemoveAt(lBoxSelectNumber.SelectedIndex);
                
            }
            else
            {
                
            }

        }
        
        /// <summary>
        /// 棋盤按鈕產生器
        /// </summary>
        /// <param name="row"> 列
        /// <param name="column"> 行
        /// <param name="total"> 按鈕總數
        /// <param name="btnWidth"> 按鈕寬度
        /// <param name="btnHeight"> 按鈕高度
        /// <returns>
        /// 回傳一個裝滿button的Panel
        /// </returns>
        public Panel DynamicGenerationButton1(int row, int column, int total, int btnWidth, int btnHeight, int x, int y)
        {
            Panel panel = new Panel();
            panel.Size = new Size(500 + (column * btnWidth), 500 + (row * btnHeight));


            int count = 0;
            for (int i = 0; i < row; i += 1)
            {
                for (int j = 0; j < column; j += 1)
                {
                    count += 1;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Gainsboro;
                    dButton.Size = new Size(btnWidth, btnHeight);
                    dButton.Location = new Point(x + (dButton.Width * j), y + (dButton.Height * i));
                    dButton.Text = "" + count;
                    dButton.Name = "btn" + count;
                    dButton.Font = new Font("微軟正黑體", 9, FontStyle.Bold);
                    dButton.Click += new EventHandler(Bt_LotteryNumber1_Click); // += 事件指定運算子

                    buttonBox1.Add(dButton);
                    panelSelectionNumber1.Controls.Add(dButton);
                    if (panel.Controls.Count == total)
                        return panel;
                }
            }

            return panel;

        }

        /// <summary>
        /// 棋盤按鈕產生器
        /// </summary>
        /// <param name="row"> 列
        /// <param name="column"> 行
        /// <param name="total"> 按鈕總數
        /// <param name="btnWidth"> 按鈕寬度
        /// <param name="btnHeight"> 按鈕高度
        /// <returns>
        /// 回傳一個裝滿button的Panel
        /// </returns>
        public Panel DynamicGenerationButton2(int row, int column, int total, int btnWidth, int btnHeight, int x, int y)
        {
            Panel panel = new Panel();
            panel.Size = new Size(500 + (column * btnWidth), 500 + (row * btnHeight));


            int count = 0;
            for (int i = 0; i < row; i += 1)
            {
                for (int j = 0; j < column; j += 1)
                {
                    count += 1;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Gainsboro;
                    dButton.Size = new Size(btnWidth, btnHeight);
                    dButton.Location = new Point(x + (dButton.Width * j), y + (dButton.Height * i));
                    dButton.Text = "" + count;
                    dButton.Name = "btn" + count;
                    dButton.Font = new Font("微軟正黑體", 9, FontStyle.Bold);
                    dButton.Click += new EventHandler(Bt_LotteryNumber2_Click); // += 事件指定運算子

                    buttonBox2.Add(dButton);
                    panelSelectionNumber2.Controls.Add(dButton);
                    if (panel.Controls.Count == total)
                        return panel;
                }
            }

            return panel;

        }

        //在listbox,新增按鈕按的數字
        private void BtnAddNewProject_Click(object sender, EventArgs e)
        {
            if (lBoxSelectNumber.ToString() != "")
            {

                
                lBoxSelectNumber.Items.Add(prompt);



            }
            else
            {

            }
        }

        private void lBoxSelectNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
