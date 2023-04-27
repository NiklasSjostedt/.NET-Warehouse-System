
namespace Lab4
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.WarehouseTab = new System.Windows.Forms.TabPage();
            this.CashRegisterTab = new System.Windows.Forms.TabPage();
            this.AllTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.WarehouseTab);
            this.AllTabs.Controls.Add(this.CashRegisterTab);
            this.AllTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTabs.Location = new System.Drawing.Point(0, 0);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(1149, 680);
            this.AllTabs.TabIndex = 0;
            // 
            // WarehouseTab
            // 
            this.WarehouseTab.Location = new System.Drawing.Point(4, 22);
            this.WarehouseTab.Name = "WarehouseTab";
            this.WarehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.WarehouseTab.Size = new System.Drawing.Size(1141, 654);
            this.WarehouseTab.TabIndex = 0;
            this.WarehouseTab.Text = "Warehouse";
            this.WarehouseTab.UseVisualStyleBackColor = true;
            // 
            // CashRegisterTab
            // 
            this.CashRegisterTab.Location = new System.Drawing.Point(4, 22);
            this.CashRegisterTab.Name = "CashRegisterTab";
            this.CashRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.CashRegisterTab.Size = new System.Drawing.Size(1141, 583);
            this.CashRegisterTab.TabIndex = 1;
            this.CashRegisterTab.Text = "Cash Registrer";
            this.CashRegisterTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 680);
            this.Controls.Add(this.AllTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Online-shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AllTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.TabPage WarehouseTab;
        private System.Windows.Forms.TabPage CashRegisterTab;
    }
}

