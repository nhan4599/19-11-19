namespace GUI
{
    partial class IndexClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuList = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.grdClasses = new System.Windows.Forms.DataGridView();
            this.MenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).BeginInit();
            this.SuspendLayout();

            // 
            // MenuList
            // 
            this.MenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDelete});
            this.MenuList.Location = new System.Drawing.Point(0, 0);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(287, 24);
            this.MenuList.TabIndex = 1;
            this.MenuList.Text = "menuStrip1";

            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 20);
            this.btnAdd.Text = "Add Class";

            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 20);
            this.btnDelete.Text = "Delete";

            // 
            // grdClasses
            // 
            this.grdClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClasses.Location = new System.Drawing.Point(0, 0);
            this.grdClasses.Name = "grdClasses";
            this.grdClasses.Size = new System.Drawing.Size(286, 240);
            this.grdClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClasses.TabIndex = 0;

            // 
            // IndexClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.MenuList);
            this.Controls.Add(this.grdClasses);
            this.MainMenuStrip = this.MenuList;
            this.Name = "IndexClassForm";
            this.Text = "List all classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MenuList.ResumeLayout(false);
            this.MenuList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView grdClasses;
        private System.Windows.Forms.MenuStrip MenuList;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;

    }
}

