using Progii.Formularios;
using Progii.Security.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progii
{
    public partial class Logueo : Form
    {
        private UsuarioDTO ItemUsuario = null;
        public Logueo()
        {
            InitializeComponent();

            this.txtUsuario.Text = "";
            this.txtContrasena.Text = "";
        }
        public Logueo(string IdUsuario)
        {
            InitializeComponent();

        }
        private void Logueo_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string Usuario = txtUsuario.Text.Trim();
                string Password = txtContrasena.Text.Trim();

                if (string.IsNullOrEmpty(Usuario))
                    throw new ApplicationException("Error en nombre de usuario.");

                if (string.IsNullOrEmpty(Password))
                    throw new ApplicationException("Error en password");

                //Verificación de la existencia de Perfil del usuario para acceso al Sistema
                if (!Seguridad.Autenticar(Usuario, Password))
                    throw new ApplicationException("Acceso denegado. El usuario no posee Perfil de Acceso al Sistema");

                Hide();
                Principal frm = new Principal();
                frm.Owner = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                App.MostrarError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

    }

    }

