using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestr
{
    public partial class Form1 : Form
    {
        //Variables
        public int LvOneFarmValue { get; set; } = 50;
        public int LvOneAutoFarmValue { get; set; } = 5;
        public double LvOneFarmUpgradeCost { get; set; } = 10;
        public double LvOneAutoFarmUpgradeCost { get; set; } = 100;
        private int AutoFarmLevel { get; set; } = 0;
        private int LvOneFarmTTF {  get; set; } = 1000;
        private int SpeedIncrease { get; set; } = 0;
        private AutoFarm _autoFarm;
        

        public Form1()
        {
            InitializeComponent();
            UpgradeLvOneFarm.Text = "Lv2 Farm: " + LvOneFarmUpgradeCost + " Coins";
            LvOneFarmInfoText.Text = "+" + LvOneFarmValue + " Coins";
        }        
        private void MainClickButton(object sender, EventArgs e)
        {
            if (LvOneFarmProgrssBar.Value == LvOneFarmProgrssBar.Maximum - LvOneFarmProgrssBar.Step)
            {
            CollectCoins.BackColor = Color.DarkSeaGreen;
            }
            if (LvOneFarmProgrssBar.Value < 100)
            {
                LvOneFarmProgrssBar.Value = LvOneFarmProgrssBar.Value + LvOneFarmProgrssBar.Step;
            }
        }
        private void CollectCoins_Click(object sender, EventArgs e)
        {
            CollectCoins.BackColor = Color.Salmon;
            if (LvOneFarmProgrssBar.Value == 100) {
                LvOneFarmProgrssBar.Value = 0;
                CoinBalance.Text = (Convert.ToDecimal(CoinBalance.Text) + LvOneFarmValue).ToString();
            }else{
                MessageBox.Show("Farm is not ready yet!");
            }
        }
        private void UpgradeLvOneFarm_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(CoinBalance.Text) >= LvOneFarmUpgradeCost)
            {
                LvOneFarmValue += 5;
                CoinBalance.Text = (Convert.ToDecimal(CoinBalance.Text) - 10).ToString();
                LvOneFarmInfoText.Text = "+" + LvOneFarmValue + " Coins";
                LvOneFarmUpgradeCost = LvOneFarmUpgradeCost * 1.2;
                UpgradeLvOneFarm.Text = "Lv2 Farm: " + LvOneFarmUpgradeCost.ToString("F2") + " Coins";

            }else
            {
                MessageBox.Show("Not enough coins!");
            }
        }
        private void AutoFarmUpgrade_Click(object sender, EventArgs e)
        {
            if (AutoFarmLevel > 0)
            {

                if (Convert.ToDouble(CoinBalance.Text) >= LvOneAutoFarmUpgradeCost)
                {
                    CoinBalance.Text = (Convert.ToDouble(CoinBalance.Text) - LvOneAutoFarmUpgradeCost).ToString("F2");
                    LvOneAutoFarmUpgradeCost = LvOneAutoFarmUpgradeCost * 1.2;
                    SpeedIncrease = (int)(Convert.ToDouble(LvOneFarmTTF) * 0.1);
                    LvOneFarmTTF = LvOneFarmTTF - SpeedIncrease;
                    AutoFarmUpgrade.Text = $"Lv: {AutoFarmLevel+1} AutoFarm: " + LvOneAutoFarmUpgradeCost.ToString("F2") + " Coins";   
                    _autoFarm.Upgrade(LvOneFarmTTF);
                }
                else
                {
                    MessageBox.Show("Not enough coins!");
                }
            }
            //Buy Autofarm
            else if (Convert.ToDecimal(CoinBalance.Text) >= 100 && AutoFarmLevel == 0)
            {
                CoinBalance.Text = (Convert.ToInt32(CoinBalance.Text) - 100).ToString();
                AutoFarmProgrssBar.Value = 0;
                AutoFarmProgrssBar.Enabled = true;
                AutoFarmProgrssBar.MarqueeAnimationSpeed = 1000;
                AutoFarmProgrssBar.Maximum = 100;
                AutoFarmProgrssBar.Step = 10;
                //AutoFarmProgrssBar.PerformStep();
                _autoFarm = new AutoFarm(LvOneAutoFarmValue, LvOneFarmTTF, AutoFarmProgrssBar, CoinBalance, ShowAutoFarmIntervall);
                _autoFarm.Start();

                AutoFarmLevel++;
            }
            else
            {
                MessageBox.Show("Not enough coins!");
            }
        }
    }
}
