using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Marathons
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Volunteer> volunteers = new List<Volunteer>();
        public MainWindow()
        {
            InitializeComponent();
            FillTable();
        }
        
        private void FillTable()
        {
            volunteers.Clear();
            using (MarathonEntities1 db = new MarathonEntities1())
            {
                foreach (Volunteer u in db.Volunteer)
                    volunteers.Add(u);
                DataGridVolonter.ItemsSource = db.Volunteer.Local.ToBindingList();
            }
        }
    }
}
