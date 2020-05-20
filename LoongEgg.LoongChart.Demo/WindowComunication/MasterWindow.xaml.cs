using System.Windows;

namespace LoongEgg.LoongChart.Demo
{
    /// <summary>
    /// MasterWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MasterWindow : Window
    {
        public MasterWindow()
        {
            InitializeComponent();
            var vm = new ComunicationViewModel();
            DataContext = vm;
            SlaveWindow win = new SlaveWindow { DataContext = vm };
            win.Show();
        }
    }
}
