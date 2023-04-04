using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaughtsAndCrosses
{
    public partial class Form_TicTacToe : Form
    {
        public Form_TicTacToe()
        {
            InitializeComponent();
            GenerateButtons();
        }

        Button[,] buttons = new Button[3,3];

        private void GenerateButtons()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(150, 150);
                    buttons[i, j].Location = new Point(i * 150, j * 150);
                    buttons[i, j].FlatStyle = FlatStyle.Flat;
                    buttons[i, j].Font = new Font(DefaultFont.FontFamily, 80, FontStyle.Bold);

                    buttons[i, j].Click += new EventHandler(button_Click);

                    panel1.Controls.Add(buttons[i, j]);
                }
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            //load the clicked button into a local variable
            Button button = sender as Button;
            // Do nothing if button already clicked
            if (button.Text != "")
                return;
            // Mark button with current player's icon
            button.Text = Btn_Player.Text;
            TogglePlayer();
        }

        private void TogglePlayer()
        {
            CheckIfGameEnds();

            if (Btn_Player.Text == "X")
                Btn_Player.Text = "O";
            else
                Btn_Player.Text = "X";
        }

        private void CheckIfGameEnds()
        {
            List<Button> winnerButtons = new List<Button>();

            // Vertical
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text != Btn_Player.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[i, j]);

                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }

            // Horizontal
            for (int i = 0; i< 3; i++)
            {
                winnerButtons = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[j,i].Text != Btn_Player.Text)
                    {
                        break;
                    }

                    winnerButtons.Add(buttons[j, i]);
                    if (j == 2)
                    {
                        ShowWinner(winnerButtons);
                        return;
                    }
                }
            }

            // Diagonal top-left to bottom-right
            winnerButtons = new List<Button>();
            for (int i = 0, j = 0; i < 3; i++, j++)
            {
                if (buttons[i,j].Text != Btn_Player.Text)
                {
                    break;
                }

                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }

            // Diagonal bottom-left to top-right
            winnerButtons = new List<Button>();
            for (int i = 2, j = 0; j < 3; i--, j++)
            {
                if (buttons[i,j].Text != Btn_Player.Text)
                { break; }

                winnerButtons.Add(buttons[i, j]);
                if (j == 2)
                {
                    ShowWinner(winnerButtons);
                    return;
                }
            }

            // All buttons clicked but no winner
            foreach (var button in buttons)
            {
                if (button.Text == "")
                    return;
            }
            MessageBox.Show("Game Draw", "Draw");
        }

        private void ShowWinner(List<Button> winnerButtons)
        {
            foreach (var button in winnerButtons)
            {
                button.BackColor = Color.Red;
            }
            MessageBox.Show("Player " + Btn_Player.Text + " wins!");
        }

        private void Btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
