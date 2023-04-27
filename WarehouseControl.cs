using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Collections.Generic;

namespace Lab4
{
    public partial class WarehouseControl : UserControl
    {
        BindingSource BookListSource;
        BindingSource GameListSource;
        BindingSource MovieListSource;
        string filePath = "testfil.csv";
        private const string URL = "https://hex.cse.kau.se/~jonavest/csharp-api/";

        public WarehouseControl(BindingSource bookListSource, BindingSource gameListSource, BindingSource movieListSource)
        {
            InitializeComponent();
            this.BookListSource = bookListSource;
            BookDataGrid.DataSource = bookListSource;

            this.GameListSource = gameListSource;
            GameDataGrid.DataSource = gameListSource;

            this.MovieListSource = movieListSource;
            MovieDataGrid.DataSource = movieListSource;
        }
        

        private void AddBook_Click(object sender, EventArgs e) //Funktion för att lägga till böcker
        {
            AddBookForm addBookForm = new AddBookForm(BookListSource);  //Skapar en insans av AddBookForm
            addBookForm.StartPosition = FormStartPosition.CenterParent; //Sätter fönstrets startposition till att vara i mitten av "föräldern"

            if(addBookForm.ShowDialog() == DialogResult.OK) //om man trycker add i fönstret 
            {
                BookListSource.Add(addBookForm.Book);       //lägg till boken i BindingSourcen
            }
            checkCellValues();      
            saveFile();                     //sparar till filen
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm(GameListSource);
            addGameForm.StartPosition = FormStartPosition.CenterParent;

            if (addGameForm.ShowDialog() == DialogResult.OK)
            {
                GameListSource.Add(addGameForm.Game);
            }
            checkCellValues();
            saveFile();
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm(MovieListSource);
            addMovieForm.StartPosition = FormStartPosition.CenterParent;

            if (addMovieForm.ShowDialog() == DialogResult.OK)
            {
                MovieListSource.Add(addMovieForm.Movie);
            }
            checkCellValues();
            saveFile();
        }
        
        

        private void WarehouseControl_Load(object sender, EventArgs e) //när warehouseControl laddas 
        {
            checkCellValues();
        }

        

        public void checkCellValues()
        {
            //Loopar igenom varje rad, sedan varje cell på raden och kollar om det inte finns något värde...
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
        //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/selected-cells-rows-and-columns-datagridview?view=netframeworkdesktop-4.8
        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder(); //Använder mig av stringbuilder för att presentera vilken rad som tagits bort
                int selectedRowCount = BookDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected); //antal rader som är selectade lagrar jag i en variabel
                if (selectedRowCount == 1)       //om en rad är selected
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                        foreach (DataGridViewRow item in this.BookDataGrid.SelectedRows) //loopar igenom alla rader i Datagriden
                        {
                            if (Convert.ToInt32(BookDataGrid.CurrentRow.Cells[7].Value) > 0) //om saldo ej är tomt
                            {
                                DialogResult dg = MessageBox.Show("Do you really want to remove this?", "Deleting row", MessageBoxButtons.YesNo);   //MessageBox som frågar användaren om man verkligen vill ta bort raden.
                                if (dg == DialogResult.Yes) //Klickar man Yes så kommer en ruta upp som visar vad det är man har tagit bort
                                {
                                    sb.Append("You deleted row: ");
                                    sb.Append(BookDataGrid.SelectedRows[i].Index.ToString());
                                    sb.Append(Environment.NewLine);
                                    sb.Append("Containing: ");
                                    sb.Append(Environment.NewLine);
                                    sb.Append($"{BookDataGrid.CurrentRow.Cells[0].Value} {BookDataGrid.CurrentRow.Cells[1].Value}");
                                    MessageBox.Show(sb.ToString(), "Deleting row...");
                                    BookDataGrid.Rows.RemoveAt(item.Index); //Tar bort varan.
                                }
                            }
                            else
                            {
                                BookDataGrid.Rows.RemoveAt(item.Index); //Om saldo är 0 ta bort direkt
                            }
                        }
                    }
                }
                else //om man lyckats selecta flera rader
                {
                    MessageBox.Show("Select 1 row to delete!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            try
            {


                StringBuilder sb = new StringBuilder();
                int selectedRowCount = GameDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                        foreach (DataGridViewRow item in this.GameDataGrid.SelectedRows)
                        {
                            if (Convert.ToInt32(GameDataGrid.CurrentRow.Cells[4].Value) > 0)
                            {
                                DialogResult dg = MessageBox.Show("Do you really want to remove this?", "Deleting row", MessageBoxButtons.YesNo);
                                if (dg == DialogResult.Yes)
                                {
                                    sb.Append("You deleted row: ");
                                    sb.Append(GameDataGrid.SelectedRows[i].Index.ToString());
                                    sb.Append(Environment.NewLine);
                                    sb.Append("Containing: ");
                                    sb.Append(Environment.NewLine);
                                    sb.Append($"ID: {GameDataGrid.CurrentRow.Cells[0].Value} Name: {GameDataGrid.CurrentRow.Cells[1].Value}");
                                    MessageBox.Show(sb.ToString(), "Deleting row...");
                                    GameDataGrid.Rows.RemoveAt(item.Index);
                                }
                            }
                            else
                            {
                                GameDataGrid.Rows.RemoveAt(item.Index);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select 1 row to delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                int selectedRowCount = MovieDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                        foreach (DataGridViewRow item in this.MovieDataGrid.SelectedRows)
                        {
                            if (Convert.ToInt32(MovieDataGrid.CurrentRow.Cells[5].Value.ToString()) > 0)
                            {
                                DialogResult dg = MessageBox.Show("Do you really want to remove this?", "Deleting row", MessageBoxButtons.YesNo);
                                if (dg == DialogResult.Yes)
                                {
                                    sb.Append("You deleted row: ");
                                    sb.Append(MovieDataGrid.SelectedRows[i].Index.ToString());
                                    sb.Append(Environment.NewLine);
                                    sb.Append("Containing: ");
                                    sb.Append(Environment.NewLine);
                                    sb.Append($"ID: {MovieDataGrid.CurrentRow.Cells[0].Value} Name: {MovieDataGrid.CurrentRow.Cells[1].Value}");
                                    MessageBox.Show(sb.ToString(), "Deleting row...");
                                    MovieDataGrid.Rows.RemoveAt(item.Index);
                                }
                            }
                            else
                            {
                                MovieDataGrid.Rows.RemoveAt(item.Index);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select 1 row to delete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ReadFile()
        {
            try
            {
                //https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-6.0
                using (StreamReader sr = new StreamReader(filePath)) //StreamReader som läser "testfil.csv"
                {
                    if (File.Exists(filePath))             //om den filen existerar
                    {
                        foreach (string line in File.ReadAllLines(filePath))     //loopar igenom allt innehåll i filen och sparar det i variabeln "line"
                        { 
                            var tokens = line.Split(',');  //Hjälp ifrån Jonathan Vestin. Tilldelar tokens värdet av varje "cell" i filen.
                            string[] values = tokens;       //skapar en sträng vektor och lägger över värdena så att vi kan targeta var och en
                            if (values[0].StartsWith("B"))  //om id börjar med B
                            {
                                Book b = new Book();        //Skapar en ny bok och tilldelar bokens attribut till det vi har läst av från filen
                                b.ISBN = values[0];
                                b.Name = values[1];
                                b.Price = int.Parse(values[2]);
                                b.Author = values[3];
                                b.Genre = values[4];
                                b.Format = values[5];
                                b.Lang = values[6];
                                b.Saldo = int.Parse(values[7]);
                                BookListSource.Add(b);      //lägger till boken i Datasourcen
                            }
                            else if (values[0].StartsWith("G"))
                            {
                                Game g = new Game();
                                g.ISBN = values[0];
                                g.Name = values[1];
                                g.Price = int.Parse(values[2]);
                                g.Platform = values[3];
                                g.Saldo = int.Parse(values[4]);
                                GameListSource.Add(g);
                            }
                            else if (values[0].StartsWith("M"))
                            {
                                Movie m = new Movie();
                                m.ISBN = values[0];
                                m.Name = values[1];
                                m.Price = int.Parse(values[2]);
                                m.Format = values[3];
                                m.Length = values[4];
                                m.Saldo = int.Parse(values[5]);
                                MovieListSource.Add(m);
                            }
                        }
                        checkCellValues();
                        sr.Close();             //stänger streamreadern
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void saveFile()
        {
            try
            {
                //https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-6.0
                StreamWriter sw = new StreamWriter(filePath);      //skapar en streamwriter som ska skriva till filen "testfil.csv"
                foreach (Book b in BookListSource)                      //för varje bok som finns i datasourcen
                {
                    sw.WriteLine($"{b.ISBN},{b.Name},{b.Price},{b.Author},{b.Genre},{b.Format},{b.Lang},{b.Saldo}\n"); //skriver värdena på rätt position med komma mellan varje.
                }
                foreach (Game g in GameListSource)
                {
                    sw.WriteLine($"{g.ISBN},{g.Name},{g.Price},{g.Platform},{g.Saldo}\n");
                }
                foreach (Movie m in MovieListSource)
                {
                    sw.WriteLine($"{m.ISBN},{m.Name},{m.Price},{m.Format},{m.Length},{m.Saldo}\n");
                }
                sw.Close();         //stänger StreamWritern
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Följande kod är inspirerad av Albin Fernström
        private void IncreaseBookSaldo_Click(object sender, EventArgs e)
        {
            Book book = (Book)BookDataGrid.SelectedRows[0].DataBoundItem; //kastar den valda raden till ett Book objekt och tilldelar book dess värde - https://www.codeproject.com/Articles/5044/Cheat-Sheet-Casting-in-VB-NET-and-C
            book.Saldo++;               //ökar på saldo
            BookDataGrid.Refresh();     //uppdaterar DataGriden så att vi ser det nya värdet direkt
        }

        private void DecreaseBookSaldo_Click(object sender, EventArgs e)
        {
            Book book = (Book)BookDataGrid.SelectedRows[0].DataBoundItem;   
            if(book.Saldo > 0)          //om saldo är större än 0 
                book.Saldo--;           //minska saldo
                
            BookDataGrid.Refresh();     
        }

        private void IncreaseGameSaldo_Click(object sender, EventArgs e)
        {
            Game game = (Game)GameDataGrid.SelectedRows[0].DataBoundItem;
            game.Saldo++;
            GameDataGrid.Refresh();
        }

        private void DecreaseGameSaldo_Click(object sender, EventArgs e)
        {
            Game game = (Game)GameDataGrid.SelectedRows[0].DataBoundItem;
            if (game.Saldo > 0)
                game.Saldo--;
            GameDataGrid.Refresh();
        }

        private void IncreaseMovieSaldo_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)MovieDataGrid.SelectedRows[0].DataBoundItem;
            movie.Saldo++;
            MovieDataGrid.Refresh();
        }

        private void DecreaseMovieSaldo_Click(object sender, EventArgs e)
        {
            Movie movie = (Movie)MovieDataGrid.SelectedRows[0].DataBoundItem;
            if(movie.Saldo > 0)
                movie.Saldo--;
            MovieDataGrid.Refresh();
        }

        private void Api_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=net-6.0
                WebClient client = new WebClient();
                var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);
                Console.WriteLine(text);
                foreach (XmlElement elem in doc.GetElementsByTagName("products"))
                {
                    foreach (XmlElement belem in elem)
                    {
                        if (belem.Name == "book")
                        {
                            Book b = new Book();
                            foreach (XmlElement allBooks in belem.ChildNodes)
                            {
                                if (allBooks.Name == "id")
                                {
                                    b.ISBN = allBooks.InnerText;
                                }
                                else if (allBooks.Name == "stock")
                                {
                                    b.Saldo = int.Parse(allBooks.InnerText);
                                }
                                else if (allBooks.Name == "price")
                                {
                                    b.Price = int.Parse(allBooks.InnerText);
                                }
                            }
                            foreach (DataGridViewRow row in BookDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (row.Cells[0].Value.ToString() == "B" + b.ISBN)
                                    {
                                        row.Cells[2].Value = b.Price;
                                        row.Cells[7].Value = b.Saldo;
                                    }
                                }
                            }
                        }
                        if (belem.Name == "game")
                        {
                            Game g = new Game();
                            foreach (XmlElement allGames in belem.ChildNodes)
                            {
                                if (allGames.Name == "id")
                                {
                                    g.ISBN = allGames.InnerText;
                                }
                                else if (allGames.Name == "stock")
                                {
                                    g.Saldo = int.Parse(allGames.InnerText);
                                }
                                else if (allGames.Name == "price")
                                {
                                    g.Price = int.Parse(allGames.InnerText);
                                }
                            }
                            foreach (DataGridViewRow row in GameDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (row.Cells[0].Value.ToString() == "G" + g.ISBN)
                                    {
                                        row.Cells[2].Value = g.Price;
                                        row.Cells[4].Value = g.Saldo;
                                    }
                                }
                            }
                        }
                        if (belem.Name == "movie")
                        {
                            Movie m = new Movie();
                            foreach (XmlElement allMovies in belem.ChildNodes)
                            {
                                if (allMovies.Name == "id")
                                {
                                    m.ISBN = allMovies.InnerText;
                                }
                                else if (allMovies.Name == "stock")
                                {
                                    m.Saldo = int.Parse(allMovies.InnerText);
                                }
                                else if (allMovies.Name == "price")
                                {
                                    m.Price = int.Parse(allMovies.InnerText);
                                }

                            }
                            foreach (DataGridViewRow row in MovieDataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (row.Cells[0].Value.ToString() == "M" + m.ISBN)
                                    {
                                        row.Cells[2].Value = m.Price;
                                        row.Cells[5].Value = m.Saldo;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WebClient client = new WebClient();
                var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/?action=error");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);
                foreach (XmlElement errorMessage in doc.GetElementsByTagName("error"))
                    MessageBox.Show(errorMessage.InnerText, "Error!");
            }
        }
    }
}
