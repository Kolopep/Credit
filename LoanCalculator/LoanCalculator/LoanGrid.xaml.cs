using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoanCalculator
{
    /// <summary>
    /// Interaction logic for LoanGrid.xaml
    /// </summary>
    public partial class LoanGrid : Page
    {
        public LoanGrid(int sum, int day)
        {
            InitializeComponent();
            List<LoanData> loanDatas = new List<LoanData>();
            bool temp = false;
            double bet;
                bet = 0.90;
                loanDatas.Add(new LoanData(0, bet, ((double)sum / 100) * bet, (((double)sum / 100) * bet) + sum));
            for (int i = 1; i < day; i++)
            {
                    if (i >= 0 && i <= 5)
                    {
                        bet = 0.90;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                    }
                    if (i >= 6 && i <= 10)
                    {
                        bet = 0.70;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                    }
                    if (i >= 11)
                    {
                        bet = 0.60;
                        loanDatas.Add(new LoanData(i, bet, loanDatas[i - 1].accumulative + (((double)sum / 100) * bet), loanDatas[i - 1].accumulative + ((((double)sum / 100) * bet) + sum)));
                    }
            }
            TBEffectiveBid.Text += $"{Math.Round(loanDatas[loanDatas.Count - 1].accumulative / sum / day, 2)} рублей";
            TBSumLoan.Text += sum;
            TBProcentSum.Text += loanDatas[loanDatas.Count - 1].accumulative;
            TBAllSumLoan.Text += loanDatas[loanDatas.Count - 1].accumulative + sum;
            TBSumDay.Text += day;
            LoanDataGrid.ItemsSource = loanDatas;
        }
    }
}
