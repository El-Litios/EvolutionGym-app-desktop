
namespace EvolutionGym.View.Memberships
{
    partial class Memberships_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memberships_Add));
            this.lv_Clients = new System.Windows.Forms.ListView();
            this.tb_SearchField = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lv_SelectedClients = new System.Windows.Forms.ListView();
            this.Client_ID = new System.Windows.Forms.ColumnHeader();
            this.Client_Rut = new System.Windows.Forms.ColumnHeader();
            this.Client_FullName = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_ID = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_Rut = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_FullName = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_Email = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_Phone = new System.Windows.Forms.ColumnHeader();
            this.btn_DetailsForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Rut = new System.Windows.Forms.TextBox();
            this.dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lv_Clients
            // 
            this.lv_Clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(198)))));
            this.lv_Clients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_Clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client_ID,
            this.Client_Rut,
            this.Client_FullName});
            this.lv_Clients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_Clients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Clients.FullRowSelect = true;
            this.lv_Clients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Clients.HideSelection = false;
            this.lv_Clients.Location = new System.Drawing.Point(12, 56);
            this.lv_Clients.Name = "lv_Clients";
            this.lv_Clients.Size = new System.Drawing.Size(430, 434);
            this.lv_Clients.TabIndex = 18;
            this.lv_Clients.UseCompatibleStateImageBehavior = false;
            this.lv_Clients.View = System.Windows.Forms.View.Details;
            // 
            // tb_SearchField
            // 
            this.tb_SearchField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_SearchField.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_SearchField.ForeColor = System.Drawing.Color.Black;
            this.tb_SearchField.Location = new System.Drawing.Point(12, 20);
            this.tb_SearchField.MaxLength = 15;
            this.tb_SearchField.Name = "tb_SearchField";
            this.tb_SearchField.PlaceholderText = "Buscador";
            this.tb_SearchField.Size = new System.Drawing.Size(218, 30);
            this.tb_SearchField.TabIndex = 21;
            this.tb_SearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_Search.Location = new System.Drawing.Point(242, 20);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 30);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // lv_SelectedClients
            // 
            this.lv_SelectedClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(198)))));
            this.lv_SelectedClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_SelectedClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectedCLient_ID,
            this.SelectedCLient_Rut,
            this.SelectedCLient_FullName,
            this.SelectedCLient_Email,
            this.SelectedCLient_Phone});
            this.lv_SelectedClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lv_SelectedClients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_SelectedClients.FullRowSelect = true;
            this.lv_SelectedClients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_SelectedClients.HideSelection = false;
            this.lv_SelectedClients.Location = new System.Drawing.Point(558, 56);
            this.lv_SelectedClients.Name = "lv_SelectedClients";
            this.lv_SelectedClients.Size = new System.Drawing.Size(544, 434);
            this.lv_SelectedClients.TabIndex = 23;
            this.lv_SelectedClients.UseCompatibleStateImageBehavior = false;
            this.lv_SelectedClients.View = System.Windows.Forms.View.Details;
            // 
            // Client_ID
            // 
            this.Client_ID.Text = "ID";
            this.Client_ID.Width = 0;
            // 
            // Client_Rut
            // 
            this.Client_Rut.Text = "RUT";
            this.Client_Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Client_Rut.Width = 215;
            // 
            // Client_FullName
            // 
            this.Client_FullName.Text = "Nombre";
            this.Client_FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Client_FullName.Width = 215;
            // 
            // SelectedCLient_ID
            // 
            this.SelectedCLient_ID.Text = "ID";
            this.SelectedCLient_ID.Width = 0;
            // 
            // SelectedCLient_Rut
            // 
            this.SelectedCLient_Rut.Text = "RUT";
            this.SelectedCLient_Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectedCLient_Rut.Width = 136;
            // 
            // SelectedCLient_FullName
            // 
            this.SelectedCLient_FullName.Text = "Nombre";
            this.SelectedCLient_FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectedCLient_FullName.Width = 136;
            // 
            // SelectedCLient_Email
            // 
            this.SelectedCLient_Email.Text = "Correo";
            this.SelectedCLient_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectedCLient_Email.Width = 136;
            // 
            // SelectedCLient_Phone
            // 
            this.SelectedCLient_Phone.Text = "Teléfono";
            this.SelectedCLient_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SelectedCLient_Phone.Width = 136;
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
            this.btn_DetailsForm.Location = new System.Drawing.Point(464, 257);
            this.btn_DetailsForm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DetailsForm.Name = "btn_DetailsForm";
            this.btn_DetailsForm.Size = new System.Drawing.Size(76, 37);
            this.btn_DetailsForm.TabIndex = 24;
            this.btn_DetailsForm.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1180, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = " Fecha de Inicio";
            // 
            // tb_Rut
            // 
            this.tb_Rut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Rut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Rut.ForeColor = System.Drawing.Color.Black;
            this.tb_Rut.Location = new System.Drawing.Point(1124, 178);
            this.tb_Rut.MaxLength = 12;
            this.tb_Rut.Name = "tb_Rut";
            this.tb_Rut.Size = new System.Drawing.Size(239, 29);
            this.tb_Rut.TabIndex = 27;
            this.tb_Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dt_DateBegin
            // 
            this.dt_DateBegin.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dt_DateBegin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_DateBegin.Location = new System.Drawing.Point(1124, 80);
            this.dt_DateBegin.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dt_DateBegin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dt_DateBegin.Name = "dt_DateBegin";
            this.dt_DateBegin.Size = new System.Drawing.Size(239, 29);
            this.dt_DateBegin.TabIndex = 28;
            // 
            // Memberships_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1385, 539);
            this.Controls.Add(this.dt_DateBegin);
            this.Controls.Add(this.tb_Rut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DetailsForm);
            this.Controls.Add(this.lv_SelectedClients);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_SearchField);
            this.Controls.Add(this.lv_Clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Memberships_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Clients;
        private System.Windows.Forms.TextBox tb_SearchField;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ColumnHeader Client_ID;
        private System.Windows.Forms.ColumnHeader Client_Rut;
        private System.Windows.Forms.ColumnHeader Client_FullName;
        private System.Windows.Forms.ListView lv_SelectedClients;
        private System.Windows.Forms.ColumnHeader SelectedCLient_ID;
        private System.Windows.Forms.ColumnHeader SelectedCLient_Rut;
        private System.Windows.Forms.ColumnHeader SelectedCLient_FullName;
        private System.Windows.Forms.ColumnHeader SelectedCLient_Email;
        private System.Windows.Forms.ColumnHeader SelectedCLient_Phone;
        private System.Windows.Forms.Button btn_DetailsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Rut;
        private System.Windows.Forms.DateTimePicker dt_DateBegin;
    }
}