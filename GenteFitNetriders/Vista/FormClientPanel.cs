using GenteFitNetriders.Controlador;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista
{

    public partial class FormClientPanel : Form
    {
        private MainController controller;

        public FormClientPanel()
        {
            InitializeComponent();

        }
        internal void SetController(MainController controller)
        {   
            this.controller = controller;

        }

        private void FormClientPanel_Load(object sender, System.EventArgs e)
        {
            labelUserName.Text = controller.GetUserLogged().email;
        }
    }


}
