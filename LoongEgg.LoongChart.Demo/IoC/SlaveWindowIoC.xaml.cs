using LoongEgg.LoongLog.FX45;
using LoongEgg.MvvmCore.FX45;
using System.Linq;
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
            Logger.Debug($"try creat vm");
            Logger.Debug($"vm count=<{IoC.GetViewModels().Count}>");
            DataContext = IoC.GetSingleton<ComunicationViewModel>();
            Logger.Debug($"data context set");
            Logger.Debug($"vm count=<{IoC.GetViewModels().Count}>");
        }
    }
}
