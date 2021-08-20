
namespace EvolutionGym.View.Clients
{
    partial class Clients_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients_List));
            this.tb_User = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lv_Clients = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Rut = new System.Windows.Forms.ColumnHeader();
            this.NameClient = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Phone = new System.Windows.Forms.ColumnHeader();
            this.btn_AddForm = new System.Windows.Forms.Button();
            this.btn_EditForm = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_User
            // 
            this.tb_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_User.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_User.ForeColor = System.Drawing.Color.Black;
            this.tb_User.Location = new System.Drawing.Point(12, 11);
            this.tb_User.MaxLength = 15;
            this.tb_User.Name = "tb_User";
            this.tb_User.PlaceholderText = "Buscador";
            this.tb_User.Size = new System.Drawing.Size(218, 30);
            this.tb_User.TabIndex = 10;
            this.tb_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightGray;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Enabled = false;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(245, 11);
            this.btn_login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(42, 30);
            this.btn_login.TabIndex = 14;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // lv_Clients
            // 
            this.lv_Clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.lv_Clients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Rut,
            this.NameClient,
            this.Email,
            this.Phone});
            this.lv_Clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_Clients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Clients.FullRowSelect = true;
            this.lv_Clients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Clients.HideSelection = false;
            this.lv_Clients.Location = new System.Drawing.Point(12, 48);
            this.lv_Clients.Name = "lv_Clients";
            this.lv_Clients.Size = new System.Drawing.Size(1148, 524);
            this.lv_Clients.TabIndex = 15;
            this.lv_Clients.UseCompatibleStateImageBehavior = false;
            this.lv_Clients.View = System.Windows.Forms.View.Details;
            this.lv_Clients.SelectedIndexChanged += new System.EventHandler(this.lv_Clients_SelectedIndexChanged);
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
            // NameClient
            // 
            this.NameClient.Text = "Nombre";
            this.NameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameClient.Width = 287;
            // 
            // Email
            // 
            this.Email.Text = "Correo";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 287;
            // 
            // Phone
            // 
            this.Phone.Text = "Teléfono";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 286;
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
            this.btn_AddForm.TabIndex = 16;
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
            this.btn_EditForm.TabIndex = 17;
            this.btn_EditForm.Text = "Edición";
            this.btn_EditForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditForm.UseVisualStyleBackColor = false;
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
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Clients_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1172, 641);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_EditForm);
            this.Controls.Add(this.btn_AddForm);
            this.Controls.Add(this.lv_Clients);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clients_List";
            this.Text = "Clients_List";
            this.Load += new System.EventHandler(this.Clients_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ListView lv_Clients;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader Rut;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Button btn_AddForm;
        private System.Windows.Forms.Button btn_EditForm;
        private System.Windows.Forms.Button btn_Delete;
    }
}