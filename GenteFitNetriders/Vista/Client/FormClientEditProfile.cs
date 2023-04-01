using GenteFitNetriders.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista.Client
{
    public partial class FormClientEditProfile : Form
    {   
        MainController controller;
        private FormClientPanel fparent;
        public FormClientEditProfile(FormClientPanel fp)
        {
            InitializeComponent();
            fparent = fp;
            controller = new MainController();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            
            if (controller.editUser(Common.userLogged.id, textNombre.Text, textEmail.Text, textSexo.Text, int.Parse(textEdad.Text), textTelefono.Text, textPassword.Text))
            {

                //TODO Buscar mejor solucion que pasar el padre btnActualizar iniciar session para cobiar el label del menu 
                fparent.labelNombre.Text = Common.userLogged.nombre;
                MessageBox.Show("Los datos se han actualizado correctamente");

            }
            else
            {
                MessageBox.Show("Error al crear el usuario");
            }
        }

        private void FormClientEditProfile_Load(object sender, EventArgs e)
        {
            textNombre.Text = Common.userLogged.nombre;
            textEmail.Text = Common.userLogged.email;
            textEdad.Text = Common.userLogged.edad.ToString();
            textSexo.Text = Common.userLogged.sexo;
            textTelefono.Text = Common.userLogged.num_telefono;

        }
    }
}
