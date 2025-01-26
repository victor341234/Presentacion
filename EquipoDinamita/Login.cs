using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace EquipoDinamita
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = ConexionDB.crearconexion();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wParam,int lParam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;

                // Consulta SQL con parámetros
                cmd.CommandText = "SELECT * FROM Users WHERE nombre = @nombre AND password = @password";
                cmd.Parameters.AddWithValue("@nombre", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);

                MySqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read())
                {
                    Form1 llamar = new Form1();
                    llamar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                    txtuser.Text = "USUARIO";
                    txtuser.ForeColor = Color.DimGray;

                    txtpass.Text = "CONTRASEÑA";
                    txtpass.ForeColor = Color.DimGray;
                    txtpass.UseSystemPasswordChar = false;
                }

                leer.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conexion.Close();
            }

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
