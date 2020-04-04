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
        CustomersViewModel _vm;     

        public MainWindow(CustomersViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            _vm = vm;
        }


        //**************************************************************************************


        #region (ok) Click bouton
        private void CustomerNew_Click(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            ((CustomersViewModel)DataContext).Customers.Add(temp);    //Facon DataContext
            //_vm.Customers.Add(temp);                                //Facon par autre objet qui la sort du contructeur 

            //((CustomersViewModel)DataContext).SelectedCustomer = temp; //Facon DataContext
            _vm.SelectedCustomer = temp;                                 //Facon par autre objet qui la sort du contructeur 
        }


        private void CustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            int currentIndex = _vm.Customers.IndexOf(_vm.SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            _vm.Customers.Remove(_vm.SelectedCustomer);

            lvCustomers.SelectedIndex = currentIndex;
            
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();                 //Ferme juste fenetre
            App.Current.Shutdown();         //Ferme toute l'app
        }
        #endregion
    }
}
