using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
{
    public partial class Login : Form
    {
        private List<Cliente> clientes = new List<Cliente>();

        public Login()
        {
            InitializeComponent();

            // Registro de cliente manual
            clientes.Add(new Cliente { NombreDeUsuario = "usuario1", Password = "password1" });
            clientes.Add(new Cliente { NombreDeUsuario = "usuario2", Password = "password2" });
            clientes.Add(new Cliente { NombreDeUsuario = "usuario3", Password = "password3" });
            clientes.Add(new Cliente { NombreDeUsuario = "usuario4", Password = "password4" });
            clientes.Add(new Cliente { NombreDeUsuario = "usuario5", Password = "password5" });
            clientes.Add(new Cliente { NombreDeUsuario = "usuario6", Password = "password6" });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = textBox1.Text;
            string password = textBox2.Text;

            Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.NombreDeUsuario == nombreDeUsuario && c.Password == password);

            if (clienteEncontrado != null)
            {
                // Las credenciales son válidas
                MessageBox.Show("Inicio de sesión exitoso");

            }
            else
            {
                // Las credenciales son incorrectas
                MessageBox.Show("Credenciales incorrectas. Inténtelo nuevamente.");
            }
        }
    }

    public class Cliente
    {
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
    }
}
