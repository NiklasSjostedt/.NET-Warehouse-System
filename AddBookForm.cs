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
    public partial class AddBookForm : Form
    {
        public Book Book { get; private set; }

        BindingSource BookListSource;

        public AddBookForm(BindingSource BookListSource)
        {
            InitializeComponent();
            this.BookListSource = BookListSource;
        }

        private void AddBookForm_AddBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                Book = new Book();
                //Validera ID
                for (int i = 0; i < BookListSource.Count; i++) //Inpiration från Cristoffer Gustafsson
                {
                    var check = (Book)BookListSource[i];
                    if ("B" + AddBookForm_ID.Text != check.ISBN && AddBookForm_ID.Text.All(Char.IsDigit) && !(string.IsNullOrWhiteSpace(AddBookForm_ID.Text))) //om ID är unikt och endast siffror
                    {
                        Book.ISBN = "B" + AddBookForm_ID.Text;
                    }
                    else //annars kastar ett fel med passande meddelande
                    {
                        throw new Exception("Invalid ID, Please enter a unique positive integer");
                    }
                    
                }
                if (AddBookForm_ID.Text.All(Char.IsDigit) && !(string.IsNullOrWhiteSpace(AddBookForm_ID.Text)))
                {
                    Book.ISBN = "G" + AddBookForm_ID.Text;
                }
                else
                {
                    throw new Exception("Invalid ID, Please enter a unique positive integer");
                }

                //Validera namn
                if (AddBookForm_Name.Text == "" || string.IsNullOrWhiteSpace(AddBookForm_Name.Text)) //om namn är tomt eller en tom sträng (massa spacebars)
                {
                    throw new Exception("Invalid name entered");        //kastar ett fel
                }
                else
                {
                    Book.Name = AddBookForm_Name.Text; //annars tilldelar bokens namn till inputen
                }
                //Validera pris
                if (AddBookForm_Price.Text.All(Char.IsDigit)) //om pris är en siffra
                {
                    Book.Price = int.Parse(AddBookForm_Price.Text);
                }
                else
                {
                    throw new Exception("Invalid price entered, Please enter a positive integer");
                }


                //Validera saldo
                if (AddBookForm_Saldo.Text.All(Char.IsDigit))
                {
                    Book.Saldo = int.Parse(AddBookForm_Saldo.Text);
                }
                else
                {
                    throw new Exception("Invalid amount, Please enter a potisive integer");
                }

                //Ingen validering på author, genre, format eller language
                Book.Author = AddBookForm_Author.Text;
                Book.Genre = AddBookForm_Genre.Text;
                Book.Format = AddBookForm_Format.Text;
                Book.Lang = AddBookForm_Language.Text;

                DialogResult = DialogResult.OK; //om allt gått igenom sätter vi dialogresultatet till OK
                Close();                        //stänger ned fönstret
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void AddBookForm_ClearButton_Click(object sender, EventArgs e) //funktion för att rensa alla textfält vid klick på "clear"-knappen
        {
            AddBookForm_ID.Text = "";
            AddBookForm_Name.Text = "";
            AddBookForm_Price.Text = "";
            AddBookForm_Author.Text = "";
            AddBookForm_Genre.Text = "";
            AddBookForm_Format.Text = "";
            AddBookForm_Language.Text = "";
            AddBookForm_Saldo.Text = "";
        }
    }
}

