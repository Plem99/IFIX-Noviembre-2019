using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFix
{
    public partial class Lupa2 : Form
    {
        Graphics GraficoCaptura;
        Bitmap ImagenTemporal;
        Point frmMover;
        Boolean MoverMouse;
        int Zoom = 1;

        public Lupa2()
        {
            InitializeComponent();
            timer1.Start();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int AnchoImagen = pictureBox1.Width;
            int AltoImagen = pictureBox1.Height;

            //posicion del mouse
            int MouseX = MousePosition.X;
            int MouseY = MousePosition.Y;

            //cap de screen
            ImagenTemporal = new Bitmap(AnchoImagen / Zoom, AltoImagen / Zoom, System.Drawing.Imaging.PixelFormat.Format64bppPArgb);
            GraficoCaptura = this.CreateGraphics();
            GraficoCaptura = Graphics.FromImage(ImagenTemporal);

            //copia exacta de la pantalla
            GraficoCaptura.CopyFromScreen(MouseX - AnchoImagen / (Zoom * 2), MouseY - AltoImagen / (Zoom * 2), 0, 0, pictureBox1.Size);

            Bitmap NuevaImagen = new Bitmap(AnchoImagen, AltoImagen);
            GraficoCaptura = Graphics.FromImage(NuevaImagen);
            GraficoCaptura.SmoothingMode = SmoothingMode.HighQuality;
            GraficoCaptura.DrawImage(ImagenTemporal, new Rectangle(0, 0, AnchoImagen, AltoImagen));
            pictureBox1.Image = NuevaImagen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverMouse)
            {
                Location = new Point(Cursor.Position.X - frmMover.X, Cursor.Position.Y - frmMover.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoverMouse = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            frmMover = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            MoverMouse = true;

        }
    }
}
