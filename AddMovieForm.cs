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
    public partial class AddMovieForm : Form
    {
        public Movie Movie { get; private set; }

        BindingSource MovieListSource;

        public AddMovieForm(BindingSource MovieListSource)
        {
            InitializeComponent();
            this.MovieListSource = MovieListSource;
        }

        private void AddMovieForm_AddMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                Movie = new Movie();
                //Validera ID
                for (int i = 0; i < MovieListSource.Count; i++) //Inpiration från Cristoffer Gustafsson
                {
                    var check = (Movie)MovieListSource[i];
                    if ("M" + AddMovieForm_ID.Text != check.ISBN && AddMovieForm_ID.Text.All(Char.IsDigit))
                    {
                        Movie.ISBN = "M" + AddMovieForm_ID.Text;
                    }
                    else
                    {
                        throw new Exception("Invalid ID, Please enter a unique positive integer");
                    }
                }
                if (AddMovieForm_ID.Text.All(Char.IsDigit) && !(string.IsNullOrWhiteSpace(AddMovieForm_ID.Text)))
                {
                    Movie.ISBN = "M" + AddMovieForm_ID.Text;
                }
                else
                {
                    throw new Exception("Invalid ID, Please enter a unique positive integer");
                }

                //Validera namn
                if (AddMovieForm_Name.Text == "" || string.IsNullOrWhiteSpace(AddMovieForm_Name.Text))
                {
                    throw new Exception("Invalid name entered");
                }
                else
                {
                    Movie.Name = AddMovieForm_Name.Text;
                }
                //Validera pris
                if (AddMovieForm_Price.Text.All(Char.IsDigit))
                {
                    Movie.Price = int.Parse(AddMovieForm_Price.Text);
                }
                else
                {
                    throw new Exception("Invalid price entered, Please enter a positive integer");
                }
                
                //Validera saldo
                if (AddMovieForm_Saldo.Text.All(Char.IsDigit)) { 
                    Movie.Saldo = int.Parse(AddMovieForm_Saldo.Text); 
                }
                else
                {
                    throw new Exception("Invalid amount, Please enter a potisive integer");
                }

                //Ingen validering på format eller längd
                Movie.Format = AddMovieForm_Format.Text;
                Movie.Length = AddMovieForm_Length.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void AddMovieForm_ClearButton_Click(object sender, EventArgs e)
        {
            AddMovieForm_ID.Text = "";
            AddMovieForm_Name.Text = "";
            AddMovieForm_Price.Text = "";
            AddMovieForm_Format.Text = "";
            AddMovieForm_Length.Text = "";
            AddMovieForm_Saldo.Text = "";
        }
    }
}
