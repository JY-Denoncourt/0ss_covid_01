using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow(CustomersViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }


        //**************************************************************************************

        
        private void CustomerNew_Click(object sender, RoutedEventArgs e)
        {
            /*Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            Customers.Add(temp);
            SelectedCustomer = temp; */          
        }

        private void CustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            /*int currentIndex = Customers.IndexOf(SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            Customers.Remove(SelectedCustomer);

            lvCustomers.SelectedIndex = currentIndex;
            */
        }

    }
}
