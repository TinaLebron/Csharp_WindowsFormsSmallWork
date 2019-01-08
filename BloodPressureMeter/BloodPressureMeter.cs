
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodPressureMeter
{
    public partial class BloodPressureMeter : Form
    {

        
        int SBPAverage;
        int PRAverage;
        bool isContinue = true;

        public object Integer { get; private set; }

        public BloodPressureMeter()
        {
            InitializeComponent();


        }

        private void BloodPressureMeter_Load(object sender, EventArgs e)
        {

        }

        private void BtnSendOut_Click_1(object sender, EventArgs e)
        {
            
            isContinue = CheckOverRange(TbSystolicBloodPressure_1.Text, TbSystolicBloodPressure_2.Text, isContinue);

            if (isContinue == true)
            {

                isContinue = CheckOverRange(TbPressureRelief_1.Text, TbPressureRelief_2.Text, isContinue);
                
                if (isContinue == true)
                {
                    SBPAverage = average(TbSystolicBloodPressure_1.Text, TbSystolicBloodPressure_2.Text, 2);
                    PRAverage = average(TbPressureRelief_1.Text, TbPressureRelief_2.Text, 2);
                    BloodPressureSort(SBPAverage.ToString(), PRAverage.ToString());

                }
                
            }
            TbPressureRelief_1.Text = "";
            TbPressureRelief_2.Text = "";
            TbSystolicBloodPressure_1.Text = "";
            TbSystolicBloodPressure_2.Text = "";
            isContinue = true;
            
            
            
            
        }


        public bool CheckOverRange(string BloodPressure_1, string BloodPressure_2,bool isContinue)
        {

            if (BloodPressure_1 == "" || BloodPressure_2 == "")
            {
                MessageBox.Show("輸入有空白,請重新輸入");
                isContinue = false;
            }
            else
            {
                try
                {
                    if ((Int32.Parse(BloodPressure_1) - Int32.Parse(BloodPressure_2)) > 5)
                    {
                        MessageBox.Show("前兩次的數值差異大於5 (毫米汞柱) ,請從新在測量");
                        
                        isContinue = false;
                    }
                }
                catch
                {
                    MessageBox.Show("此輸入有誤,請確認是否輸入數字以外的按鍵");
                    
                    isContinue = false;

                }
               
            }
            

            return isContinue; 

        }

        int average(string BloodPressure_1, string BloodPressure_2, int count)
        {
            int average = (Int32.Parse(BloodPressure_1) + Int32.Parse(BloodPressure_2)) / count;
            return average;
        }

        public void BloodPressureSort(string SystolicBloodPressure,string PressureRelief)
        {
            bool ifSBP = false;
            bool ifPR = false;
            
            int intSBP = 0;
            int intPR = 0;
            string strMeg = "";

            ifSBP = Int32.TryParse(SystolicBloodPressure, out intSBP);
            ifPR = Int32.TryParse(PressureRelief, out intPR);

            if (ifSBP == true && ifPR == true)
            {

                if (180 <= intSBP || 110 <= intPR)
                {
                    strMeg = "高血壓,第三期";
                   
                }
                else if (160 <= intSBP || 100 <= intPR)
                {
                    strMeg = "高血壓,第二期";
                }
                else if (140 <= intSBP || 90 <= intPR)
                {
                    strMeg = "高血壓,第一期";
                }
                else if (130 <= intSBP || 85 <= intPR)
                {
                    strMeg = "正常血壓但偏高";
                }
                
                else if (120 <= intSBP || 80 <= intPR)
                {
                    strMeg = "正常血壓";
                }
                else if (90 <= intSBP || 60 <= intPR)
                {
                    strMeg = "理想血壓";
                }
                else if (intSBP < 90 || 60 < intPR)
                {
                    strMeg = "低血壓";
                        
                }
                strMeg = "您輸入的收縮壓為:" + intSBP + "毫米汞柱\n" + "您輸入的舒張壓為:" + intPR + "毫米汞柱\n" + "高血壓分析建議與結果為:" + strMeg;
                if ((intSBP > 0) && (intPR > 0))
                {
                    MessageBox.Show(strMeg);
                }
                else
                {
                    MessageBox.Show("請輸入正確的收縮壓及舒張壓");
                }
                
                strMeg = "";

            }
            else
            {
                MessageBox.Show("此輸入有誤,請確認是否輸入數字以外的按鍵");
            }
            
        }

       
    }
}
