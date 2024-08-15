using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestr
{
    public class AutoFarm
    {
        private int _coinsPerInterval;
        private int _interval;
        private bool _isRunning;
        private ProgressBar _progressBar;
        private TextBox _coinBalanceLabel;
        private TextBox _ShowAutoFarmIntervall;

        public AutoFarm(int coinsPerInterval, int interval, ProgressBar progressBar, TextBox coinBalanceLabel, TextBox ShowAutoFarmIntervall)
        {
            _ShowAutoFarmIntervall = ShowAutoFarmIntervall;
            _coinsPerInterval = coinsPerInterval;
            _interval = interval;
            _progressBar = progressBar;
            _coinBalanceLabel = coinBalanceLabel;
        }

        public void Start()
        {
            _isRunning = true;
            Task.Run(() => RunAutoFarm());
        }

        public void Stop()
        {
            _isRunning = false;
        }

        private async Task RunAutoFarm()
        {
            while (_isRunning)
            {
                _ShowAutoFarmIntervall.Invoke((MethodInvoker)delegate
                {
                    _ShowAutoFarmIntervall.Text = _interval.ToString();
                });
                _progressBar.Invoke((MethodInvoker)delegate
                {
                    _progressBar.PerformStep();
                });
                await Task.Delay(_interval);

                if (_progressBar.Value >= 100)
                {
                    _progressBar.Invoke((MethodInvoker)delegate
                    {
                        _progressBar.Value = 0;
                    });

                    _coinBalanceLabel.Invoke((MethodInvoker)delegate
                    {
                        decimal currentBalance;
                        if (decimal.TryParse(_coinBalanceLabel.Text, out currentBalance))
                        {
                            _coinBalanceLabel.Text = (currentBalance + _coinsPerInterval).ToString();
                        }
                        else
                        {
                            // Handle the case where the text is not a valid decimal
                            _coinBalanceLabel.Text = _coinsPerInterval.ToString();
                        }
                    });

                }
            }
        }

        public void Upgrade(int newInterval)
        {
            _interval = newInterval;
        }
    }
}
