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
    public partial class UpdateClassForm : Form
    {
        ClassManagement business = new ClassManagement();
        int id;

        public UpdateClassForm(int id)
        {
            InitializeComponent();
            this.id = id;
            Class @class = business.GetPropertiesOf(id);
            this.txtName.Text = @class.Name;
            this.txtDescription.Text = @class.Description;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += (sender, e) => this.Dispose();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            business.EditClass(this.id, txtName.Text, txtDescription.Text);
            MessageBox.Show("Edited successfully");
            this.btnCancel.PerformClick();
        }
    }
}
