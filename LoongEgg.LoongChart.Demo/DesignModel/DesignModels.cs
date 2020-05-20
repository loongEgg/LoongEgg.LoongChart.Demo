/* 
 | 个人微信：InnerGeeker
 | 联系邮箱：LoongEgg@163.com 
 | 创建时间：2020/5/14 16:58:30
 | 主要用途：
 | 更改记录：
 |			 时间		版本		更改
 */
namespace LoongEgg.LoongChart.Demo
{

    public class DesignModels
    {
        public static GaugeDemoViewModel ViewModel { get; set; } = new GaugeDemoViewModel();

        public static MenuViewModel MenuViewModel { get; private set; } = new MenuViewModel();
    }
}
