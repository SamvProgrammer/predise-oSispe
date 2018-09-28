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
    public partial class frmMenu : Form
    {
        public frmMenu(Form ventana)
        {
            InitializeComponent();
            int width = this.Size.Width;
            int height = ventana.Size.Height;
            this.Owner = ventana;
            int x = ventana.Location.X;
            int y = ventana.Location.Y;

            this.Size = new Size(width,height-100);
            this.Location = new Point(x+10,(y+(ventana.Height/2)-(this.Height / 2)));
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label4_DragEnter(object sender, DragEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.White;
        }

        private void label4_Enter(object sender, EventArgs e)
        {

        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.White;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Label etiqueta = sender as Label;
            etiqueta.BackColor = Color.White;
        }
    }
}
