using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace GuildWars2Helper.UserInterface
{
    /// <summary>
    /// Interaction logic for MouseUserControl.xaml
    /// </summary>
    public partial class MouseUserControl : UserControl
    {
        public MainWindow ParentWindow;
        //public Point mousePosition;

        public MouseUserControl(MainWindow parent)
        {
            InitializeComponent();

            this.ParentWindow = parent;           
        }        
        
        private void StartMouseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.ParentWindow.running = true;
        }

        private void StopMouseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.ParentWindow.running = false;
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();

            worker.WorkerReportsProgress = true;

            worker.DoWork += (o, ea) =>
            {

                Routines.Automation.Test();
               
            };

            worker.ProgressChanged += (o, ea) =>
            {
                this.ParentWindow.UpdateStatus(ea.UserState.ToString());
            };

            worker.RunWorkerCompleted += (o, ea) =>
            {
                
                if (ea.Error != null)
                {
                    this.ParentWindow.UpdateStatus("Error - Mouse Excecution Failed");
                }
                else
                {
                    this.ParentWindow.UpdateStatus(String.Format("Mouse Excecution Successfully!"));
                }                
            };

            worker.RunWorkerAsync();
        }
    }
}
