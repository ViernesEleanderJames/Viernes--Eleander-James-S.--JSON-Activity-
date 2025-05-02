namespace GroceryApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;

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
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(50, 30);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(200, 50);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View Shopping List";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Grocery Items";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Grocery App Menu";
            this.ResumeLayout(false);

        }
    }
}


