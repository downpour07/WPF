using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommunityToolkit.Mvvm.ComponentModel;
using WpfLib.Extensions;

namespace cloneCoding.Controls
{
    /// <summary>
    /// TitleBar.xaml에 대한 상호 작용 논리
    /// </summary>
    [ObservableObject]
    public partial class TitleBar : UserControl
    {
        private Window? _parentWindow;
        [ObservableProperty]
        private WindowState _winState;
        [ObservableProperty]
        private bool _settingState;
        public Window ParentWindow
        {
            get
            {
                if (_parentWindow == null)
                    _parentWindow = this.FindParent<Window>();
                return _parentWindow;
            }
            set { _parentWindow = value; }
        }
        public TitleBar()
        {
            InitializeComponent();

            btnExit.Click += BtnExit_Click;
            btnEx.Click += BtnExit_Click;
            btnSmall.Click += BtnSmall_Click;
            btnSetting.Click += BtnSetting_Click;
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();
        }
        private void BtnSmall_Click(object sender, RoutedEventArgs e)
        {
            WinState = WindowState.Minimized;
            ParentWindow.WindowState = WinState;
        }
        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {
            if (SettingPopup.IsOpen)
            {
                SettingPopup.IsOpen = false;
            }
            else
            {
                SettingPopup.IsOpen = true;
                SettingState = true;
            }
        }
        private void SettingPopup_Closed(object sender, EventArgs e)
        {
            SettingState = false;
        }
    }
}
