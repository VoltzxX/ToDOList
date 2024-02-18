namespace ToDoList
{
    partial class ToDoList
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_Tasks = new System.Windows.Forms.TextBox();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.Button_New = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.label_To_Do_list = new System.Windows.Forms.Label();
            this.To_do_List_Viewe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.To_do_List_Viewe)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Tasks
            // 
            this.TextBox_Tasks.Location = new System.Drawing.Point(12, 87);
            this.TextBox_Tasks.Name = "TextBox_Tasks";
            this.TextBox_Tasks.Size = new System.Drawing.Size(826, 20);
            this.TextBox_Tasks.TabIndex = 1;
            this.TextBox_Tasks.Text = "Tasks";
            this.TextBox_Tasks.TextChanged += new System.EventHandler(this.TextBox_Tasks_TextChanged);
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Location = new System.Drawing.Point(12, 122);
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(826, 20);
            this.TextBox_Description.TabIndex = 2;
            this.TextBox_Description.Text = "Description";
            this.TextBox_Description.TextChanged += new System.EventHandler(this.TextBox_Description_TextChanged);
            // 
            // Button_New
            // 
            this.Button_New.Location = new System.Drawing.Point(12, 148);
            this.Button_New.Name = "Button_New";
            this.Button_New.Size = new System.Drawing.Size(203, 40);
            this.Button_New.TabIndex = 3;
            this.Button_New.Text = "New";
            this.Button_New.UseVisualStyleBackColor = true;
            this.Button_New.Click += new System.EventHandler(this.New_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(220, 148);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(203, 40);
            this.Button_Save.TabIndex = 4;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(427, 148);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(203, 40);
            this.Button_Edit.TabIndex = 5;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(635, 148);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(203, 40);
            this.Button_Delete.TabIndex = 6;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // label_To_Do_list
            // 
            this.label_To_Do_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_To_Do_list.Location = new System.Drawing.Point(12, 9);
            this.label_To_Do_list.Name = "label_To_Do_list";
            this.label_To_Do_list.Size = new System.Drawing.Size(826, 75);
            this.label_To_Do_list.TabIndex = 7;
            this.label_To_Do_list.Text = "To Do List";
            this.label_To_Do_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_To_Do_list.Click += new System.EventHandler(this.label1_Click);
            // 
            // To_do_List_Viewe
            // 
            this.To_do_List_Viewe.AllowUserToAddRows = false;
            this.To_do_List_Viewe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.To_do_List_Viewe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.To_do_List_Viewe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.To_do_List_Viewe.Location = new System.Drawing.Point(12, 198);
            this.To_do_List_Viewe.Name = "To_do_List_Viewe";
            this.To_do_List_Viewe.ReadOnly = true;
            this.To_do_List_Viewe.Size = new System.Drawing.Size(825, 291);
            this.To_do_List_Viewe.TabIndex = 8;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(850, 499);
            this.Controls.Add(this.To_do_List_Viewe);
            this.Controls.Add(this.label_To_Do_list);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_New);
            this.Controls.Add(this.TextBox_Description);
            this.Controls.Add(this.TextBox_Tasks);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.To_do_List_Viewe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox_Tasks;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.Button Button_New;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Label label_To_Do_list;
        private System.Windows.Forms.DataGridView To_do_List_Viewe;
    }
}

