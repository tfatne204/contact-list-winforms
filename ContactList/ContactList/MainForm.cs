using System;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
      
            var addForm = new AddContactForm();
            addForm.ShowDialog();
        

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
