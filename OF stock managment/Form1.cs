using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OF_stock_managment
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;
        public FormMain()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            currentButton = (Button)btnSender;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPan.Controls.Add(childForm);
            this.panelDesktopPan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Visible = true;
            lblTitle.Text = childForm.Text;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    //currentButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlNavv.Visible = true;
                    pnlNavv.Show();
                    pnlNavv.Height = currentButton.Height;
                    pnlNavv.Top = currentButton.Top;
                    pnlNavv.Left = currentButton.Left;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previosBtn in panelMenuBar.Controls)
            {
                if (previosBtn.GetType() == typeof(Button))
                {
                    previosBtn.BackColor = Color.FromArgb(49, 42, 81);
                    previosBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSupplier(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormProducts(), sender);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormTransaction(), sender);
        }

        public static void Exit(string ans)
        {
            if (ans == "Yes")
            {
                Application.Exit();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

            Forms.FormExit exit = new Forms.FormExit();
            exit.Show();

            
            //DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //    Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormDashboard(), sender);
        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormPurchaseTrans(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormTransaction(), sender);
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormProducts(), sender);
        }

        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            if (pnlTransaction.Size == pnlTransaction.MaximumSize)
            {
                pnlTransaction.Size = pnlTransaction.MinimumSize;
            }
            else
            {
                pnlTransaction.Size = pnlTransaction.MaximumSize;

            }
        }

        private void btnSupplier_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormSupplier(), sender);
        }



    }
}
