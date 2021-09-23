
namespace EvolutionGym.View.Memberships
{
    partial class Memberships_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memberships_List));
            this.lv_Membership = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Rut = new System.Windows.Forms.ColumnHeader();
            this.NameClient = new System.Windows.Forms.ColumnHeader();
            this.DateBegin = new System.Windows.Forms.ColumnHeader();
            this.DateEnd = new System.Windows.Forms.ColumnHeader();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_SearchField = new System.Windows.Forms.TextBox();
            this.btn_AddForm = new System.Windows.Forms.Button();
            this.btn_DetailsForm = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Membership
            // 
            this.lv_Membership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(153)))));
            this.lv_Membership.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Membership.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Rut,
            this.NameClient,
            this.DateBegin,
            this.DateEnd});
            this.lv_Membership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_Membership.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Membership.FullRowSelect = true;
            this.lv_Membership.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Membership.HideSelection = false;
            this.lv_Membership.Location = new System.Drawing.Point(12, 48);
            this.lv_Membership.Name = "lv_Membership";
            this.lv_Membership.Size = new System.Drawing.Size(1148, 524);
            this.lv_Membership.TabIndex = 17;
            this.lv_Membership.UseCompatibleStateImageBehavior = false;
            this.lv_Membership.View = System.Windows.Forms.View.Details;
            this.lv_Membership.SelectedIndexChanged += new System.EventHandler(this.lv_Membership_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.Width = 52;
            // 
            // Rut
            // 
            this.Rut.Text = "Rut";
            this.Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rut.Width = 274;
            // 
            // NameClient
            // 
            this.NameClient.Text = "Nombre";
            this.NameClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameClient.Width = 287;
            // 
            // DateBegin
            // 
            this.DateBegin.Text = "Fecha de Inicio";
            this.DateBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateBegin.Width = 287;
            // 
            // DateEnd
            // 
            this.DateEnd.Text = "Fecha Fin";
            this.DateEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateEnd.Width = 286;
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
            this.btn_Search.TabIndex = 19;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.tb_SearchField.TabIndex = 20;
            this.tb_SearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_SearchField.TextChanged += new System.EventHandler(this.tb_SearchField_TextChanged);
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
            this.btn_AddForm.TabIndex = 21;
            this.btn_AddForm.Text = "Agregar";
            this.btn_AddForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddForm.UseVisualStyleBackColor = false;
            this.btn_AddForm.Click += new System.EventHandler(this.btn_AddForm_Click);
            // 
            // btn_DetailsForm
            // 
            this.btn_DetailsForm.BackColor = System.Drawing.Color.LightGray;
            this.btn_DetailsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DetailsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DetailsForm.Enabled = false;
            this.btn_DetailsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DetailsForm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DetailsForm.ForeColor = System.Drawing.Color.Black;
            this.btn_DetailsForm.Image = ((System.Drawing.Image)(resources.GetObject("btn_DetailsForm.Image")));
            this.btn_DetailsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DetailsForm.Location = new System.Drawing.Point(143, 584);
            this.btn_DetailsForm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DetailsForm.Name = "btn_DetailsForm";
            this.btn_DetailsForm.Size = new System.Drawing.Size(121, 37);
            this.btn_DetailsForm.TabIndex = 22;
            this.btn_DetailsForm.Text = "Detalles";
            this.btn_DetailsForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DetailsForm.UseVisualStyleBackColor = false;
            this.btn_DetailsForm.Click += new System.EventHandler(this.btn_DetailsForm_Click);
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
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Memberships_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 641);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_DetailsForm);
            this.Controls.Add(this.btn_AddForm);
            this.Controls.Add(this.tb_SearchField);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lv_Membership);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Memberships_List";
            this.Text = "Memberships_List";
            this.Load += new System.EventHandler(this.Memberships_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Membership;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Rut;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader UserUser;
        private System.Windows.Forms.ColumnHeader DateEnd;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_SearchField;
        private System.Windows.Forms.ColumnHeader DateBegin;
        private System.Windows.Forms.Button btn_AddForm;
        private System.Windows.Forms.Button btn_DetailsForm;
        private System.Windows.Forms.Button btn_Delete;
    }
}