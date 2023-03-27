using GenteFitNetriders.Controlador;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista
{
    public partial class FormAdminPanel : Form
    {
        private MainController controller;
        public FormAdminPanel()
        {
            InitializeComponent();
        }

        internal void SetController(MainController controller)
        {
            this.controller = controller;
        }
        
        private void FormAdminPanel_Load(object sender, System.EventArgs e)
        {
            dataGridUsers.DataSource =  controller.getUsers();
        }

        
    }
}
