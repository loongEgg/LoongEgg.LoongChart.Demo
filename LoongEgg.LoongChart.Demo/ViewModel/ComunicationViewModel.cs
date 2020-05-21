using LoongEgg.MvvmCore.FX45;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 | 个人微信：InnerGeeker
 | 联系邮箱：LoongEgg@163.com 
 | 创建时间：2020/5/20 21:31:07
 | 主要用途：
 | 更改记录：
 |			 时间		版本		更改
 */
namespace LoongEgg.LoongChart.Demo
{

    public class ComunicationViewModel : ViewModel
    {

        public double SuperMessage
        {
            get => _SuperMessage;
            set => SetProperty(ref _SuperMessage, value);
        }
        private double _SuperMessage = 666;


        public double Indicator
        {
            get => _Indicator;
            set => SetProperty(ref _Indicator, value);
        }
        private double _Indicator = 30;

    }
}
