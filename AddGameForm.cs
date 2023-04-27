using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class AddGameForm : Form
    {
        public Game Game { get; private set; }

        BindingSource GameListSource;

        public AddGameForm(BindingSource GameListSource)
        {
            InitializeComponent();
            this.GameListSource = GameListSource;
        }

        private void AddGameForm_AddGameButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Game = new Game();

                //Validera ID
                for (int i = 0; i < GameListSource.Count; i++) //Inpiration från Cristoffer Gustafsson
                {
                    var check = (Game)GameListSource[i];
                    if ("G" + AddGameForm_ID.Text != check.ISBN && AddGameForm_ID.Text.All(Char.IsDigit) && !(string.IsNullOrWhiteSpace(AddGameForm_ID.Text)))
                    {
                        Console.WriteLine("i validering");
                        Game.ISBN = "G" + AddGameForm_ID.Text;
                    }
                    else
                    {
                        throw new Exception("Invalid ID, Please enter a unique positive integer");
                    }
                }
                
                if (AddGameForm_ID.Text.All(Char.IsDigit) && !(string.IsNullOrWhiteSpace(AddGameForm_ID.Text)))
                {
                    Game.ISBN = "G" + AddGameForm_ID.Text;
                }
                else
                {
                    throw new Exception("Invalid ID, Please enter a unique positive integer");
                }

                //Validera namn
                if (AddGameForm_Name.Text == "" || string.IsNullOrWhiteSpace(AddGameForm_Name.Text))
                {
                    throw new Exception("Invalid name entered");
                }
                else
                {
                    Game.Name = AddGameForm_Name.Text;
                }

                //Validera pris
                if (AddGameForm_Price.Text.All(Char.IsDigit))
                {
                    Game.Price = int.Parse(AddGameForm_Price.Text);
                }
                else
                {
                    throw new Exception("Invalid price entered, Please enter a positive integer");
                }

                //Validera saldo
                if (AddGameForm_Saldo.Text.All(Char.IsDigit))
                {
                    Game.Saldo = int.Parse(AddGameForm_Saldo.Text);
                }
                else
                {
                    throw new Exception("Invalid amount, Please enter a potisive integer");
                }

                //Ingen validering på platform
                Game.Platform = AddGameForm_Platform.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void AddGameForm_ClearButton_Click(object sender, EventArgs e)
        {
            AddGameForm_ID.Text = "";
            AddGameForm_Name.Text = "";
            AddGameForm_Price.Text = "";
            AddGameForm_Platform.Text = "";
            AddGameForm_Saldo.Text = "";
        }
    }
}
