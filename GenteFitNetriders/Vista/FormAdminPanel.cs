﻿using GenteFitNetriders.Controlador;
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



    }
}
