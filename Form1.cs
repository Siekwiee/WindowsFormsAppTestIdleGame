using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestr
{
    public partial class Form1 : Form
    {
        //Variables
        public int LvOneFarmValue { get; set; } = 5;//was ist hier falsch?
        public double LvOneFarmUpgradeCost { get; set; } = 10;
        
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
                CoinBalance.Text = (Convert.ToInt32(CoinBalance.Text) + LvOneFarmValue).ToString();
            }else{
                MessageBox.Show("Farm is not ready yet!");
            }
            
        }
        private void UpgradeLvOneFarm_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(CoinBalance.Text) >= LvOneFarmUpgradeCost)
            {
                LvOneFarmValue += 5;
                CoinBalance.Text = (Convert.ToInt32(CoinBalance.Text) - 10).ToString();
                LvOneFarmInfoText.Text = "+" + LvOneFarmValue + " Coins";
                LvOneFarmUpgradeCost = LvOneFarmUpgradeCost * 1.2;
                UpgradeLvOneFarm.Text = "Lv2 Farm: " + LvOneFarmUpgradeCost.ToString("F2") + " Coins";

            }
            else
            {
                MessageBox.Show("Not enough coins!");
            }
        }
    }
}
