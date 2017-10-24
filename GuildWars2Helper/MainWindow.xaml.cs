using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using GuildWars2Helper.Entities;
using Newtonsoft.Json;
using GuildWars2Helper.UserInterface;

namespace GuildWars2Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool running = false;
        public bool accountLoaded = false;

        public UserActivityHook activity;
        public Account account;

        public StatusUserControl StatusTab;
        public MouseUserControl mouseTab;
        public AccountOverview accountOverviewTap;
        public List<CharacterUserControl> CharacterUserControls = new List<CharacterUserControl>();

        public MainWindow()
        {
            InitializeComponent();

            account = new Account();

            accountOverviewTap = new AccountOverview(this);

            StatusTab = new StatusUserControl(this);

            mouseTab = new MouseUserControl(this);

            UpdateStatus("Status User Control Displayed.");

            MainUC.Children.Add(StatusTab);

            Grid.SetColumn(StatusTab, 0);

            Grid.SetRow(StatusTab, 0);       
        }
                
        public void MouseMoved(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.running == true)
            {
                Mouse.Capture(this);
                Point pointToWindow = Mouse.GetPosition(this);
                Point pointToScreen = PointToScreen(pointToWindow);
                mouseTab.xLabel.Content = pointToScreen.X.ToString();
                mouseTab.yLabel.Content = pointToScreen.Y.ToString();
                Mouse.Capture(null);                
            }
        }

        public List<string> keyClicks = new List<string>();

        public void MyKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            keyClicks.Add(e.KeyData.ToString());

            List<string> AltF1 = new List<string>() { "Escape" };

            if (keyClicks.Contains(AltF1[0]))
            {
                if (this.running == true)
                {
                    this.running = false;
                }
                else
                {
                    this.running = true;
                }
            }                     
        }

        public void MyKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
        }

        public void MyKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            keyClicks.Remove(e.KeyData.ToString());
        }

        public void UpdateStatus(string status, bool error = false)
        {
            ListBoxItem item = new ListBoxItem();

            string updateLine = String.Format("{0}\t{1}", DateTime.Now.ToString(), status);

            item.Foreground = error ? Brushes.Red : Brushes.WhiteSmoke;

            item.Content = updateLine;

            var StatusBox = (ListBox)StatusTab.FindName("StatusBox");

            StatusBox.Items.Add(item);
        }

        private void ReconcileUIElements()
        {

        }

        private void Status_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            UpdateStatus(String.Format("{0} Button Pressed.", b.Content.ToString()));

            RemoveUserControl();

            MainUC.Children.Add(StatusTab);

            Grid.SetColumn(StatusTab, 0);

            Grid.SetRow(StatusTab, 0);

            UpdateStatus(String.Format("{0} User Control Displayed.", b.Content.ToString()));
        }

        private void MousePosition_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            UpdateStatus(String.Format("{0} Button Pressed.", b.Content.ToString()));

            RemoveUserControl();

            MainUC.Children.Add(mouseTab);

            Grid.SetColumn(mouseTab, 0);

            Grid.SetRow(mouseTab, 0);

            UpdateStatus(String.Format("{0} User Control Displayed.", b.Content.ToString()));
        }

        public void RemoveUserControl()
        {
            MainUC.Children.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            activity = new UserActivityHook();

            activity.OnMouseActivity += new System.Windows.Forms.MouseEventHandler(MouseMoved);
            activity.KeyDown += new System.Windows.Forms.KeyEventHandler(MyKeyDown);
            activity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(MyKeyPress);
            activity.KeyUp += new System.Windows.Forms.KeyEventHandler(MyKeyUp);


            UpdateStatus(String.Format("Pulling Account Information From GuildWars2.com"));

            BackgroundWorker worker = new BackgroundWorker();

            worker.WorkerReportsProgress = true;

            worker.DoWork += (o, ea) =>
            {
                account.getAccountCharacters();
                account.getAccountItems();
                account.pairItems();
            };

            worker.ProgressChanged += (o, ea) =>
            {
                UpdateStatus(ea.UserState.ToString());
            };

            worker.RunWorkerCompleted += (o, ea) =>
            {
                accountLoaded = true;

                if (ea.Error != null)
                {
                    UpdateStatus("Error");
                }
                else
                {
                    UpdateStatus(String.Format("Account Information pulled Successfully!"));
                }

                foreach (Character c in account.Characters)
                {
                    CharacterUserControls.Add(new CharacterUserControl(this, c));
                }

                RemoveUserControl();

                MainUC.Children.Add(accountOverviewTap);

                Grid.SetColumn(accountOverviewTap, 0);

                Grid.SetRow(accountOverviewTap, 0);
            };

            worker.RunWorkerAsync();
        }

        private void chacterUCButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveUserControl();

            Button b = sender as Button;

            string characterName = b.Content.ToString();

            UpdateStatus(String.Format("{0} Button Pressed.", characterName));

            var charUC = CharacterUserControls.Where(x => x.Character.name == characterName).Select(x => x).ToList();

            MainUC.Children.Add(charUC.First());

            Grid.SetColumn(charUC.First(), 0);

            Grid.SetRow(charUC.First(), 0);

            UpdateStatus(String.Format("{0} User Control Displayed.", characterName));
        }

        private void AccountOverviewBtn_Click(object sender, RoutedEventArgs e)
        {
            if (accountLoaded)
            {
                RemoveUserControl();

                MainUC.Children.Add(accountOverviewTap);

                Grid.SetColumn(accountOverviewTap, 0);

                Grid.SetRow(accountOverviewTap, 0);
            }            
        }
    }
}
