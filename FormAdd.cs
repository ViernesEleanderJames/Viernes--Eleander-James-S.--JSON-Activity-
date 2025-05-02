using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class FormAdd : Form
    {
        private List<GroceryItem> groceries = new List<GroceryItem>();
        private const string filePath = "shoppinglist.json";

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
                groceries.Add(new GroceryItem
                {
                    Id = groceries.Count + 1,
                    Name = txtName.Text.Trim()
                });
                listBox1.Items.Add(txtName.Text.Trim());
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item name.", "Warning");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (groceries.Count > 0)
            {
                List<GroceryList> allLists = new List<GroceryList>();

                if (File.Exists(filePath))
                {
                    string existingJson = File.ReadAllText(filePath);
                    allLists = JsonSerializer.Deserialize<List<GroceryList>>(existingJson) ?? new List<GroceryList>();
                }

                int newListId = (allLists.Count > 0) ? allLists[allLists.Count - 1].ListId + 1 : 1;

                // Add list name from the text box
                GroceryList newList = new GroceryList
                {
                    ListId = newListId,
                    Name = txtListName.Text.Trim(), // Get the list name from the TextBox
                    Items = groceries
                };

                allLists.Add(newList);

                string json = JsonSerializer.Serialize(allLists, new JsonSerializerOptions { WriteIndented = true });
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
