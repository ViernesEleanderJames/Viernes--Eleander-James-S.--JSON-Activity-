using System;

namespace GroceryApp
{
    partial class FormAdd
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtListName;  // New TextBox for the list name

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtListName = new System.Windows.Forms.TextBox(); // Initialize the new TextBox
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 22);
            this.txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(335, 180);
            this.listBox1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save List";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(20, 20);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(335, 22);
            this.txtListName.TabIndex = 4;  // Added for naming the list
            this.txtListName.Text = "Enter list name";  // Placeholder text (manual)
            this.txtListName.ForeColor = System.Drawing.Color.Gray;  // Light gray text for placeholder
            this.txtListName.Enter += new System.EventHandler(this.TxtListName_Enter);
            this.txtListName.Leave += new System.EventHandler(this.TxtListName_Leave);
            // 
            // FormAdd
            // 
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.txtListName);  // Add to the form
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Name = "FormAdd";
            this.Text = "Add Grocery Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtListName_Enter(object sender, EventArgs e)
        {
            if (txtListName.Text == "Enter list name") // Remove placeholder text when focused
            {
                txtListName.Text = "";
                txtListName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtListName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtListName.Text)) // Restore placeholder text when unfocused
            {
                txtListName.Text = "Enter list name";
                txtListName.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
