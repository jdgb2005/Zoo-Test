using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_B
{
    public partial class Matrices : Form
    {
        public Matrices()
        {
            InitializeComponent();
            inicializar();
        }

        private string[,] inicializar()
        {
            /*int n = 0, m = 0;

            Random rnd = new Random();*/

            String [,] knows = new String[11, 2];
            knows[0, 0] = "Animal";
            knows[0, 1] = "NormalValue";

            knows[1,0] = "Zebra";
            knows[1, 1] = "129.5";

            knows[2, 0] = "Unicorn";
            knows[2, 1] = "54.9";

            knows[3, 0] = "Platypus";
            knows[3, 1] = "12.19";

            knows[4, 0] = "Dragon";
            knows[4, 1] = "999.98";

            knows[5, 0] = "Elephant";
            knows[5, 1] = "103.66";

            knows[6, 0] = "Manticore";
            knows[6, 1] = ".035";

            knows[7, 0] = "Duck";
            knows[7, 1] = "1.34";

            knows[8, 0] = "Basilisk";
            knows[8, 1] = "45.2";

            knows[9, 0] = "Sphinx";
            knows[9, 1] = "8.00";

            knows[10, 0] = "Tiger";
            knows[10, 1] = "3.21";

            /*for (n = 0; n < 11; n++)
            {
                for (m = 0; m < 3; m++)
                {
                    resultado.Text += knows[n, m] + " ";
                }

                resultado.Text += String.Format(Environment.NewLine);
            }*/


            /*int[,] animales = new int[10, 2000000];

            //leer

            for(n = 0; n < 5; n++)
            {
                for(m = 0; m < 10; m++)
                {
                    animales[n, m] = rnd.Next(30);
                }
            }

            //imprimir

            for(n = 0; n < 5; n++)
            {
                resultado.Text += " Nombre " + n;
                for (m = 0; m < 10; m++)
                {
                    resultado.Text += " Resultado: " + m;
                }

                resultado.Text += String.Format(Environment.NewLine);
            }*/

            return knows;

        }

        private void clear()
        {
            foreach(Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }

                if (ctr is ListBox)
                {
                    ((ListBox)ctr).Items.Clear();
                }
            }

            nameAnimal.Text = "Animal";
            normalBox.Text = "0";
            CounterMax.Text = "0";
            CounterNormal.Text = "0";
            CounterMin.Text = "0";
        }

        private Double getNormalValue(String name)
        {
            String[,] knows = new String[11, 2];
            knows = inicializar();
            int n = 0, m = 1;
            Double normalValue = 0; 

            for (n = 0; n < 11; n++)
            {
                if (knows[n, 0] != "" && knows[n, 0] == name)
                {
                    nameAnimal.Text = name;
                    normalValue = Double.Parse(knows[n, m]);
                    return normalValue;
                }
            }

            return normalValue;
        }

        private void leerArchivoTXT(string ruta)
        {   
            double[] animales = new double[1000];
            double normalValue = 0;
            int m = 0;
            String linea;

            TextReader leer = new StreamReader(ruta);

            try
            {
                linea = leer.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer el Archivo","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (linea == null)
            {
                MessageBox.Show("El archivo esta en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (linea != null)
            {
                normalValue = getNormalValue(linea);
            }
            if (normalValue == 0)
            {
                MessageBox.Show("No se pudo encontrar Animal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m = 0;

            linea = leer.ReadLine();

            while (linea != null)
            {
                try
                {
                    animales[m] = Double.Parse(linea);
                    linea = leer.ReadLine();
                    m++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al almacenar el valor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    leer.Close();
                    return;
                }
            }

            leer.Close();

            List<Double> listMax = new List<Double>();
            List<Double> listNormal = new List<Double>();
            List<Double> listMin = new List<Double>();


            try
            {
                for (m = 0; m < animales.Length; m++)
                {
                    if (animales[m] > 0)
                    {
                        if (animales[m] > normalValue)
                        {
                            listMax.Add(animales[m]);
                        }
                        else if (animales[m] == normalValue)
                        {
                            listNormal.Add(animales[m]);
                        }
                        else if (animales[m] < normalValue)
                        {
                            listMin.Add(animales[m]);
                        }

                        //resultado.Text += String.Format(Environment.NewLine) + animales[m].ToString() + " ";

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al mostrar el valor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IEnumerable<Double> listMaxOrd = listMax.OrderBy(o => o);
            foreach (Double value in listMaxOrd)
            {
                listMaxBox.Items.Add(value);
            }
            //listMaxBox.DataSource = listMax;
            CounterMax.Text = listMax.Count().ToString();

            normalBox.Text = normalValue.ToString();
            CounterNormal.Text = listNormal.Count().ToString();

            IEnumerable<Double> listMinOrd = listMin.OrderByDescending(o => o);
            foreach (Double value in listMinOrd)
            {
                listMinBox.Items.Add(value);
            }
            CounterMin.Text = listMin.Count().ToString();
        }

        private void leer_Click(object sender, EventArgs e)
        {

            if (leerArchivo.ShowDialog() == DialogResult.OK)
            {
                clear();
                leerArchivoTXT(leerArchivo.FileName);
            }
            else
            {
                MessageBox.Show("No se cargo archivo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            

        }

        private void CounterMax_Click(object sender, EventArgs e)
        {

        }

        private void CounterNormal_Click(object sender, EventArgs e)
        {

        }

        private void clear_form_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you to clear the App", "Clear Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clear();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you to exit application", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
