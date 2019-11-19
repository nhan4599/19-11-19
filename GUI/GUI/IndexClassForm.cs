using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUI
{
    public partial class IndexClassForm : Form
    {
        private ClassManagement business;
        public IndexClassForm()
        {
            business = new ClassManagement();
            InitializeComponent();
            this.btnAdd.Click += btnAdd_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.Load += IndexClassForm_Load;
            this.grdClasses.CellDoubleClick += grdClasses_CellDoubleClick;
        }

        void grdClasses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void IndexClassForm_Load(object sender, EventArgs e)
        {
            LoadAllClasses();
        }

        private void LoadAllClasses()
        {
            this.grdClasses.DataSource = business.GetClasses();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            business.Remove(int.Parse(this.grdClasses.SelectedRows[0].Cells[0].Value.ToString()));
            MessageBox.Show("Deleted successfully");
            this.OnLoad(null);
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            CreateClassForm t = new CreateClassForm();
            t.ShowDialog();
            this.OnLoad(null);
        }
    }
}
