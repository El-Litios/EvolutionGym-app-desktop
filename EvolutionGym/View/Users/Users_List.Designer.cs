
namespace EvolutionGym.View.Users
{
    partial class Users_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_List));
            this.lv_Users = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Rut = new System.Windows.Forms.ColumnHeader();
            this.NameUser = new System.Windows.Forms.ColumnHeader();
            this.UserUser = new System.Windows.Forms.ColumnHeader();
            this.Role = new System.Windows.Forms.ColumnHeader();
            this.tb_SearchField = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AddForm = new System.Windows.Forms.Button();
            this.btn_EditForm = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Users
            // 
            this.lv_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.lv_Users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Rut,
            this.NameUser,
            this.UserUser,
            this.Role});
            this.lv_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_Users.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Users.FullRowSelect = true;
            this.lv_Users.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Users.HideSelection = false;
            this.lv_Users.Location = new System.Drawing.Point(12, 48);
            this.lv_Users.Name = "lv_Users";
            this.lv_Users.Size = new System.Drawing.Size(1148, 524);
            this.lv_Users.TabIndex = 16;
            this.lv_Users.UseCompatibleStateImageBehavior = false;
            this.lv_Users.View = System.Windows.Forms.View.Details;
            this.lv_Users.SelectedIndexChanged += new System.EventHandler(this.lv_Users_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.Width = 0;
            // 
            // Rut
            // 
            this.Rut.Text = "Rut";
            this.Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rut.Width = 287;
            // 
            // NameUser
            // 
            this.NameUser.Text = "Nombre";
            this.NameUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameUser.Width = 287;
            // 
            // UserUser
            // 
            this.UserUser.Text = "Usuario";
            this.UserUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserUser.Width = 287;
            // 
            // Role
            // 
            this.Role.Text = "Rol";
            this.Role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Role.Width = 286;
            // 
            // tb_SearchField
            // 
            this.tb_SearchField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_SearchField.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_SearchField.ForeColor = System.Drawing.Color.Black;
            this.tb_SearchField.Location = new System.Drawing.Point(12, 11);
            this.tb_SearchField.MaxLength = 15;
            this.tb_SearchField.Name = "tb_SearchField";
            this.tb_SearchField.PlaceholderText = "Buscador";
            this.tb_SearchField.Size = new System.Drawing.Size(218, 30);
            this.tb_SearchField.TabIndex = 17;
            this.tb_SearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_SearchField.TextChanged += new System.EventHandler(this.tb_SearchField_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightGray;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Enabled = false;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(245, 11);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 30);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_AddForm
            // 
            this.btn_AddForm.BackColor = System.Drawing.Color.LightGray;
            this.btn_AddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddForm.ForeColor = System.Drawing.Color.Black;
            this.btn_AddForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddForm.Image")));
            this.btn_AddForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddForm.Location = new System.Drawing.Point(12, 584);
            this.btn_AddForm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddForm.Name = "btn_AddForm";
            this.btn_AddForm.Size = new System.Drawing.Size(121, 37);
            this.btn_AddForm.TabIndex = 19;
            this.btn_AddForm.Text = "Agregar";
            this.btn_AddForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddForm.UseVisualStyleBackColor = false;
            this.btn_AddForm.Click += new System.EventHandler(this.btn_AddForm_Click);
            // 
            // btn_EditForm
            // 
            this.btn_EditForm.BackColor = System.Drawing.Color.LightGray;
            this.btn_EditForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_EditForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditForm.Enabled = false;
            this.btn_EditForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EditForm.ForeColor = System.Drawing.Color.Black;
            this.btn_EditForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditForm.Image")));
            this.btn_EditForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditForm.Location = new System.Drawing.Point(143, 584);
            this.btn_EditForm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_EditForm.Name = "btn_EditForm";
            this.btn_EditForm.Size = new System.Drawing.Size(121, 37);
            this.btn_EditForm.TabIndex = 20;
            this.btn_EditForm.Text = "Edición";
            this.btn_EditForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditForm.UseVisualStyleBackColor = false;
            this.btn_EditForm.Click += new System.EventHandler(this.btn_EditForm_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.LightGray;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(1109, 584);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(51, 37);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Users_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 641);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_EditForm);
            this.Controls.Add(this.btn_AddForm);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_SearchField);
            this.Controls.Add(this.lv_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users_List";
            this.Text = "Users_List";
            this.Load += new System.EventHandler(this.Users_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Users;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Rut;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.TextBox tb_SearchField;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_AddForm;
        private System.Windows.Forms.Button btn_EditForm;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ColumnHeader UserUser;
        private System.Windows.Forms.ColumnHeader Role;
    }
}