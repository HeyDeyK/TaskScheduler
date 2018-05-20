using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TaskNeco
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DailyTrigger();
            RunApp();
            Application.Current.Shutdown();
        }
        public void DailyTrigger()
        {
            TaskDefinition td = TaskService.Instance.NewTask();
            td.RegistrationInfo.Description = "Každý den se pustí jiná nadefinovaná aplikace";

            DailyTrigger dt = new DailyTrigger();
            dt.StartBoundary = DateTime.Today + TimeSpan.FromHours(10);
            dt.DaysInterval = 1;
            td.Triggers.Add(dt);
            td.Actions.Add(new ExecAction(@"A:\VS-projekty\TaskMaster\TaskNeco\TaskNeco\bin\Debug\TaskNeco.exe"));
            TaskService.Instance.RootFolder.RegisterTaskDefinition("EveryDayStart", td);
        }
        public void RunApp()
        {
            // Podle dne se pustí jiná aplikace
            DateTime Today = DateTime.Today;
            if (Today.DayOfWeek==DayOfWeek.Monday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
            else if(Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
            else if (Today.DayOfWeek == DayOfWeek.Thursday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
            else if (Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
            else if (Today.DayOfWeek == DayOfWeek.Friday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
            else if (Today.DayOfWeek == DayOfWeek.Saturday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
            else if (Today.DayOfWeek == DayOfWeek.Sunday)
            {
                //Process.Start(@"A:\VS-projekty\Tray\TrayApp\bin\Debug\TrayApp.exe");
            }
        }
    }
}
