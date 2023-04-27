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

namespace X_O
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

        private string originalButtonText;
        bool xoCheck = true;
        CheckCondition checkCondition = new CheckCondition();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button[,] buttons = new Button[,]
            {
                    {Button1, Button2, Button3},
                    {Button4, Button5, Button6},
                    {Button7, Button8, Button9}
            };
            Button clickedButton = sender as Button;
            if (xoCheck)
            {
                clickedButton.Content = "X";
            }
            else
            {
                clickedButton.Content = "O";
            }
            xoCheck = !xoCheck;
            if (checkCondition.IsBoardFull(buttons))
            {
                MessageBox.Show("Перемогла Дружба");
                checkCondition.DisableButton(buttons);
            }
            else
            { 
                if (checkCondition.CheckWin(buttons, "X"))
                {
                    MessageBox.Show("Перемогли Хрестики");
                    foreach (Button button in buttons)
                    checkCondition.DisableButton(buttons);
                }
                if (checkCondition.CheckWin(buttons, "O"))
                    {
                    MessageBox.Show("Перемогли Нулики");
                    checkCondition.DisableButton(buttons);
                }
            }

        }

        private void Button_Click_NewGame(object sender, RoutedEventArgs e)
        {
            Button[,] buttons = new Button[,]
            {
                    {Button1, Button2, Button3},
                    {Button4, Button5, Button6},
                    {Button7, Button8, Button9}
            };
            xoCheck = true;
            checkCondition.ResetGame(buttons);
        }

    }
}
