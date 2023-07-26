using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progii
{
    internal class App
    {
        private static string strUsuario;

        public static string StrUsuario
        {
            get { return App.strUsuario; }
            set { App.strUsuario = value; }
        }
        private static string strPassword;

        public static string StrPassword
        {
            get { return App.strPassword; }
            set { App.strPassword = value; }
        }

        public static string Version
        {
            get
            {
                return Application.ProductVersion;
            }
        }

        public static string Producto
        {
            get
            {
                return Application.ProductName;
            }
        }

        public static string TituloVentana
        {
            get
            {
                return string.Format("{0} {1}", Producto, Version);
            }
        }

        public static void MostrarError(string Mensaje)
        {
            MessageBox.Show(Mensaje, TituloVentana, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MostrarPregunta(string Mensaje)
        {
            return MessageBox.Show(Mensaje, TituloVentana, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MostrarInformacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, TituloVentana, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void CerrarAplicacion(System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

    }
}
