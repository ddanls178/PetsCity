using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PetsCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArredondarPanel(pnlMarrom1, 35);
            ArredondarPanel(pnlMarrom2, 35);
            ArredondarPanel(pnlDados, 35);
            ArredondarPanel(pnlResu, 35);
            ArredondarPanel(pnlLaranja1, 35);
            ArredondarPanel(pnlLaranja2, 35);
            ArredondarPanel(pnlCreme1, 35);
            ArredondarPanel(pnlCreme2, 35);
            ArredondarLabel(lblDados, 15);
            ArredondarLabel(lblResu, 15);
        }

        private void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath caminho = new GraphicsPath();

            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, panel.Height - raio, raio, raio, 90, 90);

            caminho.CloseFigure();

            panel.Region = new Region(caminho);
        }

        private void ArredondarLabel(Label label, int raio)
        {
            GraphicsPath caminho = new GraphicsPath();

            caminho.AddArc(0, 0, raio, raio, 180, 90);
            caminho.AddArc(label.Width - raio, 0, raio, raio, 270, 90);
            caminho.AddArc(label.Width - raio, label.Height - raio, raio, raio, 0, 90);
            caminho.AddArc(0, label.Height - raio, raio, raio, 90, 90);

            caminho.CloseFigure();

            label.Region = new Region(caminho);
        }
    }


}
