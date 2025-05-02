using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class FormView : Form
    {
        private string filePath = "shoppinglist.json";

        public FormView()
        {
            InitializeComponent();
        }

        private async void FormView_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string jsonRead = File.ReadAllText(filePath);
                var groceries = JsonSerializer.Deserialize<List<GroceryItem>>(jsonRead);

                foreach (var item in groceries)
                {
                    listBox1.Items.Add($"ID: {item.Id}, Name: {item.Name}");
                }
            }
            else
            {
                MessageBox.Show("No shopping list found.", "Info");
            }
        }
    }

    
}
