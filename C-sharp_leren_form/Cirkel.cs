using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace C_sharp_leren_form
{
    class Cirkel
    {
        public Cirkel(int straal, Form tekenform, Color kleur, int lijndikte, Point middelpunt)
        {
            _Straal = straal;
            _Tekenform = tekenform;
            _Lijndikte = lijndikte;
            _Kleur = kleur;
            _Middelpunt = middelpunt;
        }
        private int _Straal = 0;
        private Form _Tekenform = new Form();
        private Point _Middelpunt = new Point(0, 0);
        private Color _Kleur = Color.Red;
        private int _Lijndikte = 1;

        public double Oppervlak()
        {
            return Math.PI * _Straal * _Straal;
        }
        public double Omtrek()
        {
            return 2 * Math.PI * _Straal;
        }
        public void Teken()
        {
            Pen MyPen = new Pen(_Kleur, _Lijndikte);
            Graphics papier = _Tekenform.CreateGraphics();
            papier.DrawEllipse(MyPen, _Middelpunt.X, _Middelpunt.Y, _Straal * 2, _Straal * 2);
        }
    }
}
