using System.Windows;
using SmartHunter.Game.Data.ViewModels;

namespace SmartHunter.Ui.Windows
{
    public partial class ConsoleWindow : Window
    {

        System.Windows.Forms.NotifyIcon TrayIcon { get; }

        void MinimizeToTray()
        {
            IsEnabled = false;
            Hide();
            ShowInTaskbar = false;
        }

        void Restore()
        {
            IsEnabled = true;
            Show();
            WindowState = WindowState.Normal;
            ShowInTaskbar = true;
        }

        public ConsoleWindow()
        {
            InitializeComponent();

            LogsTab.DataContext = ConsoleViewModel.Instance;
            SettingsTab.DataContext = SettingsViewModel.Instance;

            TrayIcon = new System.Windows.Forms.NotifyIcon
            {
                Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath),
                Visible = true
            };

            Closed += (s, e) => TrayIcon.Dispose();

            var contextMenu = new System.Windows.Forms.ContextMenu();
            contextMenu.MenuItems.Add("E&xit", (s, e) => Close());
            TrayIcon.ContextMenu = contextMenu;

            TrayIcon.DoubleClick += (s, e) =>
            {
                if (IsEnabled)
                {
                    MinimizeToTray();
                }
                else
                {
                    Restore();
                }
            };
        }

        protected override void OnStateChanged(System.EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                MinimizeToTray();
            }
            base.OnStateChanged(e);
        }
    }
}
