
namespace Lab4
{
    partial class WarehouseControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BookDataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.movieLabel = new System.Windows.Forms.Label();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.MovieDataGrid = new System.Windows.Forms.DataGridView();
            this.GameDataGrid = new System.Windows.Forms.DataGridView();
            this.DecreaseMovieSaldo = new System.Windows.Forms.Button();
            this.IncreaseMovieSaldo = new System.Windows.Forms.Button();
            this.DecreaseGameSaldo = new System.Windows.Forms.Button();
            this.IncreaseGameSaldo = new System.Windows.Forms.Button();
            this.DecreaseBookSaldo = new System.Windows.Forms.Button();
            this.IncreaseBookSaldo = new System.Windows.Forms.Button();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
            this.DeleteGameButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.AddMovie = new System.Windows.Forms.Button();
            this.AddGame = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.api_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BookDataGrid
            // 
            this.BookDataGrid.AllowUserToAddRows = false;
            this.BookDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.BookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGrid.Location = new System.Drawing.Point(0, 35);
            this.BookDataGrid.MultiSelect = false;
            this.BookDataGrid.Name = "BookDataGrid";
            this.BookDataGrid.ReadOnly = true;
            this.BookDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGrid.Size = new System.Drawing.Size(719, 145);
            this.BookDataGrid.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.movieLabel);
            this.splitContainer1.Panel1.Controls.Add(this.gamesLabel);
            this.splitContainer1.Panel1.Controls.Add(this.bookLabel);
            this.splitContainer1.Panel1.Controls.Add(this.MovieDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.GameDataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.BookDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DecreaseMovieSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.IncreaseMovieSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.DecreaseGameSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.IncreaseGameSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.DecreaseBookSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.IncreaseBookSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteMovieButton);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteGameButton);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteBookButton);
            this.splitContainer1.Panel2.Controls.Add(this.AddMovie);
            this.splitContainer1.Panel2.Controls.Add(this.AddGame);
            this.splitContainer1.Panel2.Controls.Add(this.AddBook);
            this.splitContainer1.Size = new System.Drawing.Size(928, 551);
            this.splitContainer1.SplitterDistance = 722;
            this.splitContainer1.TabIndex = 2;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.Location = new System.Drawing.Point(3, 373);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(81, 25);
            this.movieLabel.TabIndex = 6;
            this.movieLabel.Text = "Movies";
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLabel.Location = new System.Drawing.Point(3, 188);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(80, 25);
            this.gamesLabel.TabIndex = 5;
            this.gamesLabel.Text = "Games";
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(3, 7);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(72, 25);
            this.bookLabel.TabIndex = 4;
            this.bookLabel.Text = "Books";
            // 
            // MovieDataGrid
            // 
            this.MovieDataGrid.AllowUserToAddRows = false;
            this.MovieDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.MovieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGrid.Location = new System.Drawing.Point(3, 401);
            this.MovieDataGrid.MultiSelect = false;
            this.MovieDataGrid.Name = "MovieDataGrid";
            this.MovieDataGrid.ReadOnly = true;
            this.MovieDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MovieDataGrid.Size = new System.Drawing.Size(717, 145);
            this.MovieDataGrid.TabIndex = 3;
            // 
            // GameDataGrid
            // 
            this.GameDataGrid.AllowUserToAddRows = false;
            this.GameDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.GameDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameDataGrid.Location = new System.Drawing.Point(0, 216);
            this.GameDataGrid.MultiSelect = false;
            this.GameDataGrid.Name = "GameDataGrid";
            this.GameDataGrid.ReadOnly = true;
            this.GameDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameDataGrid.Size = new System.Drawing.Size(720, 145);
            this.GameDataGrid.TabIndex = 2;
            // 
            // DecreaseMovieSaldo
            // 
            this.DecreaseMovieSaldo.Location = new System.Drawing.Point(108, 438);
            this.DecreaseMovieSaldo.Name = "DecreaseMovieSaldo";
            this.DecreaseMovieSaldo.Size = new System.Drawing.Size(50, 35);
            this.DecreaseMovieSaldo.TabIndex = 11;
            this.DecreaseMovieSaldo.Text = "-";
            this.DecreaseMovieSaldo.UseVisualStyleBackColor = true;
            this.DecreaseMovieSaldo.Click += new System.EventHandler(this.DecreaseMovieSaldo_Click);
            // 
            // IncreaseMovieSaldo
            // 
            this.IncreaseMovieSaldo.Location = new System.Drawing.Point(108, 401);
            this.IncreaseMovieSaldo.Name = "IncreaseMovieSaldo";
            this.IncreaseMovieSaldo.Size = new System.Drawing.Size(50, 35);
            this.IncreaseMovieSaldo.TabIndex = 10;
            this.IncreaseMovieSaldo.Text = "+";
            this.IncreaseMovieSaldo.UseVisualStyleBackColor = true;
            this.IncreaseMovieSaldo.Click += new System.EventHandler(this.IncreaseMovieSaldo_Click);
            // 
            // DecreaseGameSaldo
            // 
            this.DecreaseGameSaldo.Location = new System.Drawing.Point(108, 253);
            this.DecreaseGameSaldo.Name = "DecreaseGameSaldo";
            this.DecreaseGameSaldo.Size = new System.Drawing.Size(50, 35);
            this.DecreaseGameSaldo.TabIndex = 9;
            this.DecreaseGameSaldo.Text = "-";
            this.DecreaseGameSaldo.UseVisualStyleBackColor = true;
            this.DecreaseGameSaldo.Click += new System.EventHandler(this.DecreaseGameSaldo_Click);
            // 
            // IncreaseGameSaldo
            // 
            this.IncreaseGameSaldo.Location = new System.Drawing.Point(108, 216);
            this.IncreaseGameSaldo.Name = "IncreaseGameSaldo";
            this.IncreaseGameSaldo.Size = new System.Drawing.Size(50, 35);
            this.IncreaseGameSaldo.TabIndex = 8;
            this.IncreaseGameSaldo.Text = "+";
            this.IncreaseGameSaldo.UseVisualStyleBackColor = true;
            this.IncreaseGameSaldo.Click += new System.EventHandler(this.IncreaseGameSaldo_Click);
            // 
            // DecreaseBookSaldo
            // 
            this.DecreaseBookSaldo.Location = new System.Drawing.Point(108, 72);
            this.DecreaseBookSaldo.Name = "DecreaseBookSaldo";
            this.DecreaseBookSaldo.Size = new System.Drawing.Size(50, 35);
            this.DecreaseBookSaldo.TabIndex = 7;
            this.DecreaseBookSaldo.Text = "-";
            this.DecreaseBookSaldo.UseVisualStyleBackColor = true;
            this.DecreaseBookSaldo.Click += new System.EventHandler(this.DecreaseBookSaldo_Click);
            // 
            // IncreaseBookSaldo
            // 
            this.IncreaseBookSaldo.Location = new System.Drawing.Point(108, 35);
            this.IncreaseBookSaldo.Name = "IncreaseBookSaldo";
            this.IncreaseBookSaldo.Size = new System.Drawing.Size(50, 35);
            this.IncreaseBookSaldo.TabIndex = 6;
            this.IncreaseBookSaldo.Text = "+";
            this.IncreaseBookSaldo.UseVisualStyleBackColor = true;
            this.IncreaseBookSaldo.Click += new System.EventHandler(this.IncreaseBookSaldo_Click);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.DeleteMovieButton.Location = new System.Drawing.Point(3, 474);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(99, 72);
            this.DeleteMovieButton.TabIndex = 5;
            this.DeleteMovieButton.Text = "Delete Movie";
            this.DeleteMovieButton.UseVisualStyleBackColor = false;
            this.DeleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // DeleteGameButton
            // 
            this.DeleteGameButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.DeleteGameButton.Location = new System.Drawing.Point(3, 289);
            this.DeleteGameButton.Name = "DeleteGameButton";
            this.DeleteGameButton.Size = new System.Drawing.Size(99, 72);
            this.DeleteGameButton.TabIndex = 4;
            this.DeleteGameButton.Text = "Delete Game";
            this.DeleteGameButton.UseVisualStyleBackColor = false;
            this.DeleteGameButton.Click += new System.EventHandler(this.DeleteGameButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(176)))), ((int)(((byte)(145)))));
            this.DeleteBookButton.Location = new System.Drawing.Point(3, 108);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(99, 72);
            this.DeleteBookButton.TabIndex = 3;
            this.DeleteBookButton.Text = "Delete Book";
            this.DeleteBookButton.UseVisualStyleBackColor = false;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // AddMovie
            // 
            this.AddMovie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.AddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovie.Location = new System.Drawing.Point(2, 401);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(100, 72);
            this.AddMovie.TabIndex = 2;
            this.AddMovie.Text = "Add Movie";
            this.AddMovie.UseVisualStyleBackColor = false;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // AddGame
            // 
            this.AddGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.AddGame.Location = new System.Drawing.Point(3, 216);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(99, 72);
            this.AddGame.TabIndex = 1;
            this.AddGame.Text = "Add Game";
            this.AddGame.UseVisualStyleBackColor = false;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // AddBook
            // 
            this.AddBook.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.AddBook.Location = new System.Drawing.Point(2, 35);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(100, 72);
            this.AddBook.TabIndex = 0;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // api_btn
            // 
            this.api_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.api_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.api_btn.Location = new System.Drawing.Point(304, 557);
            this.api_btn.Name = "api_btn";
            this.api_btn.Size = new System.Drawing.Size(232, 55);
            this.api_btn.TabIndex = 3;
            this.api_btn.Text = "Sync with API";
            this.api_btn.UseVisualStyleBackColor = false;
            this.api_btn.Click += new System.EventHandler(this.Api_btn_Click);
            // 
            // WarehouseControl
            // 
            this.Controls.Add(this.api_btn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WarehouseControl";
            this.Size = new System.Drawing.Size(928, 627);
            this.Load += new System.EventHandler(this.WarehouseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BookDataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView MovieDataGrid;
        private System.Windows.Forms.DataGridView GameDataGrid;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Button DeleteMovieButton;
        private System.Windows.Forms.Button DeleteGameButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Button DecreaseMovieSaldo;
        private System.Windows.Forms.Button IncreaseMovieSaldo;
        private System.Windows.Forms.Button DecreaseGameSaldo;
        private System.Windows.Forms.Button IncreaseGameSaldo;
        private System.Windows.Forms.Button DecreaseBookSaldo;
        private System.Windows.Forms.Button IncreaseBookSaldo;
        private System.Windows.Forms.Button api_btn;
    }
}
