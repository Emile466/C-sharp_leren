using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace C_sharp_leren_form
{
    class Rechthoek
    {
        public Rechthoek(int lengte, int breedte, Form tekenform, int lijndikte, Color kleur, Point beginpunt)
        {
            _Lengte = lengte;
            _Breedte = breedte;
            _Tekenform = tekenform;
            _Lijndikte = lijndikte;
            _Kleur = kleur;
            _Beginpunt = beginpunt;
        }
        private Point _Beginpunt = new Point(50, 50);
        private int _Lengte = 0;
        private int _Breedte = 0;
        private Form _Tekenform = new Form();
        private Color _Kleur = Color.Red;
        private int _Lijndikte = 1;

        public double Oppervlakte()
        {
            return _Lengte * _Breedte;
        }

        public int Omtrek()
        {
            return (_Lengte * _Breedte) * 2;
        }

        public void Teken()
        {
            Pen MyPen = new Pen(_Kleur, _Lijndikte);
            Graphics papier = _Tekenform.CreateGraphics();
            papier.DrawRectangle(MyPen, _Beginpunt.X, _Beginpunt.Y, _Lengte, _Breedte);
        }
    }
}
