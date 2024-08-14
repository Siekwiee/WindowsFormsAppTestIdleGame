namespace WindowsFormsAppTestr
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainClick = new System.Windows.Forms.Button();
            this.LvOneFarmProgrssBar = new System.Windows.Forms.ProgressBar();
            this.CollectCoins = new System.Windows.Forms.Button();
            this.LvOneFarmInfoText = new System.Windows.Forms.TextBox();
            this.CoinBalance = new System.Windows.Forms.TextBox();
            this.UpgradeLvOneFarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainClick
            // 
            this.MainClick.Location = new System.Drawing.Point(392, 614);
            this.MainClick.Name = "MainClick";
            this.MainClick.Size = new System.Drawing.Size(520, 33);
            this.MainClick.TabIndex = 0;
            this.MainClick.Text = "Click";
            this.MainClick.UseVisualStyleBackColor = true;
            this.MainClick.Click += new System.EventHandler(this.MainClickButton);
            // 
            // LvOneFarmProgrssBar
            // 
            this.LvOneFarmProgrssBar.Enabled = false;
            this.LvOneFarmProgrssBar.Location = new System.Drawing.Point(24, 34);
            this.LvOneFarmProgrssBar.MarqueeAnimationSpeed = 1000;
            this.LvOneFarmProgrssBar.Name = "LvOneFarmProgrssBar";
            this.LvOneFarmProgrssBar.Size = new System.Drawing.Size(100, 94);
            this.LvOneFarmProgrssBar.TabIndex = 1;
            // 
            // CollectCoins
            // 
            this.CollectCoins.BackColor = System.Drawing.Color.Salmon;
            this.CollectCoins.Location = new System.Drawing.Point(24, 134);
            this.CollectCoins.Name = "CollectCoins";
            this.CollectCoins.Size = new System.Drawing.Size(100, 23);
            this.CollectCoins.TabIndex = 2;
            this.CollectCoins.Text = "Collect";
            this.CollectCoins.UseVisualStyleBackColor = false;
            this.CollectCoins.Click += new System.EventHandler(this.CollectCoins_Click);
            // 
            // LvOneFarmInfoText
            // 
            this.LvOneFarmInfoText.Location = new System.Drawing.Point(24, 8);
            this.LvOneFarmInfoText.Name = "LvOneFarmInfoText";
            this.LvOneFarmInfoText.ReadOnly = true;
            this.LvOneFarmInfoText.Size = new System.Drawing.Size(100, 20);
            this.LvOneFarmInfoText.TabIndex = 3;
            this.LvOneFarmInfoText.Text = "+5 Coins";
            this.LvOneFarmInfoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoinBalance
            // 
            this.CoinBalance.Location = new System.Drawing.Point(600, 588);
            this.CoinBalance.Name = "CoinBalance";
            this.CoinBalance.Size = new System.Drawing.Size(100, 20);
            this.CoinBalance.TabIndex = 4;
            this.CoinBalance.Text = "0";
            this.CoinBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpgradeLvOneFarm
            // 
            this.UpgradeLvOneFarm.Location = new System.Drawing.Point(24, 163);
            this.UpgradeLvOneFarm.Name = "UpgradeLvOneFarm";
            this.UpgradeLvOneFarm.Size = new System.Drawing.Size(100, 23);
            this.UpgradeLvOneFarm.TabIndex = 5;
            this.UpgradeLvOneFarm.Text = "Upgrade";
            this.UpgradeLvOneFarm.UseVisualStyleBackColor = true;
            this.UpgradeLvOneFarm.Click += new System.EventHandler(this.UpgradeLvOneFarm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.UpgradeLvOneFarm);
            this.Controls.Add(this.CoinBalance);
            this.Controls.Add(this.LvOneFarmInfoText);
            this.Controls.Add(this.CollectCoins);
            this.Controls.Add(this.LvOneFarmProgrssBar);
            this.Controls.Add(this.MainClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainClick;
        private System.Windows.Forms.ProgressBar LvOneFarmProgrssBar;
        private System.Windows.Forms.Button CollectCoins;
        private System.Windows.Forms.TextBox LvOneFarmInfoText;
        private System.Windows.Forms.TextBox CoinBalance;
        private System.Windows.Forms.Button UpgradeLvOneFarm;
    }
}

