using System;
using System.Windows.Forms;

namespace GUI.Contactos
{
    public partial class FormContacto : Form
    {
        public FormContacto()
        {
            InitializeComponent();
        }

        private void FormContacto_Load(object sender, EventArgs e)
        {
            // Puedes inicializar datos aquí más adelante
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Aquí iría la lógica para capturar datos y enviarlos a la BLL (más adelante)
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }
    }
}
