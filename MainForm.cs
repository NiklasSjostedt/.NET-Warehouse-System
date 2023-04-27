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
    public partial class MainForm : Form
    {
        BindingSource BookListSource;
        BindingSource GameListSource;
        BindingSource MovieListSource;
        WarehouseControl warehouseControl;
        CashRegisterControl cashRegisterControl;

        public MainForm()
        {
            InitializeComponent();
            BookListSource = new BindingSource();
            GameListSource = new BindingSource();
            MovieListSource = new BindingSource();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            warehouseControl = new WarehouseControl(BookListSource, GameListSource, MovieListSource);
            warehouseControl.Dock = DockStyle.Fill;
            WarehouseTab.Controls.Add(warehouseControl);
            warehouseControl.ReadFile();

            cashRegisterControl = new CashRegisterControl(BookListSource, GameListSource, MovieListSource);
            cashRegisterControl.Dock = DockStyle.Fill;
            CashRegisterTab.Controls.Add(cashRegisterControl);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            warehouseControl.saveFile();
        }
    }
}
