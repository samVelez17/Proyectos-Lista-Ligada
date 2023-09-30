using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPastelesListas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaracion del comienzo del nodo
        NodoPastel cabeza = null;
        // Declaracion de contador por nodo
        int cont = 0;

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Declaracion de objeto nodo pastel que 
            // da acceso a los metodos
            NodoPastel obj = new NodoPastel();
            // Metodo de insersion de datos en la lista
            obj.PonerDatos(
                textBoxSabor.Text, textBoxTam.Text, textBoxColor.Text,
                int.Parse(textBoxPreciV.Text), int.Parse(textBoxNumP.Text),
                int.Parse(textBoxPeso.Text), textBoxDis.Text);
            
            // Declaracion de identificador ancla
            NodoPastel ancla = null;
            if (cabeza == null) // Si la lista no tiene registros se colocara el primero
            {
                cabeza = obj;
                MessageBox.Show("El primer NODO");
            }
            else
            {
                ancla = cabeza; // Identificacion del nodo final
                // Validacion de los nodos existentes
                while (ancla.liga != null)
                {
                    ancla = ancla.liga;
                }
                ancla.liga = obj;
                MessageBox.Show("Registro completado");
            }

            // Limpiar los texbox
            textBoxSabor.Clear();
            textBoxTam.Clear();
            textBoxPreciV.Clear();
            textBoxColor.Clear();
            textBoxPeso.Clear();
            textBoxNumP.Clear();
            textBoxDis.Clear();
        }

        private void buttonMostrarInicio_Click(object sender, EventArgs e)
        {
            // Declaracion del identificador de cada nodo
            NodoPastel ide = null;
            listBox1.Items.Clear();
            // Declaracion de la lista para mostrar
            List<string> list = new List<string>();
            ide = cabeza;
            // Validacion de los nodos existentes o no existente
            while (ide != null)
            { 
                list.Add(ide.DevolverDatos());
                ide = ide.liga;
            }
            for(int i = 0; i < list.Count; i ++)
                listBox1.Items.Add(list[i]); // Mostrar los registros de las listas
        }

        private void buttonMostrarFin_Click(object sender, EventArgs e)
        {
            // Declaracion del identificador de cada nodo
            NodoPastel ide = null;
            listBox1.Items.Clear();
            List<string> list = new List<string>();
            ide = cabeza;
            // Validacion de los nodos existentes o no existente
            while (ide != null)
            {
                list.Add(ide.DevolverDatos());
                ide = ide.liga;
            }
            for (int i = list.Count-1; i >= 0; i--)
                listBox1.Items.Add(list[i]); // Mostrar los registros de las listas al reverso
        }

        private void buttonPorNodo_Click(object sender, EventArgs e)
        {
            // Declaracion del identificador de cada nodo
            NodoPastel ide = null;
            listBox1.Items.Clear();
            List<string> list = new List<string>();
            ide = cabeza;
            // Validacion de los nodos existentes o no existente
            while (ide != null)
            {
                list.Add(ide.DevolverDatos());
                ide = ide.liga;
            }
            try
            {
                if (cabeza != null)
                {
                    listBox1.Items.Add(list[cont] + " Nodo"+(cont+1)); // Mostrar los registros por nodo
                    cont++;
                }
            }
            catch
            {
                MessageBox.Show("Ya no existen mas regsitros");
            }
        }
    }
}
