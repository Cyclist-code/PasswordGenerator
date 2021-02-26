using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace PasswordGenerator.Views
{
    public partial class GeneratorPassword : Window
    {
        public GeneratorPassword()
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

        private void SavePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            SavePassword();
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
                for (int i = 0; i < 8; i++)
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

        private void SavePassword()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text files|*.txt";

            if (saveFile.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine(OutputGeneratedPassword.Text);
                    sw.Close();
                }
            }
        }
    }
}
