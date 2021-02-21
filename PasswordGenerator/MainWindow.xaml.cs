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

namespace PasswordGenerator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MinBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MainWin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void GeneratePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            GeneratePassword();
        }

        private void GeneratePassword()
        {
            string generatedPassword = "";
            string[] arrayCharacters =
            {
                "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J",
                "K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d",
                "e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };

            Random randomCharacters = new Random();

            if (EightCharactersRB.IsChecked == true)
            {
                for(int i = 0; i < 8; i++)
                {
                    generatedPassword += arrayCharacters[randomCharacters.Next(0, 61)];
                    OutputGeneratedPassword.Text = generatedPassword;
                }
            }

            if (TenCharactersRB.IsChecked == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    generatedPassword += arrayCharacters[randomCharacters.Next(0, 61)];
                    OutputGeneratedPassword.Text = generatedPassword;
                }
            }

            if (TwelveCharactersRB.IsChecked == true)
            {
                for (int i = 0; i < 12; i++)
                {
                    generatedPassword += arrayCharacters[randomCharacters.Next(0, 61)];
                    OutputGeneratedPassword.Text = generatedPassword;
                }
            }

            if (SixteenCharactersRB.IsChecked == true)
            {
                for (int i = 0; i < 16; i++)
                {
                    generatedPassword += arrayCharacters[randomCharacters.Next(0, 61)];
                    OutputGeneratedPassword.Text = generatedPassword;
                }
            }
        }
        
    }
}
