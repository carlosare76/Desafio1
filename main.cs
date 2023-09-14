using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Desafio1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            // Datos para la primera gráfica (Redes Sociales).
            string[] redesSociales = { "Facebook", "Youtube", "Instagram" };
            double[] usuariosRedesSociales = { 2960, 2515, 1000 };

            // Datos para la segunda gráfica (Plataformas de Streaming).
            string[] plataformasStreaming = { "Netflix", "Amazon Prime", "Disney Plus" };
            double[] usuariosPlataformasStreaming = { 232.5, 200, 157.8 };

            // Configura el tipo de gráfico como Pastel.
            chartRedes.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartPlataformas.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;


            // Asigna los datos y las etiquetas al gráfico.
            chartRedes.Series[0].Points.DataBindXY(redesSociales, usuariosRedesSociales);
            chartPlataformas.Series[0].Points.DataBindXY(plataformasStreaming, usuariosPlataformasStreaming);

            // Agregar un título al gráfico.
            chartRedes.Titles.Add("Redes Sociales más Utilizadas");
            chartPlataformas.Titles.Add("Plataformas de Streaming más Utilizadas");
        }

        

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando se selecciona la pestaña "Estadísticas," muestra las gráficas.
            if (tabControl1.SelectedTab == tabPage3)
            {
                chartRedes.Visible = true;
                chartPlataformas.Visible = true;
            }
            else
            {
                chartRedes.Visible = false;
                chartPlataformas.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
