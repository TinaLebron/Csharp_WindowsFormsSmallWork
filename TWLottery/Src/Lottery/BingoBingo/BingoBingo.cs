using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TWLottery.Properties;
using TWLottery.Src.Database;
using TWLottery.Src.Lottery.BingoBingo.Enums;

namespace TWLottery.Src.Lottery.BingoBingo
{
    public partial class BingoBingo : Form
    {

        List<int> winNumber_BingoBingo;
        List<int> winNumber_GuessSize;
        List<int> winNumber_GuessDoubleSingle;
        int lotteryID = 1;

        int star = 3;
        int size = 2;
        int type = 3;

        //超級獎號旗標
        bool isSuperStar = false;
        //提示選擇幾個號碼
        string prompt;
        //是否清除清除本組投注資訊
        bool isClearBetInfo = false;
        //選了幾星
        int starIndex;
        //80顆按鈕
        List<Button> buttonBox = new List<Button>();
        //對照組按鈕
        List<Button> tempButtonBox = new List<Button>();
        //選擇幾星SelectedIndexChanged的星星數量
        int StarQuantity = 1;

        int buy = 25;
        double rate;

        string save;

        public BingoBingo()
        {
            InitializeComponent();


            DBHelper dbHelper = new DBHelper();

            int[] userNumber = new int[] { 2, 3, 9, 65, 33, 30, 57, 44, 32, 10 };
            int[] computerNumber = new int[] { 3, 25, 63, 33, 27, 11, 47, 61, 15, 7,
                                              42, 32, 66, 32, 48, 2, 14, 56, 38, 12};

            winNumber_BingoBingo = GetBingoHitCounts(star, userNumber, computerNumber);
            winNumber_GuessSize = Guessing(GuessType.Small, computerNumber);
            winNumber_GuessDoubleSingle = Guessing(GuessType.Tie, computerNumber);

            //測試
            NoUITest();


        }

        private void Bingo_Load(object sender, EventArgs e)
        {
            //UI初始化
            Init();
        }

        private void Init()
        {
            Panel panel = DynamicGenerationButton(5, 16, 80, 40, 40);
            if (panel != null)
                panelSelectNumberArea.Controls.Add(panel);

            //猜大小的倍數 cbBigSmallRate
            cbBigSmallRate.Items.AddRange(new List<string> { "x1", "x2", "x3", "x4", "x5", "x6", "x8", "x10", "x12", "x20", "x50" }.ToArray());
            cbBigSmallRate.DropDownStyle = ComboBoxStyle.DropDownList; //讓combox不能打字
            cbBigSmallRate.SelectedIndex = 0; //預設顯示第一個

            //猜單雙的倍數 
            cbSingleDoubleRate.Items.AddRange(new List<string> { "x1", "x2", "x3", "x4", "x5", "x6", "x8", "x10", "x12", "x20", "x50" }.ToArray());
            cbSingleDoubleRate.DropDownStyle = ComboBoxStyle.DropDownList; //讓combox不能打字
            cbSingleDoubleRate.SelectedIndex = 0; //預設顯示第一個

            //星星數
            cbStarQuantity.Items.AddRange(new List<string> { "1星", "2星", "3星", "4星", "5星", "6星", "7星", "8星", "9星", "10星" }.ToArray());
            cbStarQuantity.DropDownStyle = ComboBoxStyle.DropDownList; //讓combox不能打字
            cbStarQuantity.SelectedIndex = 0; //預設顯示第一個

            //星星倍數
            cbStarRate.Items.AddRange(new List<string> { "x1", "x2", "x3", "x4", "x5", "x6", "x8", "x10", "x12", "x20", "x50" }.ToArray());
            cbStarRate.DropDownStyle = ComboBoxStyle.DropDownList; //讓combox不能打字
            cbStarRate.SelectedIndex = 0; //預設顯示第一個
        }

        public List<int> GetBingoHitCounts(int star, int[] userNumber, int[] computerNumber)
        {
            List<int> winNumber = new List<int>();
            for (int i = 0; i < star; i++)
            {
                if (Array.IndexOf(computerNumber, userNumber[i]) >= 0)
                {
                    winNumber.Add(userNumber[i]);
                }
                winNumber.Sort();
            }
            return winNumber;
        }

        public List<int> Guessing(GuessType type, int[] computerNumber)
        {
            List<int> winNumber = new List<int>();

            switch (type)
            {
                case GuessType.Big:
                    for (int i = 0; i < computerNumber.Length; i++)
                    {
                        if (computerNumber[i] > 40 && computerNumber[i] < 81)
                        {
                            winNumber.Add(computerNumber[i]);
                        }
                    }
                    break;
                case GuessType.Small:
                    for (int i = 0; i < computerNumber.Length; i++)
                    {
                        if (computerNumber[i] < 41 && computerNumber[i] > 0)
                        {
                            winNumber.Add(computerNumber[i]);
                        }
                    }
                    break;
                case GuessType.Single:
                    for (int i = 0; i < computerNumber.Length; i++)
                    {
                        if (!(computerNumber[i] % 2 == 0))
                        {
                            winNumber.Add(computerNumber[i]);
                        }
                    }
                    break;
                case GuessType.Double:
                    for (int i = 0; i < computerNumber.Length; i++)
                    {
                        if (computerNumber[i] % 2 == 0)
                        {
                            winNumber.Add(computerNumber[i]);
                        }
                    }
                    break;

                case GuessType.Tie:
                    //猜和尚未寫
                    break;
                default:
                    break;
            }
            return winNumber;
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
        public Panel DynamicGenerationButton(int row, int column, int total, int btnWidth, int btnHeight)
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
                    dButton.Location = new Point(21 + (dButton.Width * j), 256 + (dButton.Height * i));
                    dButton.Text = "" + count;
                    dButton.Name = "btn" + count;
                    dButton.Font = new Font("微軟正黑體", 9, FontStyle.Bold);
                    dButton.Click += new EventHandler(Bt_LotteryNumber_Click); // += 事件指定運算子

                    buttonBox.Add(dButton);
                    panel.Controls.Add(dButton);
                    if (panel.Controls.Count == total)
                        return panel;
                }
            }
            return panel;
        }

        //80顆按鈕Click
        public void Bt_LotteryNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //改變按鈕顏色
            save += btn.Text + "  ";
            string[] item = cbStarQuantity.SelectedItem.ToString().Split('星');
            int star = Int32.Parse(item[0]);

            //改變按鈕顏色
            ChangeBtnBackground(btn);

            if (tempButtonBox == null)
                tempButtonBox = new List<Button>();

            if (buttonBox == null)
                buttonBox = new List<Button>();

            //若按的按鈕是同一顆，從對照組中移除
            if (tempButtonBox.Contains(btn))
            {
                tempButtonBox.Remove(btn);
                //每一顆按鈕都恢復可以按
                if (tempButtonBox.Count == star - 1)
                {
                    foreach (Button b in buttonBox)
                    {
                        b.Enabled = true;
                    }
                }
                return;
            }
            else
            {
                //若對照組沒有此按鈕則加入
                if (tempButtonBox.Count < star)
                    tempButtonBox.Add(btn);
                //若已達上限
                if (tempButtonBox.Count == star)
                {
                    //除對照組以外，所有按鈕都不能按
                    foreach (Button b in buttonBox)
                    {
                        if (tempButtonBox.Contains(b))
                            b.Enabled = true;
                        else
                            b.Enabled = false;
                    }
                }
            }

        }

        //改變按鈕顏色
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

        //秀出樂透網站 ">>" 的按鈕的事件
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

        //關閉樂透網站 "X" 按鈕的事件
        private void Btn_CloseLotteryWebsite_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            webBrowser1.Visible = false;
            button2.Visible = false;
        }

        private void CbBigSmallRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string[] item = comboBox.SelectedItem.ToString().Split('x');//'x1'去除x
            int rate = Int32.Parse(item[1]); //'x1'抓取數字
            Console.WriteLine("rate " + rate);
        }

        public void CbSingleDoubleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string[] item = comboBox.SelectedItem.ToString().Split('x');//'x1'去除x
            int rate = Int32.Parse(item[1]); //'1星'抓取數字
            Console.WriteLine("rate " + rate);
        }
        
        //選擇幾星SelectedIndexChanged
        public void CbStarQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (isClearBetInfo)
            {
                string[] item = comboBox.SelectedItem.ToString().Split('星');//去除星
                StarQuantity = Int32.Parse(item[0]);//抓取星星

                //改變 Label-選擇?個號碼上的字
                prompt = "*選擇" + StarQuantity + "個號碼";
                lblChoicedPrompt.Text = prompt;
            }
            else
            {
                //還原之前選的，並恢復期標
                this.cbStarQuantity.SelectedIndex = starIndex;
                isClearBetInfo = true;
            }

            Console.WriteLine("SelectedIndexChanged");
        }
        //選擇幾星下拉時的event
        private void CbStarQuantity_DropDown(object sender, System.EventArgs e)
        {
            Console.WriteLine("DropDown");
            ComboBox comboBox = (ComboBox)sender;
            starIndex = comboBox.SelectedIndex;
        }

        public void CbStarRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string[] item = comboBox.SelectedItem.ToString().Split('x');//'x1'去除x
            int rate = Int32.Parse(item[1]);//'x1'抓取數字
            Console.WriteLine("rate " + rate);
        }
        //快選按鈕事件
        private void BtnAutoPickNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor.Equals(Color.Gainsboro))
            {
                isSuperStar = false;
                btn.BackColor = Color.Red;
                //改變 Label-選擇?個號碼上的字
                lblChoicedPrompt.Text = "*部分號碼或全部號碼由投注機隨機產生";
            }
            else
            {
                isSuperStar = true;
                btn.BackColor = Color.Gainsboro;
                prompt = "*選擇" + StarQuantity + "個號碼"; ;
                lblChoicedPrompt.Text = prompt;
            }
        }
        //SelectionChangeCommitted
        private void CbStarQuantity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Console.WriteLine("SelectionChangeCommitted");
            if (IsChoicedNumber())
            {
                DialogResult dialogResult = MessageBox.Show("即將清除本組投注資訊，是否繼續 ?", "台灣彩券", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isClearBetInfo = true;

                    //所有按鈕恢復原樣
                    foreach (Button b in buttonBox)
                    {
                        b.Enabled = true;
                        b.BackColor = Color.Gainsboro;
                    }
                    tempButtonBox.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    isClearBetInfo = false;//是清除投注信息

                }
            }

        }
        //判斷使用者是否有選擇號碼
        private bool IsChoicedNumber()
        {
            bool result = false;
            if (tempButtonBox.Count > 0)
                result = true;
            else
                result = false;
            return result;
        }

        private void NoUITest()
        {
            //BingoBingo
            Console.WriteLine("我的\n彩卷編號: {0}\n星數: {1}\n投注金額: {2}\n中球數: {3}\n中球號碼: {4}\n是否有超級獎號: {5}\n倍率{6}\n中獎金額: {7}\n售票時間: {8}"
                , lotteryID
                , star
                , buy
                , winNumber_BingoBingo.Count
                , string.Join(",", winNumber_BingoBingo)
                , isSuperStar == false ? "無" : "有"
                , isSuperStar == false ? rate = 2 : rate = 6
                , buy * rate
                , DateTime.Now);

            //猜大小
            Console.WriteLine("我的\n彩卷編號: {0}\n中獎方式: {1}\n投注金額: {2}\n中球號碼: {3}\n中球數量: {4}\n倍率{5}\n中獎金額: {6}\n售票時間: {7}"
                , lotteryID
                , GuessType.Small
                , buy
                , string.Join(",", winNumber_GuessSize)
                , winNumber_GuessSize.Count
                , rate = 6
                , buy * rate
                , DateTime.Now);

            //猜雙單
            Console.WriteLine("我的\n彩卷編號: {0}\n中獎方式: {1}\n投注金額: {2}\n中球號碼: {3}\n中球數量: {4}\n倍率{5}\n中獎金額: {6}\n售票時間: {7}"
                , lotteryID
                , GuessType.Tie
                , buy
                , ""
                , ""
                , rate
                , buy * rate
                , DateTime.Now);
        }

        private void BtnSuperNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor.Equals(Color.Gainsboro))
            {
                isSuperStar = false;
                btn.BackColor = Color.Red;

            }
            else
            {
                isSuperStar = true;
                btn.BackColor = Color.Gainsboro;

            }
        }
        
        private void LoadImageFromResorces(Panel panel)
        {
            for (int i = 0; i < 5; i++)
            {
                Image image = (Image)Resources.ResourceManager.GetObject("bg_circle");

                Label label = new Label();
                label.Text = (i + 1).ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(40, 40, 40);
                label.Width = 44;
                label.Height = 44;
                label.BackgroundImage = image;
                label.BackgroundImageLayout = ImageLayout.Stretch;
                label.Margin = new Padding(3);//label的間距
                panel.Controls.Add(label);
            }
        }


        
        private void BtnPrize_Click(object sender, EventArgs e)
        {
            //LoadImageFromResorces(prizeNumber);
            //LoadImageFromResorces(prizeNumberSort);

            List<int> myArray = new List<int>();
            myArray = RandomNumber();
            RandomNumberSort(myArray);




        }

        private List<int> RandomNumber()
        {
            lblprizeNumber.Text = "";
            List<int> myArray = new List<int>();
            int number;
            System.Random num = new Random();

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    number = num.Next(1, 81);
                }
                while (myArray.IndexOf(number) != -1);
                myArray.Add(number);

            }

            foreach (int prizeNumber in myArray)
            {
                lblprizeNumber.Text += prizeNumber + ",";
            }

            lblprizeNumber.Text = lblprizeNumber.Text.TrimEnd(',');
            

            return myArray;
        }

        private void RandomNumberSort(List<int> myArray)
        {
            lblprizeNumberSort.Text = "";

            myArray.Sort();

            foreach (int prizeNumber in myArray)
            {
                lblprizeNumberSort.Text += prizeNumber + ",";
            }

            lblprizeNumberSort.Text = lblprizeNumberSort.Text.TrimEnd(',');
            
            
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

        private void BtnAddNewProject_Click(object sender, EventArgs e)
        {
            if (lBoxSelectNumber.ToString() != "")
            {


                lBoxSelectNumber.Items.Add(save);



            }
            else
            {

            }
        }

    }

}
