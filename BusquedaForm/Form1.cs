using System;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using MetodosBusqueda;

namespace BusquedaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            
            string entrada = Interaction.InputBox("Buscar,Ingresa la palabra");
            int[] V = new int[richtexBusca.Lines.Length];
            for(int i=0; i < V.Length; i++)
            {
                V[i] = int.Parse(richtexBusca.Lines[i]);
            }

            Busqueda busqueda = new Busqueda();

            int posicion = busqueda.Binaria(V,int.Parse(entrada));
            if(posicion==-1)
            {
                MessageBox.Show("Elemento no encontrado");
            }
            else
            {
                int linea=richtexBusca.GetFirstCharIndexFromLine(posicion);
                richtexBusca.Select(linea, richtexBusca.Lines[posicion].Length);
            }
            
        }
    }
}
