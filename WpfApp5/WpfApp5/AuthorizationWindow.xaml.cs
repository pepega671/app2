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
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class AuthorizationWindow : Window
    {
        private DatabaseManager dbManager;

        public AuthorizationWindow()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            if (dbManager.ValidateUser(username, password))
            {
                MessageBox.Show("Успешный вход", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                string role = dbManager.GetUserRole(username, password);
                OpenMainPage(role);
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OpenMainPage(string role)
        {
            Window mainWindow;
            switch (role)
            {
                case "Administrator":
                    mainWindow = new AdminMainWindow();
                    break;
                case "Employee":
                    mainWindow = new EmployeeMainWindow();
                    break;
                case "Technician":
                    mainWindow = new TechnicianMainWindow();
                    break;
                default:
                    return;
            }
            mainWindow.Show();
        }
    }
}
// CREATE TABLE Users (
//Id INT PRIMARY KEY AUTO_INCREMENT,
//Username VARCHAR(50) NOT NULL,
//Password VARCHAR(50) NOT NULL,
//Role VARCHAR(50) NOT NULL
//0);

//INSERT INTO Users (Username, Password, Role) VALUES
//('admin', 'adminpassword', 'Administrator'),
//('employee', 'employeepassword', 'Employee'),
//('technician', 'technicianpassword', 'Technician');

//public AuthorizationWindow()
//{
//    InitializeComponent();
//}

//private void LoginButton_Click(object sender, RoutedEventArgs e)
//{
//    string username = UsernameTextBox.Text;
//    string password = PasswordBox.Password;

//    // Пример проверки логина и пароля
//    string role = ValidateCredentials(username, password);
//    if (!string.IsNullOrEmpty(role))
//    {
//        MessageBox.Show("Успешный вход", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
//        OpenMainPage(role);
//        this.Close();
//    }
//    else
//    {
//        MessageBox.Show("Неправильный логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
//    }
//}

//private string ValidateCredentials(string username, string password)
//{
//    // Пример простой проверки логина и пароля
//    if (username == "admin" && password == "adminpassword")
//        return "Administrator";
//    else if (username == "employee" && password == "employeepassword")
//        return "Employee";
//    else if (username == "technician" && password == "technicianpassword")
//        return "Technician";
//    else
//        return string.Empty;
//}

//private void OpenMainPage(string role)
//{
//    Window mainWindow;
//    switch (role)
//    {
//        case "Administrator":
//            mainWindow = new AdminMainWindow();
//            break;
//        case "Employee":
//            mainWindow = new EmployeeMainWindow();
//            break;
//        case "Technician":
//            mainWindow = new TechnicianMainWindow();
//            break;
//        default:
//            return;
//    }
//    mainWindow.Show();

//}