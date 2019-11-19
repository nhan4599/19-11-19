using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateClassForm : Form
    {
        ClassManagement business = new ClassManagement();
        public CreateClassForm()
        {
            InitializeComponent();
            this.btnAdd.Click += btnAdd_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            business.AddClass(txtName.Text, txtDescription.Text);
            MessageBox.Show("New class has added successfully");
            this.btnCancel.PerformClick();
        }
    }
}
