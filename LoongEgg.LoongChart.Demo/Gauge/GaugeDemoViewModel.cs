using LoongEgg.MvvmCore.FX45;
using System.Windows.Media;

/* 
 | 个人微信：InnerGeeker
 | 联系邮箱：LoongEgg@163.com 
 | 创建时间：2020/5/14 16:23:52
 | 主要用途：
 | 更改记录：
 |			 时间		版本		更改
 */
namespace LoongEgg.LoongChart.Demo
{

    public class GaugeDemoViewModel : ViewModel
    {
        public GaugeDemoViewModel() {
        }

        public double Value {
            get => _Value;
            set => SetProperty(ref _Value, value);
        }
        private double _Value;

        public PieColorDefinitions ColorsSections {
            get => _ColorsSections;
            set => SetProperty(ref _ColorsSections, value);
        }
        private PieColorDefinitions _ColorsSections = new PieColorDefinitions {
                    new PieColorDefinition{ ValueMax = 180, ValueMin = 90, Fill = Brushes.Chocolate, RadiusMax = 0.75, RadiusMin = 0.65 },
                    new PieColorDefinition{ ValueMax = 30, ValueMin = 0, Fill = Brushes.DarkGreen, RadiusMax = 0.75, RadiusMin = 0.65 },
                };


        public PieTickDefinitions TickSections {
            get => _TickSections;
            set => SetProperty(ref _TickSections, value);
        }
        private PieTickDefinitions _TickSections = new PieTickDefinitions {
                    new PieTickDefinition{ ValueMax = 180, ValueMin = 0, Color = Brushes.SteelBlue, RadiusMax = 0.75, RadiusMin = 0.6, Step = 30, Width =6},
                    new PieTickDefinition{ ValueMax = 180, ValueMin = 0, Color = Brushes.SteelBlue, RadiusMax = 0.75, RadiusMin = 0.65, Step = 10, Width =2 },
                };
         
        public LableDefinition LableDefinition {
            get => _LableDefinition;
            set => SetProperty(ref _LableDefinition, value);
        }
        private LableDefinition _LableDefinition = new LableDefinition
        {
            ValueStep = 30,
            FontSize = 26,
            Offset = 0.5,
            Foreground = Brushes.SteelBlue,
        };
         
        public double ValueMax {
            get => _ValueMax;
            set => SetProperty(ref _ValueMax, value);
        }
        private double _ValueMax = 180;

        public double ValueMin {
            get => _ValueMin;
            set => SetProperty(ref _ValueMin, value);
        }
        private double _ValueMin = 0;


        public double AngleMax {
            get => _AngleMax;
            set => SetProperty(ref _AngleMax, value);
        }
        private double _AngleMax = 420;


        public double AngleMin {
            get => _AngleMin;
            set => SetProperty(ref _AngleMin, value);
        }
        private double _AngleMin = 120;  
    }
}
