using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class CashRegisterControl : UserControl
    {
        BindingSource BookListSource;
        BindingSource GameListSource;
        BindingSource MovieListSource;
        WarehouseControl warehouseControl;
        Book book;
        Game game;
        Movie movie;
        string cellID = "";

        public CashRegisterControl(BindingSource bookListSource, BindingSource gameListSource, BindingSource movieListSource)
        {
            InitializeComponent();
            this.BookListSource = bookListSource;
            BookDataGrid.DataSource = bookListSource;

            this.GameListSource = gameListSource;
            GameDataGrid.DataSource = gameListSource;

            this.MovieListSource = movieListSource;
            MovieDataGrid.DataSource = movieListSource;
            
        }
        private void CashRegisterControl_Load(object sender, EventArgs e) //vid Load-händelsen kallar jag på några funktioner
        {
            checkCellValues();
            checkBookSaldo();
            checkMovieSaldo();
            checkGameSaldo();
        }

        private void BookToCartButton_Click(object sender, EventArgs e) //Funktion för att lägga till böcker i kundkorgen
        {
            try
            {
                book = (Book)BookDataGrid.SelectedRows[0].DataBoundItem;    //kastar den valda raden till ett Book-objekt och tilldelar book dess värde
                if (book.Saldo > 0)             //om saldo är större än 0 
                {
                    book.Saldo--;               //minska saldo
                    BookDataGrid.Refresh(); // för att uppdatera DataGriden så att man ser nya värdet direkt - https://www.c-sharpcorner.com/forums/delete-rows-in-datagridview-in-c-sharp
                    CartGridView.Rows.Add(book.ISBN, book.Name, book.Price);        //lägg till boken i kundkorgen
                    CalculateSum();         //räknar ut summan
                }
                else //om saldo är 0 så kastar jag ett fel...
                {
                    throw new Exception("We ran out of that item, come back next week when we have restocked!");
                }
            }
            catch (Exception ex)        //fångar felet och visar upp det i en MessageBox.
            {
                MessageBox.Show(ex.Message, "Out of stock :(");
            }
        }

        private void GameToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                game = (Game)GameDataGrid.SelectedRows[0].DataBoundItem;
                if (game.Saldo > 0)
                {
                    game.Saldo--;
                    GameDataGrid.Refresh(); //långt problem.....
                    CartGridView.Rows.Add(game.ISBN, game.Name, game.Price);
                    CalculateSum();
                }
                else
                {
                    throw new Exception("We ran out of that item, come back next week when we have restocked!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Out of stock :(");
            }
        }

        private void MovieToCartButton_Click(object sender, EventArgs e)
        {
            try { 
                movie = (Movie)MovieDataGrid.SelectedRows[0].DataBoundItem;
                if (movie.Saldo > 0)
                {
                    movie.Saldo--;
                    MovieDataGrid.Refresh(); //långt problem.....
                    CartGridView.Rows.Add(movie.ISBN, movie.Name, movie.Price);
                    CalculateSum();
                }
                else
                {
                    throw new Exception("We ran out of that item, come back next week when we have restocked!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Out of stock :(");
            }
        }

        private void CartBuyButton_Click(object sender, EventArgs e)
        {
            checkBookSaldo();
            checkMovieSaldo();
            checkGameSaldo();
            CartGridView.Rows.Clear();
            CartSum.Text = "";
        }

        public void checkCellValues() //Loopar igenom varje rad, sedan varje cell på raden och kollar om det inte finns något värde...
        {                             //för att sedan sätta bakgrundsfärgen på den cellen till LightSalmon.      
            foreach (DataGridViewRow row in BookDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || String.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        cell.Style.BackColor = Color.LightSalmon;
                    }
                }
            }
            foreach (DataGridViewRow row in GameDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || String.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        cell.Style.BackColor = Color.LightSalmon;
                    }
                }
            }
            foreach (DataGridViewRow row in MovieDataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || String.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        cell.Style.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        
        private void RemoveFromCartButton_Click(object sender, EventArgs e) //funktion för att ta bort ur kundkorgen
        {
            foreach (DataGridViewRow item in this.CartGridView.SelectedRows) //loopar igenom den valda raden. 
            {
                CartGridView.Rows.RemoveAt(item.Index);     //tar bort den selectade raden. 
                if (item.Cells[0].Value.ToString().Contains("B"))   //om ID innehåller ett B
                {
                    cellID = item.Cells[0].Value.ToString();        //Sätt cellID till värdet av cell plats 0(ID)  
                    checkBook();                                    //Kontrollera saldo
                    CalculateSum();                                 //Räkna ut summa
                }
                if (item.Cells[0].Value.ToString().Contains("G"))
                {
                    cellID = item.Cells[0].Value.ToString();
                    checkGame();
                    CalculateSum();
                }
                if (item.Cells[0].Value.ToString().Contains("M"))
                {
                    cellID = item.Cells[0].Value.ToString();
                    checkMovie();
                    CalculateSum();
                }
            }
        }
        private void checkBook()
        {
            foreach (DataGridViewRow row in BookDataGrid.Rows) //loopar igenom alla rader i BookDataGrid
            {
                if (cellID == row.Cells[0].Value.ToString())      //kollar om cellID som jag sätter om i RemoveFromCart-funktionen
                {                                                 //är det samma som något ID i BookDataGrid
                    string tempSaldo = row.Cells[7].Value.ToString();   //om det är sant så sätter om saldot på just den raden
                    int SaldoValue = int.Parse(tempSaldo);
                    SaldoValue++;
                    row.Cells[7].Value = SaldoValue;
                }
            }
        }
        private void checkGame()
        {
            foreach (DataGridViewRow row in GameDataGrid.Rows)
            {
                if (cellID == row.Cells[0].Value.ToString())
                {
                    string tempSaldo = row.Cells[4].Value.ToString();
                    int SaldoValue = int.Parse(tempSaldo);
                    SaldoValue++;
                    row.Cells[4].Value = SaldoValue;
                }
            }
        }
        private void checkMovie()
        {
            foreach (DataGridViewRow row in MovieDataGrid.Rows)
            {
                if (cellID == row.Cells[0].Value.ToString())
                {
                    string tempSaldo = row.Cells[5].Value.ToString();
                    int SaldoValue = int.Parse(tempSaldo);
                    SaldoValue++;
                    row.Cells[5].Value = SaldoValue;
                }
            }
        }
        private void CalculateSum()     //Funktion för att räkna ut summa - https://stackoverflow.com/questions/3779729/how-i-can-show-the-sum-of-in-a-datagridview-column
        {
            int sum = 0;   
            for (int i = 0; i < CartGridView.Rows.Count; ++i) //loopar igenom alla rader i kundkorgen
            {
                sum += Convert.ToInt32(CartGridView.Rows[i].Cells[2].Value);    //sätter sum variabeln till summan av alla värden på cell plats 2
            }
            CartSum.Text = sum.ToString();      //Sätter textboxens innehåll till sum
        }
        public void checkBookSaldo()        //funktion för att ta bort böcker baserat på dess saldo
        {
            //https://stackoverflow.com/questions/24674875/delete-rows-which-has-a-specific-value-from-datagridview-c-sharp
            List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>(); //Lista för att spara rader som ska tas bort.

            foreach (DataGridViewRow row in BookDataGrid.Rows) //För varje rad i BookDataGriden 
            {
                if (Convert.ToInt32(row.Cells[7].Value) == 0) //Om cell[7] som är saldo är lika med 0 så lägger vi till denna rad i RowsToDelete listan
                {
                    RowsToDelete.Add(row);
                }
            }

            foreach (DataGridViewRow row in RowsToDelete) //För varje rad som ligger i listan tar vi bort ifrån griden.
            {
                BookDataGrid.Rows.Remove(row);
            }
            RowsToDelete.Clear();           //Sedan rensar vi listan för att senare fylla på den igen.
        }
        public void checkGameSaldo()
        {
            List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in GameDataGrid.Rows)
            {
                if (Convert.ToInt32(row.Cells[4].Value) == 0)
                {
                    RowsToDelete.Add(row);
                }
            }
            foreach (DataGridViewRow row in RowsToDelete) 
            {
                GameDataGrid.Rows.Remove(row);
            }
            RowsToDelete.Clear();
        }
        public void checkMovieSaldo()
        {
            List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in MovieDataGrid.Rows)
            {
                if (Convert.ToInt32(row.Cells[5].Value) == 0)
                {
                    RowsToDelete.Add(row);
                }
            }
            foreach (DataGridViewRow row in RowsToDelete) 
            {
                BookDataGrid.Rows.Remove(row);
            }
            RowsToDelete.Clear();
        }
    }
}
