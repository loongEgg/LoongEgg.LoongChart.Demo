using LoongEgg.MvvmCore.FX45;
using System.Windows;

namespace LoongEgg.LoongChart.Demo
{
    /// <summary>
    /// MasterWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MasterWindowIoC : Window
    {
        public MasterWindowIoC()
        {
            InitializeComponent();
            new SlaveWindowIoC().Show();
        }

        public ComunicationViewModel VM { get; private set; } = IoC.GetSingleton<ComunicationViewModel>(); 
    }
}
