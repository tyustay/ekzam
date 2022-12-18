using ekzam.AppData;
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

namespace ekzam.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
            var currentTask = ConnectOdb.conObj.Task.ToList();
            DGridOrder.ItemsSource = currentTask;
        }
        private void Add_click(object sender, RoutedEventArgs e)
        {
           
        }
        private void Delete_click(object sender, RoutedEventArgs e)
        {
           
        }
        private void Edit_click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
