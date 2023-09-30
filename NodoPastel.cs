using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPastelesListas
{
    public class NodoPastel
    {
        public Pastel datos = null;
        public NodoPastel liga = null;
        public void PonerDatos(string sabor, string tam, string color, int pv, int nump, int peso, string dis)
        {
            datos = new Pastel()
            {
                sabor = sabor,
                tamano = tam,
                color = color,
                PV = pv,
                NumP = nump,
                peso = peso,
                dis = dis
            };
        }

        public string DevolverDatos()
        {
            return datos.sabor + datos.tamano + "" + datos.color + "" + datos.PV + "" + datos.NumP
                + "" + datos.peso + "" + datos.dis;
        }
    }
}
