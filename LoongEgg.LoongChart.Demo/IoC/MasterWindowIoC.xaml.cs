using LoongEgg.LoongLog.FX45;
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
            Logger.Debug($"try creat vm");
            Logger.Debug($"vm count=<{IoC.GetViewModels().Count}>");
            DataContext = IoC.GetSingleton<ComunicationViewModel>();
            Logger.Debug($"data context set"); 
            Logger.Debug($"vm count=<{IoC.GetViewModels().Count}>");
        }
    }
}
