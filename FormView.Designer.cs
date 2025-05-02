namespace GroceryApp
{
    partial class FormView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;

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
            // FormView
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.listBox1);
            this.Name = "FormView";
            this.Text = "View Shopping List";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);

        }
    }
}
