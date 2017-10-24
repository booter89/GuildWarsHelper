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
    /// Interaction logic for StatusTab.xaml
    /// </summary>
    public partial class StatusUserControl : UserControl
    {
        public MainWindow ParentWindow;

        public StatusUserControl(MainWindow parent)
        {
            InitializeComponent();

            this.ParentWindow = parent;

        }
    }
}
