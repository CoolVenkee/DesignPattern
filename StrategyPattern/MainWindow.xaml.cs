using System;
using System.Windows;

namespace StrategyPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private double _total;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_OnClick(object sender, RoutedEventArgs e)
        {
            var cashContext = new CashContext(CbDiscount.SelectionBoxItem.ToString()); 
            var totalPrice = cashContext.GetResult(Convert.ToDouble(TbPrice.Text) * Convert.ToDouble(TbCount.Text));
            ListBoxSum.Items.Add("单价：" + TbPrice.Text + " 数量：" + TbCount.Text + " " +
                                 CbDiscount.SelectedIndex + " 合计：" + totalPrice.ToString());
            _total += totalPrice;
            LbTotal.Content = _total.ToString();
        }
    }
}