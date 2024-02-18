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

        DataTable To_do_List = new DataTable();
        bool IsEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            To_do_List_Viewe.DataSource = To_do_List;

            To_do_List.Columns.Add("Task");
            To_do_List.Columns.Add("Description");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            TextBox_Tasks.Text = "";
            TextBox_Description.Text = "";
        }

        private void TextBox_Tasks_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                To_do_List.Rows[To_do_List_Viewe.CurrentCell.RowIndex]["Task"] = TextBox_Tasks.Text;
                To_do_List.Rows[To_do_List_Viewe.CurrentCell.RowIndex]["Description"] = TextBox_Description.Text;
            }
            else
            {
                To_do_List.Rows.Add(TextBox_Tasks.Text, TextBox_Description.Text);  
            }

            TextBox_Tasks.Text = "Task";
            TextBox_Description.Text = "Description";
            IsEditing = false;
        }

        private void TextBox_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            IsEditing = true;
            TextBox_Tasks.Text = To_do_List.Rows[To_do_List_Viewe.CurrentCell.RowIndex].ItemArray[0].ToString();
            TextBox_Description.Text = To_do_List.Rows[To_do_List_Viewe.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void To_do_List_Viewe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                To_do_List.Rows[To_do_List_Viewe.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cosole error:" + ex);
            }
        }
    }
}
