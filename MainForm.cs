using System;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormView viewForm = new FormView();
            viewForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd addForm = new FormAdd();
            addForm.ShowDialog();
        }
    }
}

