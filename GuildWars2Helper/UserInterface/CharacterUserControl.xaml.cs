using GuildWars2Helper.Entities;
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
    /// Interaction logic for Character.xaml
    /// </summary>
    public partial class CharacterUserControl : UserControl
    {
        public MainWindow ParentWindow;
        public Character Character = new Character();

        public CharacterUserControl(MainWindow parent, Character c)
        {
            InitializeComponent();

            this.ParentWindow = parent;

            Character = c;

            this.CharacterUC.DataContext = c;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            setInventoryColumnWidth();
        }

        private void setInventoryColumnWidth()
        {
            int columnsWidth = (int)Math.Round(Character.inventoryItems.Count() / ((decimal)16));

            columnsWidth = columnsWidth * 48 + 8;

            this.ColumnTwo.Width = new GridLength(columnsWidth);
        }
    }
}
