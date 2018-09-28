using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diseñoMenu
{
    public partial class frmFondo : Form
    {
        public frmFondo(Form ventana)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Owner = ventana;
            this.Size = ventana.Size;
            this.Location = ventana.Location;
            this.Padding = ventana.Padding;
           
        }

        private void frmFondo_Load(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu(this);
            menu.Show();
        }

        private void frmFondo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmFondo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
