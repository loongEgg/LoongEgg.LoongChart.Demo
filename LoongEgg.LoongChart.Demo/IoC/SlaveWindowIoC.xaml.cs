using LoongEgg.MvvmCore.FX45;
using System.Windows;

namespace LoongEgg.LoongChart.Demo
{
    /// <summary>
    /// SlaveWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SlaveWindowIoC : Window
    {
        public SlaveWindowIoC()
        {
            InitializeComponent();
        }

        public ComunicationViewModel VM { get; private set; } = IoC.GetSingleton<ComunicationViewModel>();
    }
}
