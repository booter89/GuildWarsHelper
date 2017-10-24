using System;
using System.Collections.Generic;
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

namespace GuildWars2Helper.UserInterface
{
    /// <summary>
    /// Interaction logic for AccountOverview.xaml
    /// </summary>
    public partial class AccountOverview : UserControl
    {
        public MainWindow Parent;

        public AccountOverview(MainWindow parent)
        {
            InitializeComponent();

            this.Parent = parent;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.CharacterOverviewIC.ItemsSource = Parent.account.Characters;
        }

        private void CharcherUC_Click(object sender, RoutedEventArgs e)
        {
            this.Parent.RemoveUserControl();

            Button b = sender as Button;

            Label lable = b.Content as Label;

            string characterName = lable.Content.ToString();

            var charUC = this.Parent.CharacterUserControls.Where(x => x.Character.name == characterName).Select(x => x).ToList();

            this.Parent.MainUC.Children.Add(charUC.First());

            Grid.SetColumn(charUC.First(), 0);

            Grid.SetRow(charUC.First(), 0);
        }
    }
}
