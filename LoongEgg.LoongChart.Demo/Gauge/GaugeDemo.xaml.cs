using System.Windows;

namespace LoongEgg.LoongChart.Demo
{
    /// <summary>
    /// GaugeOnly.xaml 的交互逻辑
    /// </summary>
    public partial class GaugeDemo : Window
    {
        public GaugeDemo()
        {
            InitializeComponent();
            var vm = new GaugeDemoViewModel();
            DataContext = vm;
            GaugeValueControl control = new GaugeValueControl { DataContext = this.DataContext};
            control.Show();
        }

         

    }
}
