using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class UnitConverter : Form
    {
        public UnitConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCmToInch_Click(object sender, EventArgs e)
        {
            float myCM = 0.0f;
            float myInch = 0.0f;
            float myFoot = 0.0f;

            if (tbCm.Text != "")
            {
                try
                {
                    //公分
                    myCM = Convert.ToSingle(tbCm.Text);
                    //英吋
                    myInch = myCM * 0.3937f;
                    //tb英吋.Text = Convert.ToString(myInch);
                    tbInch.Text = string.Format("{0:F2}", myInch);
                    //1呎 = 12吋
                    //5 1呎 7 11吋 = 67 11吋
                    //6 1呎 2 11吋 = 74 11吋

                    //呎
                    myFoot = Convert.ToInt32(Math.Floor(myInch)) / 12;
                    tbFeet.Text = myFoot.ToString(); 
                    //吋
                    myFoot = (Convert.ToInt32(myInch)) % 12;
                    tbFeetToInch.Text = myFoot.ToString();

                }
                catch (Exception error)
                {
                    //MessageBox.Show(Convert.ToString(error));
                    MessageBox.Show("Incorrect input format.");
                }

            }
            else
            {
                MessageBox.Show("Please enter the value of the cent.");
            }
        }

        private void btnFootageToSquareMeters_Click(object sender, EventArgs e)
        {
            double myFootag = 0.0;
            double mySquareMeter = 0.0;

            if (tbFootag.Text != "")
            {
                try
                {
                    myFootag = Convert.ToDouble(tbFootag.Text);
                    mySquareMeter = myFootag * 3.3058;
                    tbSquareMeters.Text = Convert.ToString(mySquareMeter);
                }
                catch (Exception error)
                {
                    //MessageBox.Show(Convert.ToString(error));
                    MessageBox.Show("Incorrect input format.");
                }
            }

            else
            {
                MessageBox.Show("Please enter the number of pings.");
            }
        }

        private void btnKgToPounds_Click(object sender, EventArgs e)
        {
            double myKg = 0.0;
            double myPound = 0.0;

            if (tbKg.Text != "")
            {
                try
                {
                    myKg = Convert.ToDouble(tbKg.Text);
                    myPound = myKg * 2.2;
                    tbPounds.Text = Convert.ToString(myPound);
                }
                catch (Exception error)
                {
                    //MessageBox.Show(Convert.ToString(error));
                    MessageBox.Show("Incorrect input format.");
                }

            }

            else
            {
                MessageBox.Show("Please enter the kilogram value.");
            }
        }
    }
}
