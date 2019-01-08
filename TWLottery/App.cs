using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TWLottery.Src.Lottery.BingoBingo;
using TWLottery.Src.Lottery.SuperLotto;

namespace TWLottery
{
    public partial class App : Form
    {

        public App()
        {
            InitializeComponent();
        }

        private void Btn_SuperLotto_Click(object sender, EventArgs e)
        {
            SuperLotto superLotto = new SuperLotto();
            superLotto.ShowDialog();

        }

        private void Btn_BinGo_Click(object sender, EventArgs e)
        {
            BingoBingo binGo = new BingoBingo();
            binGo.ShowDialog();
        }

        private void Lottery_Load(object sender, EventArgs e)
        {

        }
    }

}
