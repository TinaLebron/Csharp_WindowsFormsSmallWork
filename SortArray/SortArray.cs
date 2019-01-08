using SortArray.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortArray
{
    public partial class Form1 : Form
    {

        //class類別變數
        string[] arraySubject;//科目名稱
        string[] arrayStudentName;//學生姓名
        int[] arrayStudentScore; //學生成績
        int[] arrayStudentHeight;//身高
        string[] arrayTempSubject;//科目暫存
        string[] arrayTempStudentName; //學生姓名暫存
        int[] arrayTempStudentScore; //學生成績暫存
        int[] arrayTempStudentHeight;//身高暫存


        public Form1()
        {
            InitializeComponent();
            ReadData();
        }

        //---------------------------------API--------------------------------------
        public void ReadData()
        {
            arraySubject = new string[7];
            arraySubject[0] = "國文";
            arraySubject[1] = "英文";
            arraySubject[2] = "數學";
            arraySubject[3] = "物理";
            arraySubject[4] = "化學";
            arraySubject[5] = "自然";
            arraySubject[6] = "社會";

            arrayStudentName = new string[5];//學生姓名 key
            arrayStudentName[0] = "王小明";
            arrayStudentName[1] = "陳大貓";
            arrayStudentName[2] = "林阿長";
            arrayStudentName[3] = "張大書";
            arrayStudentName[4] = "黃中春";

            arrayStudentScore = new int[5];//學生成績 value
            arrayStudentScore[0] = 76;
            arrayStudentScore[1] = 68;
            arrayStudentScore[2] = 54;
            arrayStudentScore[3] = 92;
            arrayStudentScore[4] = 86;

            arrayStudentHeight = new int[5];//身高 value
            arrayStudentHeight[0] = 175;
            arrayStudentHeight[1] = 166;
            arrayStudentHeight[2] = 180;
            arrayStudentHeight[3] = 171;
            arrayStudentHeight[4] = 155;

            arrayTempSubject = new string[7];
            arrayTempStudentName = new string[5];
            arrayTempStudentScore = new int[5];
            arrayTempStudentHeight = new int[5];

            lblSumOfResults.Text = TotalScore(arrayStudentScore).ToString();
            lblAverageScore.Text = string.Format("{0:F}", Avarage(arrayStudentScore));
            //jz
            /* int[] grades = new int[5];
             grades[0] = 10;
             grades[1] = 20;
             grades[2] = 30;
             grades[3] = 40;
             grades[4] = 50;

             for (int i = 0; i < grades.Length; i++)
             {
                 Console.WriteLine("排序前 : " + grades[i]);
             }


             for (int i = grades.Length - 1; i >= 0; i--)
             {
                 Console.WriteLine("排序後 : " + grades[i]);
             }
             */
        }
        
        void SubjectSorting(string[] myArraySubject)
        {
            string strMsg = "";
            for (int index = 0; index <= myArraySubject.GetUpperBound(0); index += 1)
            {
                strMsg += string.Format("{0}\n", myArraySubject[index]);

            }
            lblBeforeSorting.Text = strMsg;
            System.Array.Sort(myArraySubject);//預設:特殊符號 數字(0~) 英文字母(a~) 中文(筆畫)

            strMsg = "";

            foreach (string strSub in myArraySubject)
            {
                strMsg += string.Format("{0}\n", strSub);
            }
            lblAfterSorting.Text = strMsg;

        }

        public void SortByName(string[] myArrayName, int[] myArrayScore)
        {
            string strMsg = "";

            for (int index = 0; index <= myArrayName.GetUpperBound(0); index += 1)
            {

                strMsg += string.Format("{0} : {1}\n", myArrayName[index], myArrayScore[index]);

            }

            lblBeforeSorting.Text = strMsg;

            System.Array.Sort(myArrayName, myArrayScore);

            strMsg = "";

            for (int index = 0; index <= myArrayName.GetUpperBound(0); index += 1)
            {

                strMsg += string.Format("{0} : {1}\n", myArrayName[index], myArrayScore[index]);

            }

            lblAfterSorting.Text = strMsg;


        }
        public void NumberHighestToLowest(string[] myArrayName, int[] myArrayNumber)
        {
            string strMsg = "";

            for (int index = 0; index <= myArrayName.GetUpperBound(0); index += 1)
            {

                strMsg += string.Format("{0} : {1}\n", myArrayName[index], myArrayNumber[index]);

            }

            lblBeforeSorting.Text = strMsg;

            Array.Sort(myArrayNumber, myArrayName);

            strMsg = "";

            for (int index = myArrayName.GetUpperBound(0); index >= 0; index -= 1)
            {

                strMsg += string.Format("{0} : {1}\n", myArrayName[index], myArrayNumber[index]);

            }

            lblAfterSorting.Text = strMsg;

        }

        public void NumberHighestToLowest(int[] myArrayName, int[] myArrayNumber)
        {
            string strMsg = "";

            for (int index = 0; index <= myArrayName.GetUpperBound(0); index += 1)
            {

                strMsg += string.Format("{0} : {1}\n", myArrayName[index], myArrayNumber[index]);

            }

            lblBeforeSorting.Text = strMsg;

            Array.Sort(myArrayNumber, myArrayName);

            strMsg = "";

            for (int index = myArrayName.GetUpperBound(0); index >= 0; index -= 1)
            {

                strMsg += string.Format("{0} : {1}\n", myArrayName[index], myArrayNumber[index]);

            }

            lblAfterSorting.Text = strMsg;

        }

        public int TotalScore(int[] myScoreArray)
        {
            int intTotal = 0;
            foreach (int myScore in myScoreArray)
            {
                intTotal += myScore;
            }

            return intTotal;
        }

        public float Avarage(int[] myScoreArray)
        {
            float myAverage = 0.0f;

            myAverage = (float)TotalScore(myScoreArray) / myScoreArray.GetLength(0);//注意會有引含轉換風險


            return myAverage;
        }
        
        //---------------------------事件 event-----------------------------------------
        private void Btn_SortBySubject_Click(object sender, EventArgs e)
        {
            Array.Copy(arraySubject,arrayTempSubject,arraySubject.GetLength(0));
            SubjectSorting(arrayTempSubject);
        }
        
        private void Btn_SortByName_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName,arrayTempStudentName,arrayStudentName.GetLength(0));
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.GetLength(0));

            SortByName(arrayTempStudentName, arrayTempStudentScore);
        }
        
        private void Btn_SortByGrades_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.GetLength(0));
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.GetLength(0));

            NumberHighestToLowest(arrayTempStudentName, arrayTempStudentScore);
            //SortByGrades
        }
        
        private void Btn_NameSearch_Click(object sender, EventArgs e)
        {
            if (tbNameInput.Text.Length > 0)
            {
                int index = 0, num1 = 0;
                string strMsg = "搜尋結果\n" + "----------\n";
                string strSearch = tbNameInput.Text;

                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.GetLength(0));
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.GetLength(0));
                Array.Copy(arrayStudentHeight, arrayTempStudentHeight, arrayStudentHeight.GetLength(0));

                NumberHighestToLowest(arrayTempStudentName, arrayTempStudentScore);
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.GetLength(0));
                NumberHighestToLowest(arrayTempStudentHeight, arrayTempStudentScore);

                index = Array.IndexOf(arrayTempStudentName,strSearch);

                if (index <= -1)
                {
                    lblBeforeSorting.Text = "";
                    //找不到
                    strMsg += "查無此人";
                }
                else
                {
                    lblBeforeSorting.Text = "";
                    num1 = arrayTempStudentName.GetLength(0) - index; //名次

                    strMsg += string.Format("\n{0} : {1} 分\n第{2}名\n{3} 公分", arrayTempStudentName[index], arrayTempStudentScore[index], num1, arrayTempStudentHeight[index]);
                }
                lblAfterSorting.Text = strMsg;
                tbNameInput.Text = "";
            }
            else
            {
                lblBeforeSorting.Text = "";
                lblAfterSorting.Text = "請輸入搜尋姓名";
            }
        }

        private void Btn_SortByHeight_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.GetLength(0));
            Array.Copy(arrayStudentHeight, arrayTempStudentHeight, arrayStudentHeight.GetLength(0));

            NumberHighestToLowest(arrayTempStudentName, arrayTempStudentHeight);
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
