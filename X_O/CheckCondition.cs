using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace X_O
{
    public class CheckCondition
    {
        public void DisableButton(Button[,] board)
        {
            foreach (Button button in board)
            {
                button.IsEnabled = false;
            }
        }
        public void ResetGame(Button[,] board)
        {
            foreach (Button button in board) 
            {
                button.IsEnabled = true;
                button.Content = "";
            }
        }
        public bool IsBoardFull(Button[,] board)
        {
            foreach (Button button in board)
            {
                if (button.Content == null || button.Content.ToString() == "")
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckWin(Button[,] board, string player)
        {
            // Проверяем по горизонтали
            for (int i = 0; i< 3; i++)
            {
                if (board[i, 0].Content == player &&
                    board[i, 1].Content == player &&
                    board[i, 2].Content == player)
                {
                    return true;
                }
            }

            // Проверяем по вертикали
            for (int i = 0; i< 3; i++)
            {
                if (board[0, i].Content == player &&
                    board[1, i].Content == player &&
                    board[2, i].Content == player)
                {
                    return true;
                }
            }

            // Проверяем по диагонали сверху-вниз
            if (board[0, 0].Content == player &&
                board[1, 1].Content == player &&
                board[2, 2].Content == player)
{
    return true;
}

// Проверяем по диагонали снизу-вверх
if (board[0, 2].Content == player &&
    board[1, 1].Content == player &&
    board[2, 0].Content == player)
{
    return true;
}

return false;
        }
    }
}
