using LoongEgg.LoongLog.FX45;
using LoongEgg.MvvmCore.FX45;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

/* 
 | 个人微信：InnerGeeker
 | 联系邮箱：LoongEgg@163.com 
 | 创建时间：2020/5/20 20:40:30
 | 主要用途：
 | 更改记录：
 |			 时间		版本		更改
 */
namespace LoongEgg.LoongChart.Demo
{
	
    public class MenuViewModel:ViewModel
    {
        public ICommand WindowOpenCommand { get; private set; }

        public MenuViewModel()
        {
            WindowOpenCommand = new DelegateCommand<Button>(
                 btn =>
                 {
                     Logger.Debug($"Button <{btn.Content.ToString()}> clicked");
                     Type type = this.GetType();
                     Assembly assembly = type.Assembly;
                     Window win = (Window)assembly.CreateInstance(
                         type.Namespace + "." + btn.Content.ToString().Replace(" ", string.Empty));

                     // Show the window.
                     if (win != null)
                     {
                         //win.ShowDialog(); // 对话框，会挡住程序
                         win.Show(); // 额外的新窗口
                     }
                 }
            );
        }
    }
}
