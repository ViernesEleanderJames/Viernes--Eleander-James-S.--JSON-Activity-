namespace GroceryApp
{
    partial class FormView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDelete;  // New Button for deleting lists

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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button(); // Initialize the Delete Button
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 200);
            this.listBox1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete List";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);  // Button click event
            // 
            // FormView
            // 
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.btnDelete);  // Add the Delete button to the form
            this.Controls.Add(this.listBox1);
            this.Name = "FormView";
            this.Text = "View Shopping List";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);

        }
    }
}
