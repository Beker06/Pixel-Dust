using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Dustin;

namespace PixelDust
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x = 0, y=0, sX=0, sY=0, cX=0, cY=0;
        ColorDialog cd = new ColorDialog();
        Color new_color = Color.White;

        Dust dustin;

        public Form1()
        {
            InitializeComponent();
            herra1.LapizClick += new Herramientas.LapizClickDelegate(lapiz_Click);
            herra1.BorrarClick += new Herramientas.BorrarClickDelegate(borrador_Click);
            herra1.CirculoClick += new Herramientas.CirculoClickDelegate(circulo_Click);
            herra1.RectanguloClick += new Herramientas.RectanguloClickDelegate(rectangulo_Click);
            herra1.LineaClick += new Herramientas.LineaClickDelegate(linea_Click);
            herra1.ColorClick += new Herramientas.ColorClickDelegate(color_Click);
            herra1.FillClick += new Herramientas.FillClickDelegate(fill_Click);

            index = 1;
            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            dustin = new Dust(bm, g, paint, px, py, p, erase, x, y, sX, sY, cX, cY, cd, new_color);

        }

        //CLICK BOTONES HERRAMIENTAS
        private void lapiz_Click(object sender, LapizClickArgs e)
        {
            index = 1;
        }
        private void borrador_Click(object sender, BorrarClickArgs e)
        {
            index = 2;
        }

        private void circulo_Click(object sender, CirculoClickArgs e)
        {
            index = 3;
        }

        private void rectangulo_Click(object sender, RectanguloClickArgs e)
        {
            index = 4;
        }
        private void linea_Click(object sender, LineaClickArgs e)
        {
            index = 5;
        }
        private void color_Click(object sender, ColorClickArgs e)
        {
            dustin.MostrarCD(picColor);
        }

        private void fill_Click(object sender, FillClickArgs e)
        {
            index = 7;
        }

        //EVENTOS DE DIBUJO
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            dustin.Dibujar(pic, e, index);
        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            dustin.ApretarClick(e);
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            dustin.SoltarClick(index);
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            dustin.Fantasma(e, index);
        }
        private void ColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            dustin.ObtenerColor(ColorPicker, picColor, e);
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            dustin.Pintar(pic, e, index);
        }

        //BOTONES
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dustin.Limpiar(pic);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dustin.Guardar(pic);
        }

        
        
    }
}
