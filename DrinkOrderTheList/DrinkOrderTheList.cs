using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        //類別變數,class variables
        //int[] cupNumber = new int[5];
        //double[] price = new double[5];
        //double[] totalprice_Item = new double[5];
        int cupNumber1 = 0, cupNumber2 = 0, cupNumber3 = 0, cupNumber4 = 0, cupNumber5 = 0;
        double price1 = 0.0, price2 = 0.0, price3 = 0.0, price4 = 0.0, price5 = 0.0;
        double totalprice_Item1 = 0.0, totalprice_Item2 = 0.0, totalprice_Item3 = 0.0, totalprice_Item4 = 0.0, totalprice_Item5 = 0.0;
        double foldNumber = 0.0;
        double total = 0.0;
        double afterDiscountTotal = 0.0;
        double dicountTotalPirce;
        bool isContinue = true;

        List<double> orderPrice = new List<double>(); 

        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        //---------------------------------API--------------------------------------
        public void ReadData()
        {
            lblProductName1.Text = "麥香紅茶";
            lblProductName2.Text = "茉莉綠茶";
            lblProductName3.Text = "珍珠奶茶";
            lblProductName4.Text = "玫瑰花茶";
            lblProductName5.Text = "現打西瓜汁";

            price1 = 35.0;
            price2 = 40.0;
            price3 = 45.0;
            price4 = 50.0;
            price5 = 55.0;

            lblPrice1.Text = price1.ToString();
            lblPrice2.Text = price2.ToString();
            lblPrice3.Text = price3.ToString();
            lblPrice4.Text = price4.ToString();
            lblPrice5.Text = price5.ToString();

            foldNumber = 10.0;
        }

        public void CalculateTotalPrice()
        {
            totalprice_Item1 = price1 * cupNumber1;
            totalprice_Item2 = price2 * cupNumber2;
            totalprice_Item3 = price3 * cupNumber3;
            totalprice_Item4 = price4 * cupNumber4;
            totalprice_Item5 = price5 * cupNumber5;

            total = totalprice_Item1 + totalprice_Item2 + totalprice_Item3 + totalprice_Item4 + totalprice_Item5;
            afterDiscountTotal = total * foldNumber / 10.0;

            lblTotalOrderPrice.Text = string.Format("{0:C}", total);
            lblTotalPriceAfterOrderDiscount.Text = string.Format("{0:C}", afterDiscountTotal);
        }

        public void CupNumber_Subtract()
        {
            cupNumber1 -= 1;
            if (cupNumber1 < 0)
            {
                cupNumber1 = 0;
                btnCupNumber1_Subtract.Enabled = false;
            }
            tbcupNumber1.Text = cupNumber1.ToString();
        }

        public double DicountTotalPirce(string tbCupNumber, int cupNumber, string lblPrice)
        {
            int discountCount = 0;//有打折數量
            int noDiscountCount = 0;//沒打折數量
            double dicountTotalPirce = 0;//折扣後總價
            bool ifNum = System.Int32.TryParse(tbCupNumber, out cupNumber);

            if ((ifNum == true) && (cupNumber / 2 >= 0))
            {
                discountCount = (cupNumber / 2);
                noDiscountCount = cupNumber - (cupNumber / 2);

                dicountTotalPirce = (double.Parse(lblPrice) * discountCount * 0.6) + (double.Parse(lblPrice) * noDiscountCount);

            }
            return dicountTotalPirce;
        }

        public string OrderContent()
        {
            string strOrder = "";
            DialogResult DrResult;
            DrResult = MessageBox.Show("您確認送出訂購單?", "訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            

            if (DrResult == DialogResult.No)
            {
                //取消送出
                isContinue = false;
            }
            else
            {
                //確認訂單
                strOrder = "**** III冷飲店訂購單 ****\n";
                strOrder += "------------------------\n";
                if (cupNumber1 > 0)
                {
                    strOrder += lblProductName1.Text + ":" + lblPrice1.Text + "x" + tbcupNumber1.Text + "=" + totalprice_Item1.ToString() + "\n";

                }
                if (cupNumber2 > 0)
                {
                    strOrder += lblProductName2.Text + ":" + lblPrice2.Text + "x" + tbCupNumber2.Text + "=" + totalprice_Item2.ToString() + "\n";

                }
                if (cupNumber3 > 0)
                {
                    strOrder += lblProductName3.Text + ":" + lblPrice3.Text + "x" + tbCupNumber3.Text + "=" + totalprice_Item3.ToString() + "\n";

                }
                if (cupNumber4 > 0)
                {
                    strOrder += lblProductName4.Text + ":" + lblPrice4.Text + "x" + tbCupNumber4.Text + "=" + totalprice_Item4.ToString() + "\n";

                }
                if (cupNumber5 > 0)
                {
                    strOrder += lblProductName5.Text + ":" + lblPrice5.Text + "x" + tbCupNumber5.Text + "=" + totalprice_Item5.ToString() + "\n";

                }

                strOrder += "----------------------------\n";
                isContinue = true;
            }
            return strOrder;
        }

        public void SaveIn_price(int cupNumber, double price)
        {
            for (int i = 0; i < cupNumber; i++)
            {
                orderPrice.Add(price);
            }
        }

        //--------------------------------事件 event---------------------------------
        private void Btn_CupNumber1_Subtract_Click(object sender, EventArgs e)
        {
            cupNumber1 -= 1;

            if (cupNumber1 < 0)
            {
                cupNumber1 = 0;
                btnCupNumber1_Subtract.Enabled = false;
            }
            
            tbcupNumber1.Text = cupNumber1.ToString();
        }

        private void Btn_CupNumber1_Add_Click(object sender, EventArgs e)
        {
            cupNumber1 += 1;
            btnCupNumber1_Subtract.Enabled = true;
            tbcupNumber1.Text = cupNumber1.ToString();
        }

        private void Tb_CupNumber1_TextChanged(object sender, EventArgs e)
        {
            if (tbcupNumber1.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbcupNumber1.Text, out cupNumber1);

                if ((ifNum == true) && (cupNumber1 >= 0))
                {
                    //輸入正確
                    btnCupNumber1_Subtract.Enabled = true;
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cupNumber1 = 0;
                    tbcupNumber1.Text = "0";
                }
            }
            else
            {
                cupNumber1 = 0;
            }
            CalculateTotalPrice();
        }

        private void Btn_CupNumber2_Subtract_Click(object sender, EventArgs e)
        {
            cupNumber2 -= 1;

            if (cupNumber2 < 0)
            {
                cupNumber2 = 0;
                btnCupNumber2_Subtract.Enabled = false;
            }

            tbCupNumber2.Text = cupNumber2.ToString();
        }

        private void Btn_Btn_CupNumber2_Add_Click(object sender, EventArgs e)
        {
            cupNumber2 += 1;
            btnCupNumber2_Subtract.Enabled = true;
            tbCupNumber2.Text = cupNumber2.ToString();
        }

       

        private void Tb_CupNumber2_TextChanged(object sender, EventArgs e)
        {
            if (tbCupNumber2.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupNumber2.Text, out cupNumber2);

                if ((ifNum == true) && (cupNumber2 >= 0))
                {
                    //輸入正確
                    btnCupNumber2_Subtract.Enabled = true;
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cupNumber2 = 0;
                    tbCupNumber2.Text = "0";
                }
            }
            else
            {
                cupNumber2 = 0;
            }
            CalculateTotalPrice();
        }

        private void Btn_CupNumber3_Subtract_Click(object sender, EventArgs e)
        {
            cupNumber3 -= 1;

            if (cupNumber3 < 0)
            {
                cupNumber3 = 0;
                btnCupNumber3_Subtract.Enabled = false;
            }

            tbCupNumber3.Text = cupNumber3.ToString();
        }

        private void Btn_CupNumber3_Add_Click(object sender, EventArgs e)
        {
            cupNumber3 += 1;
            btnCupNumber3_Subtract.Enabled = true;
            tbCupNumber3.Text = cupNumber3.ToString();
        }

        private void Tb_CupNumber3_TextChanged(object sender, EventArgs e)
        {
            if (tbCupNumber3.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupNumber3.Text, out cupNumber3);

                if ((ifNum == true) && (cupNumber3 >= 0))
                {
                    //輸入正確
                    btnCupNumber3_Subtract.Enabled = true;
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cupNumber3 = 0;
                    tbCupNumber3.Text = "0";
                }
            }
            else
            {
                cupNumber3 = 0;
            }
            CalculateTotalPrice();
        }

        private void Btn_CupNumber4_Subtract_Click(object sender, EventArgs e)
        {
            cupNumber4 -= 1;

            if (cupNumber4< 0)
            {
                cupNumber4 = 0;
                btnCupNumber4_Subtract.Enabled = false;
            }

            tbCupNumber4.Text = cupNumber4.ToString();
        }

        private void Btn_CupNumber4_Add_Click(object sender, EventArgs e)
        {
            cupNumber4 += 1;
            btnCupNumber4_Subtract.Enabled = true;
            tbCupNumber4.Text = cupNumber4.ToString();
        }

        private void Tb_CupNumber4_TextChanged(object sender, EventArgs e)
        {
            if (tbCupNumber4.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupNumber4.Text, out cupNumber4);

                if ((ifNum == true) && (cupNumber4 >= 0))
                {
                    //輸入正確
                    btnCupNumber4_Subtract.Enabled = true;
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cupNumber4 = 0;
                    tbCupNumber4.Text = "0";
                }
            }
            else
            {
                cupNumber4 = 0;
            }
            CalculateTotalPrice();
        }

        private void Btn_CupNumber5_Subtract_Click(object sender, EventArgs e)
        {
            cupNumber5 -= 1;

            if (cupNumber5 < 0)
            {
                cupNumber5 = 0;
                btnCupNumber5_Subtract.Enabled = false;
            }

            tbCupNumber5.Text = cupNumber5.ToString();
        }

        private void Btn_CupNumber5_Add_Click(object sender, EventArgs e)
        {
            cupNumber5 += 1;
            btnCupNumber5_Subtract.Enabled = true;
            tbCupNumber5.Text = cupNumber5.ToString();
        }

        private void Tb_CupNumber5_TextChanged(object sender, EventArgs e)
        {
            if (tbCupNumber5.Text != "")
            {
                bool ifNum = System.Int32.TryParse(tbCupNumber5.Text, out cupNumber5);

                if ((ifNum == true) && (cupNumber5 >= 0))
                {
                    //輸入正確
                    btnCupNumber5_Subtract.Enabled = true;
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cupNumber5 = 0;
                    tbCupNumber5.Text = "0";
                }
            }
            else
            {
                cupNumber5 = 0;
            }
            CalculateTotalPrice();
        }

        private void TbFoldNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbTbFoldNumber.Text != "")
            {
                bool ifNum = System.Double.TryParse(tbTbFoldNumber.Text, out foldNumber);
                if (ifNum == true)
                {
                    if ((foldNumber >= 0.0 ) && (foldNumber <= 10.0))
                    {
                        //合理折數
                    }
                    else
                    {
                        MessageBox.Show("折數輸入錯誤(0.0-10.0)");
                        tbTbFoldNumber.Text = "";
                        foldNumber = 10.0;
                    }
                }
                else
                {
                    MessageBox.Show("折數輸入錯誤(0.0-10.0)");
                    tbTbFoldNumber.Text = "";
                    foldNumber = 10.0;
                }
            }
            else
            {
                foldNumber = 10.0;
            }
            CalculateTotalPrice();
        }
        
        private void BtnPrintOrderForm_Click(object sender, EventArgs e)
        {
            string strOrder = OrderContent();
            if (isContinue) {
                if (foldNumber < 10.0)
                {
                    strOrder += "折數" + string.Format("{0:F2}", foldNumber) + "\n";

                }
                strOrder += "訂單總價" + string.Format("{0:C}", total) + "\n";
                strOrder += "折扣後總價" + string.Format("{0:C}", afterDiscountTotal) + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "訂單明細", MessageBoxButtons.OK);
            }
        }

        private void Btn_40PercentOffSameItem_Click(object sender, EventArgs e)
        {
            string strOrder = OrderContent();
            if (isContinue)
            {
                double price1_cupNumber = DicountTotalPirce(tbcupNumber1.Text, cupNumber1, lblPrice1.Text);
                double price2_cupNumber = DicountTotalPirce(tbCupNumber2.Text, cupNumber2, lblPrice2.Text);
                double price3_cupNumber = DicountTotalPirce(tbCupNumber3.Text, cupNumber3, lblPrice3.Text);
                double price4_cupNumber = DicountTotalPirce(tbCupNumber4.Text, cupNumber4, lblPrice4.Text);
                double price5_cupNumber = DicountTotalPirce(tbCupNumber5.Text, cupNumber5, lblPrice5.Text);

                dicountTotalPirce = price1_cupNumber + price2_cupNumber + price3_cupNumber + price4_cupNumber + price5_cupNumber;

                strOrder += "訂單總價" + string.Format("{0:C}", total) + "\n";
                strOrder += "第二件六折優惠價" + string.Format("{0:C}", dicountTotalPirce) + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "訂單明細", MessageBoxButtons.OK);
            }
        }
        
        private void Btn_BuyThreeGetOneDifferentItems_Click(object sender, EventArgs e)
        {
            string strOrder = OrderContent();
            if (isContinue)
            {
                orderPrice.Clear();

                SaveIn_price(cupNumber1, price1);
                SaveIn_price(cupNumber2, price2);
                SaveIn_price(cupNumber3, price3);
                SaveIn_price(cupNumber4, price4);
                SaveIn_price(cupNumber5, price5);


                int onSaleNumberOfItems = (cupNumber1 + cupNumber2 + cupNumber3 + cupNumber4 + cupNumber5) / 4;

                for (int i = onSaleNumberOfItems - 1; i >= 0; i--)
                {
                    orderPrice.RemoveAt(i);
                }

                dicountTotalPirce = orderPrice.Sum();

                strOrder += "單價總價" + string.Format("{0:C}", total) + "\n";
                strOrder += "不同品項買三送一優惠價格" + string.Format("{0:C}", dicountTotalPirce) + "\n";
                strOrder += string.Format("{0:D}", DateTime.Now) + "\n";
                strOrder += string.Format("{0:T}", DateTime.Now) + "\n";
                MessageBox.Show(strOrder, "訂單明細", MessageBoxButtons.OK);
            }
        }
        
        //------------------------------------lifecycle-------------------------------------------
        
        private void Control_HandleCreated(object sender, EventArgs e)
        {
            Console.WriteLine("Control_HandleCreated()");
        }

        private void Control_BindingContextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Control_BindingContextChanged()");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Control_Form1_Load()");
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
