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
    
    public partial class EmployeeMainWindow : Window
    {
        public EmployeeMainWindow()
        {
            InitializeComponent();
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}


//### Создание текстового блока (TextBlock):

//Markup
//< TextBlock Text = "Привет, мир!" />

//### Создание кнопки (Button):

// Markup
//< Button Content = "Нажми меня" />

//### Создание текстового поля (TextBox):

// Markup
//< TextBox Text = "Введите текст" />

//### Создание поля для пароля (PasswordBox):

// Markup
//< PasswordBox PasswordChar = "*" />

//### Создание радиокнопки (RadioButton):

// Markup
//< RadioButton Content = "Первый вариант" />
// < RadioButton Content = "Второй вариант" />

//### Создание флажка (CheckBox):

//  Markup
//< CheckBox Content = "Согласен с условиями" />

//### Создание списка (ListBox):

// Markup
//< ListBox >
//    < ListBoxItem Content = "Первый элемент" />
 
//     < ListBoxItem Content = "Второй элемент" />
//  </ ListBox >

//### Создание выпадающего списка (ComboBox):

//  Markup
//< ComboBox >
//    < ComboBoxItem Content = "Выбор 1" />
 
//     < ComboBoxItem Content = "Выбор 2" />
//  </ ComboBox >

//### Создание метки (Label):

//  Markup
//< Label Content = "Имя:" />

//### Создание изображения (Image):

// Markup
//< Image Source = "path/to/image.png" />