using RegistroRolesWPF.UI.Consultas;
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

namespace RegistroRolesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles roles = new rRoles();
            roles.Show();
        }

        private void ConsultaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cRoles consulta = new cRoles();
            consulta.Show();
        }
    }
}
