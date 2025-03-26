using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Autenticacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // almacenar el valor de los campos de texto en variables
            string user = txtUsuario.Text;
            string password = txtContraseña.Text;

            // validar que el usuario y contraseña sean correctos
            // AND, OR, NOT
            if (user == "frank19" && password == "123") // usando operador AND
            {
                // Creando un objeto de tipo Form1
                Form1 objForm = new Form1();

                objForm.Show();

                this.Hide();
            }
            else
            {

            }
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
