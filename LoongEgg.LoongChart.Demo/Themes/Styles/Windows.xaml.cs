using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoongEgg.LoongChart
{
    /// <summary>
    /// Windows.xaml 的交互逻辑
    /// </summary>
    public partial class Windows : ResourceDictionary
    {
        public Windows() {
            InitializeComponent();
        }

        private void Title_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            if (((FrameworkElement)sender).TemplatedParent is Window self)
                self.DragMove();
        }

        private void WindowStateButton_Click(object sender, RoutedEventArgs e) {
            if (((FrameworkElement)sender).TemplatedParent is Window self) {
                if (e.Source is Button btn) {
                    //string cmd = btn.Content.ToString().ToLower();
                    string cmd = btn.Tag.ToString().ToLower();
                    switch (cmd) {
                        case "minimize": {
                                self.Margin = new Thickness(0);
                                self.WindowState = WindowState.Minimized; break;
                            }
                        case "maximize": {
                                self.WindowState ^= WindowState.Maximized;
                                break;
                            }
                        case "close": self.Close(); break;
                        default:
                            Debugger.Break();
                            break;
                    }
                }
            }
        }

        bool _IsWiden = false;

        /// <summary>
        ///     允许窗口放大
        /// </summary>
        private void Window_WidenInitial(object sender, MouseEventArgs e) => _IsWiden = true;

        /// <summary>
        ///     结束放大
        /// </summary> 
        private void Window_WidenEnd(object sender, MouseButtonEventArgs e) {
            if (sizeGap == null)
                return;
            sizeGap.ReleaseMouseCapture();
            _IsWiden = false;
        }

        Border sizeGap;

        /// <summary>
        ///     放大窗口
        /// </summary> 
        private void Window_Widen(object sender, MouseEventArgs e) {
            if (_IsWiden) {
                if (sender is Border border) {
                    sizeGap = border;
                    sizeGap.CaptureMouse();
                    Window window = Window.GetWindow(sizeGap);
                    double width = e.GetPosition(window).X;
                    double height = e.GetPosition(window).Y;
                    if (width > window.MinWidth && height > window.MinHeight) {
                        window.Width = width;
                        window.Height = height;
                    }
                }
            }
        }
    }
}
