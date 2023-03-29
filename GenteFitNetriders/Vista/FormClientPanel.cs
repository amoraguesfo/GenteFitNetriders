using GenteFitNetriders.Controlador;
using System.Windows.Forms;

namespace GenteFitNetriders.Vista
{

    public partial class FormClientPanel : Form
    {

        public FormClientPanel()
        {
            InitializeComponent();

        }

        private void FormClientPanel_Load(object sender, System.EventArgs e)
        {
            labelUserName.Text = Common.userLogged.email;
        }
    }


}
