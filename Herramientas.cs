using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PixelDust
{
    public partial class Herramientas : UserControl
    {
        public delegate void LapizClickDelegate(object sender, LapizClickArgs e);
        public event LapizClickDelegate LapizClick;

        public delegate void BorrarClickDelegate(object sender, BorrarClickArgs e);
        public event BorrarClickDelegate BorrarClick;

        public delegate void CirculoClickDelegate(object sender, CirculoClickArgs e);
        public event CirculoClickDelegate CirculoClick;

        public delegate void RectanguloClickDelegate(object sender, RectanguloClickArgs e);
        public event RectanguloClickDelegate RectanguloClick;

        public delegate void LineaClickDelegate(object sender, LineaClickArgs e);
        public event LineaClickDelegate LineaClick;

        public delegate void ColorClickDelegate(object sender, ColorClickArgs e);
        public event ColorClickDelegate ColorClick;

        public delegate void FillClickDelegate(object sender, FillClickArgs e);
        public event FillClickDelegate FillClick;

        private int valor;
        public Herramientas()
        {
            InitializeComponent();
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            valor = 1;
            LapizClickArgs args = new LapizClickArgs(valor);
            LapizClick(this, args);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            valor = 2;
            BorrarClickArgs args = new BorrarClickArgs(valor);
            BorrarClick(this, args);
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            valor = 3;
            CirculoClickArgs args = new CirculoClickArgs(valor);
            CirculoClick(this, args);
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            valor = 4;
            RectanguloClickArgs args = new RectanguloClickArgs(valor);
            RectanguloClick(this, args);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            valor = 5;
            LineaClickArgs args = new LineaClickArgs(valor);
            LineaClick(this, args);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorClickArgs args = new ColorClickArgs();
            ColorClick(this, args);
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            valor = 7;
            FillClickArgs args = new FillClickArgs(valor);
            FillClick(this, args);
        }
    }

    public class LapizClickArgs : EventArgs
    {
        public int Valor { get; set; }
        public LapizClickArgs(int valor)
        {
            Valor = Valor;
        }
    }
    public class BorrarClickArgs : EventArgs
    {
        public int Valor { get; set; }
        public BorrarClickArgs(int valor)
        {
            Valor = Valor;
        }
    }
    public class CirculoClickArgs : EventArgs
    {
        public int Valor { get; set; }
        public CirculoClickArgs(int valor)
        {
            Valor = Valor;
        }
    }
    public class RectanguloClickArgs : EventArgs
    {
        public int Valor { get; set; }
        public RectanguloClickArgs(int valor)
        {
            Valor = Valor;
        }
    }
    public class LineaClickArgs : EventArgs
    {
        public int Valor { get; set; }
        public LineaClickArgs(int valor)
        {
            Valor = Valor;
        }
    }

    public class ColorClickArgs : EventArgs
    {
        public ColorClickArgs()
        {

        }
    }

    public class FillClickArgs : EventArgs
    {
        public int Valor { get; set; }
        public FillClickArgs(int valor)
        {
            Valor = Valor;
        }
    }
}
