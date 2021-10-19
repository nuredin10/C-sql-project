namespace OF_stock_managment
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenuBar = new System.Windows.Forms.Panel();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSells = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panelDesktopPan = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlNavv = new System.Windows.Forms.Panel();
            this.panelTopbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenuBar.SuspendLayout();
            this.pnlTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopbar
            // 
            this.panelTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.panelTopbar.Controls.Add(this.lblTitle);
            this.panelTopbar.Controls.Add(this.panel1);
            this.panelTopbar.Controls.Add(this.label2);
            this.panelTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(1133, 73);
            this.panelTopbar.TabIndex = 0;
            this.panelTopbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopbar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Location = new System.Drawing.Point(279, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 30);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "label1";
            this.lblTitle.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(1023, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 32);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.label2.Font = new System.Drawing.Font("Curlz MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(39, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "O.F";
            // 
            // panelMenuBar
            // 
            this.panelMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(42)))), ((int)(((byte)(81)))));
            this.panelMenuBar.Controls.Add(this.pnlNavv);
            this.panelMenuBar.Controls.Add(this.btnSupplier);
            this.panelMenuBar.Controls.Add(this.pnlTransaction);
            this.panelMenuBar.Controls.Add(this.btnProducts);
            this.panelMenuBar.Controls.Add(this.btnDashboard);
            this.panelMenuBar.Controls.Add(this.panel2);
            this.panelMenuBar.Controls.Add(this.btnLogout);
            this.panelMenuBar.Controls.Add(this.pnlNav);
            this.panelMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuBar.Location = new System.Drawing.Point(0, 73);
            this.panelMenuBar.Name = "panelMenuBar";
            this.panelMenuBar.Size = new System.Drawing.Size(200, 588);
            this.panelMenuBar.TabIndex = 1;
            // 
            // btnSupplier
            // 
            this.btnSupplier.AllowDrop = true;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSupplier.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 295);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(200, 46);
            this.btnSupplier.TabIndex = 26;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click_1);
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.Controls.Add(this.button2);
            this.pnlTransaction.Controls.Add(this.btnSells);
            this.pnlTransaction.Controls.Add(this.btnPurchase);
            this.pnlTransaction.Controls.Add(this.btnTransaction);
            this.pnlTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransaction.Location = new System.Drawing.Point(0, 249);
            this.pnlTransaction.MaximumSize = new System.Drawing.Size(200, 170);
            this.pnlTransaction.MinimumSize = new System.Drawing.Size(200, 46);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(200, 46);
            this.pnlTransaction.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(0, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSells
            // 
            this.btnSells.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSells.FlatAppearance.BorderSize = 0;
            this.btnSells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSells.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSells.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSells.Location = new System.Drawing.Point(0, 86);
            this.btnSells.Name = "btnSells";
            this.btnSells.Size = new System.Drawing.Size(200, 40);
            this.btnSells.TabIndex = 28;
            this.btnSells.Text = "Sells";
            this.btnSells.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPurchase.Location = new System.Drawing.Point(0, 46);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(200, 40);
            this.btnPurchase.TabIndex = 27;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click_1);
            // 
            // btnTransaction
            // 
            this.btnTransaction.AllowDrop = true;
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTransaction.Size = new System.Drawing.Size(200, 46);
            this.btnTransaction.TabIndex = 26;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click_1);
            // 
            // btnProducts
            // 
            this.btnProducts.AllowDrop = true;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 203);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(200, 46);
            this.btnProducts.TabIndex = 27;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AllowDrop = true;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 157);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 46);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 157);
            this.panel2.TabIndex = 17;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(85)))), ((int)(((byte)(230)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 140);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 100);
            this.pnlNav.TabIndex = 0;
            this.pnlNav.Visible = false;
            // 
            // panelDesktopPan
            // 
            this.panelDesktopPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(52)))), ((int)(((byte)(95)))));
            this.panelDesktopPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPan.Location = new System.Drawing.Point(200, 73);
            this.panelDesktopPan.Name = "panelDesktopPan";
            this.panelDesktopPan.Size = new System.Drawing.Size(933, 588);
            this.panelDesktopPan.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 28;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::OF_stock_managment.Properties.Resources.icons8_logout_rounded_left_32px_1;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 533);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 55);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::OF_stock_managment.Properties.Resources.icons8_macos_minimize_60;
            this.btnMinimize.Location = new System.Drawing.Point(3, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::OF_stock_managment.Properties.Resources.icons8_macos_full_screen_60;
            this.btnMaximize.Location = new System.Drawing.Point(44, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 32);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::OF_stock_managment.Properties.Resources.icons8_macos_close_60;
            this.btnClose.Location = new System.Drawing.Point(74, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlNavv
            // 
            this.pnlNavv.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlNavv.Location = new System.Drawing.Point(0, 209);
            this.pnlNavv.Name = "pnlNavv";
            this.pnlNavv.Size = new System.Drawing.Size(5, 100);
            this.pnlNavv.TabIndex = 28;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 661);
            this.Controls.Add(this.panelDesktopPan);
            this.Controls.Add(this.panelMenuBar);
            this.Controls.Add(this.panelTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelTopbar.ResumeLayout(false);
            this.panelTopbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMenuBar.ResumeLayout(false);
            this.pnlTransaction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMenuBar;
        private System.Windows.Forms.Panel panelDesktopPan;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSupplier;
        public System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSells;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlNavv;
    }
}

