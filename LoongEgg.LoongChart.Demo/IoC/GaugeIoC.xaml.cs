using LoongEgg.MvvmCore.FX45;
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
using System.Windows.Shapes;

namespace LoongEgg.LoongChart.Demo
{
    /// <summary>
    /// GaugeIoC.xaml 的交互逻辑
    /// </summary>
    public partial class GaugeIoC : Window
    {
        public GaugeIoC()
        {
            InitializeComponent();
            DataContext = IoC.GetSingleton<ComunicationViewModel>();
        }
    }
}
