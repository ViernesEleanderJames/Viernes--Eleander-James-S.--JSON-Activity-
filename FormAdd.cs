using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GroceryApp
{
    public partial class FormAdd : Form
    {
        private List<GroceryItem> groceries = new List<GroceryItem>();
        private string filePath = "shoppinglist.json";

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (groceries.Count >= 5)
            {
                MessageBox.Show("Maximum of 5 items only.", "Limit");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                groceries.Add(new GroceryItem { Id = groceries.Count + 1, Name = txtName.Text.Trim() });
                listBox1.Items.Add(txtName.Text.Trim());
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item name.", "Warning");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (groceries.Count > 0)
            {
                string json = JsonSerializer.Serialize(groceries, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                MessageBox.Show("Shopping list saved successfully!", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("No items to save.", "Warning");
            }
        }
    }
}

