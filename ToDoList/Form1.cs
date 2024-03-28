using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable toDoList = new DataTable();
        bool isEditing = false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            // create columns
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            // Point our datagridview to our datasource

            toDoListView.DataSource = toDoList;
        }


        private void Title_Click(object sender, EventArgs e)
        {
            
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            Title.Text = "";
            Description.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            Title.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            Description.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();  
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"]=Title.Text;
                toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"]=Description.Text;


            }
            else
            {
                toDoList.Rows.Add(Title.Text,Description.Text);
            }
        }
    }
}
