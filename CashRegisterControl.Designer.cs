
namespace Lab4
{
    partial class CashRegisterControl
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
            this.movieLabel = new System.Windows.Forms.Label();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.bookLabel = new System.Windows.Forms.Label();
            this.MovieDataGrid = new System.Windows.Forms.DataGridView();
            this.GameDataGrid = new System.Windows.Forms.DataGridView();
            this.BookDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookToCartButton = new System.Windows.Forms.Button();
            this.GameToCartButton = new System.Windows.Forms.Button();
            this.MovieToCartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CartBuyButton = new System.Windows.Forms.Button();
            this.CartSum = new System.Windows.Forms.TextBox();
            this.RemoveFromCartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.Location = new System.Drawing.Point(6, 372);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(81, 25);
            this.movieLabel.TabIndex = 12;
            this.movieLabel.Text = "Movies";
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLabel.Location = new System.Drawing.Point(6, 187);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(80, 25);
            this.gamesLabel.TabIndex = 11;
            this.gamesLabel.Text = "Games";
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Location = new System.Drawing.Point(6, 6);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(72, 25);
            this.bookLabel.TabIndex = 10;
            this.bookLabel.Text = "Books";
            // 
            // MovieDataGrid
            // 
            this.MovieDataGrid.AllowUserToAddRows = false;
            this.MovieDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.MovieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGrid.Location = new System.Drawing.Point(6, 400);
            this.MovieDataGrid.MultiSelect = false;
            this.MovieDataGrid.Name = "MovieDataGrid";
            this.MovieDataGrid.ReadOnly = true;
            this.MovieDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MovieDataGrid.Size = new System.Drawing.Size(649, 145);
            this.MovieDataGrid.TabIndex = 9;
            // 
            // GameDataGrid
            // 
            this.GameDataGrid.AllowUserToAddRows = false;
            this.GameDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.GameDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameDataGrid.Location = new System.Drawing.Point(3, 215);
            this.GameDataGrid.MultiSelect = false;
            this.GameDataGrid.Name = "GameDataGrid";
            this.GameDataGrid.ReadOnly = true;
            this.GameDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameDataGrid.Size = new System.Drawing.Size(652, 145);
            this.GameDataGrid.TabIndex = 8;
            // 
            // BookDataGrid
            // 
            this.BookDataGrid.AllowUserToAddRows = false;
            this.BookDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.BookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGrid.Location = new System.Drawing.Point(3, 34);
            this.BookDataGrid.MultiSelect = false;
            this.BookDataGrid.Name = "BookDataGrid";
            this.BookDataGrid.ReadOnly = true;
            this.BookDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDataGrid.Size = new System.Drawing.Size(652, 145);
            this.BookDataGrid.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Shopping cart";
            // 
            // CartGridView
            // 
            this.CartGridView.AllowUserToAddRows = false;
            this.CartGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(205)))), ((int)(((byte)(167)))));
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CartName,
            this.Price});
            this.CartGridView.Location = new System.Drawing.Point(775, 34);
            this.CartGridView.MultiSelect = false;
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.Size = new System.Drawing.Size(343, 145);
            this.CartGridView.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CartName
            // 
            this.CartName.HeaderText = "Name";
            this.CartName.Name = "CartName";
            this.CartName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // BookToCartButton
            // 
            this.BookToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.BookToCartButton.Location = new System.Drawing.Point(661, 34);
            this.BookToCartButton.Name = "BookToCartButton";
            this.BookToCartButton.Size = new System.Drawing.Size(93, 64);
            this.BookToCartButton.TabIndex = 15;
            this.BookToCartButton.Text = "Add to cart";
            this.BookToCartButton.UseVisualStyleBackColor = false;
            this.BookToCartButton.Click += new System.EventHandler(this.BookToCartButton_Click);
            // 
            // GameToCartButton
            // 
            this.GameToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.GameToCartButton.Location = new System.Drawing.Point(662, 215);
            this.GameToCartButton.Name = "GameToCartButton";
            this.GameToCartButton.Size = new System.Drawing.Size(92, 70);
            this.GameToCartButton.TabIndex = 16;
            this.GameToCartButton.Text = "Add to cart";
            this.GameToCartButton.UseVisualStyleBackColor = false;
            this.GameToCartButton.Click += new System.EventHandler(this.GameToCartButton_Click);
            // 
            // MovieToCartButton
            // 
            this.MovieToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(128)))), ((int)(((byte)(106)))));
            this.MovieToCartButton.Location = new System.Drawing.Point(661, 400);
            this.MovieToCartButton.Name = "MovieToCartButton";
            this.MovieToCartButton.Size = new System.Drawing.Size(93, 72);
            this.MovieToCartButton.TabIndex = 17;
            this.MovieToCartButton.Text = "Add to cart";
            this.MovieToCartButton.UseVisualStyleBackColor = false;
            this.MovieToCartButton.Click += new System.EventHandler(this.MovieToCartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(984, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Summa: ";
            // 
            // CartBuyButton
            // 
            this.CartBuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(188)))));
            this.CartBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBuyButton.Location = new System.Drawing.Point(1018, 215);
            this.CartBuyButton.Name = "CartBuyButton";
            this.CartBuyButton.Size = new System.Drawing.Size(100, 44);
            this.CartBuyButton.TabIndex = 19;
            this.CartBuyButton.Text = "Buy now";
            this.CartBuyButton.UseVisualStyleBackColor = false;
            this.CartBuyButton.Click += new System.EventHandler(this.CartBuyButton_Click);
            // 
            // CartSum
            // 
            this.CartSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartSum.Location = new System.Drawing.Point(1053, 187);
            this.CartSum.Name = "CartSum";
            this.CartSum.ReadOnly = true;
            this.CartSum.Size = new System.Drawing.Size(65, 22);
            this.CartSum.TabIndex = 20;
            // 
            // RemoveFromCartButton
            // 
            this.RemoveFromCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(188)))));
            this.RemoveFromCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromCartButton.Location = new System.Drawing.Point(775, 180);
            this.RemoveFromCartButton.Name = "RemoveFromCartButton";
            this.RemoveFromCartButton.Size = new System.Drawing.Size(94, 27);
            this.RemoveFromCartButton.TabIndex = 21;
            this.RemoveFromCartButton.Text = "Remove";
            this.RemoveFromCartButton.UseVisualStyleBackColor = false;
            this.RemoveFromCartButton.Click += new System.EventHandler(this.RemoveFromCartButton_Click);
            // 
            // CashRegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveFromCartButton);
            this.Controls.Add(this.CartSum);
            this.Controls.Add(this.CartBuyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieToCartButton);
            this.Controls.Add(this.GameToCartButton);
            this.Controls.Add(this.BookToCartButton);
            this.Controls.Add(this.CartGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.gamesLabel);
            this.Controls.Add(this.bookLabel);
            this.Controls.Add(this.MovieDataGrid);
            this.Controls.Add(this.GameDataGrid);
            this.Controls.Add(this.BookDataGrid);
            this.Name = "CashRegisterControl";
            this.Size = new System.Drawing.Size(1133, 553);
            this.Load += new System.EventHandler(this.CashRegisterControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.DataGridView MovieDataGrid;
        private System.Windows.Forms.DataGridView GameDataGrid;
        private System.Windows.Forms.DataGridView BookDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button BookToCartButton;
        private System.Windows.Forms.Button GameToCartButton;
        private System.Windows.Forms.Button MovieToCartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CartBuyButton;
        private System.Windows.Forms.TextBox CartSum;
        private System.Windows.Forms.Button RemoveFromCartButton;
    }
}
