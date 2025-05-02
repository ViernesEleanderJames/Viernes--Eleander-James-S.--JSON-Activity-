using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class FormView : Form
    {
        private const string filePath = "shoppinglist.json";

        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                if (File.Exists(filePath))
                {
                    string jsonRead = File.ReadAllText(filePath);

                    // Check if the file is empty
                    if (string.IsNullOrEmpty(jsonRead))
                    {
                        listBox1.Items.Add("No shopping lists found.");
                        return;
                    }

                    var allLists = JsonSerializer.Deserialize<List<GroceryList>>(jsonRead);

                    // Check if deserialization failed or returned null
                    if (allLists == null || allLists.Count == 0)
                    {
                        listBox1.Items.Add("No shopping lists found.");
                    }
                    else
                    {
                        foreach (var list in allLists)
                        {
                            listBox1.Items.Add($"--- Shopping List #{list.ListId} - {list.Name} ---"); // Show list name
                            if (list.Items != null && list.Items.Count > 0)
                            {
                                foreach (var item in list.Items)
                                {
                                    listBox1.Items.Add($"  {item.Id}. {item.Name}");
                                }
                            }
                            else
                            {
                                listBox1.Items.Add("  (No items in this list)");
                            }
                            listBox1.Items.Add(""); // Empty line for separation
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No shopping list file found.", "Info");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lists: {ex.Message}", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Extract the ListId from the selected item
                string selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new string[] { "--- Shopping List #" }, StringSplitOptions.None);
                if (parts.Length > 1)
                {
                    string listIdStr = parts[1].Split(' ')[0];
                    int listId = int.Parse(listIdStr);

                    // Load the existing lists
                    List<GroceryList> allLists = JsonSerializer.Deserialize<List<GroceryList>>(File.ReadAllText(filePath));

                    // Find and remove the list by ListId
                    var listToRemove = allLists.Find(list => list.ListId == listId);
                    if (listToRemove != null)
                    {
                        allLists.Remove(listToRemove);

                        // Write the updated list back to the file
                        string json = JsonSerializer.Serialize(allLists, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(filePath, json);

                        MessageBox.Show($"Shopping list #{listId} deleted successfully.", "Success");
                        FormView_Load(sender, e); // Reload the list view
                    }
                    else
                    {
                        MessageBox.Show("List not found.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a list to delete.", "Warning");
            }
        }
    }
}
