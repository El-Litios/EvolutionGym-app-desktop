
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memberships_Add));
            this.lv_Clients = new System.Windows.Forms.ListView();
            this.Client_ID = new System.Windows.Forms.ColumnHeader();
            this.Client_Rut = new System.Windows.Forms.ColumnHeader();
            this.Client_FullName = new System.Windows.Forms.ColumnHeader();
            this.tb_SearchField = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lv_SelectedClients = new System.Windows.Forms.ListView();
            this.SelectedCLient_ID = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_Rut = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_FullName = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_Email = new System.Windows.Forms.ColumnHeader();
            this.SelectedCLient_Phone = new System.Windows.Forms.ColumnHeader();
            this.btn_AddToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_DateBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_TypeMembership = new System.Windows.Forms.ComboBox();
            this.num_MembershipCost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_PaymentMethod = new System.Windows.Forms.ComboBox();
            this.btn_AddMembership = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_MembershipCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Clients
            // 
            this.lv_Clients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
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
            this.lv_Clients.SelectedIndexChanged += new System.EventHandler(this.lv_Clients_SelectedIndexChanged);
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
            this.btn_Search.Location = new System.Drawing.Point(242, 20);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 30);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lv_SelectedClients
            // 
            this.lv_SelectedClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(157)))));
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
            // btn_AddToList
            // 
            this.btn_AddToList.BackColor = System.Drawing.Color.LightGray;
            this.btn_AddToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddToList.Enabled = false;
            this.btn_AddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddToList.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddToList.ForeColor = System.Drawing.Color.Black;
            this.btn_AddToList.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddToList.Image")));
            this.btn_AddToList.Location = new System.Drawing.Point(463, 257);
            this.btn_AddToList.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddToList.Name = "btn_AddToList";
            this.btn_AddToList.Size = new System.Drawing.Size(76, 37);
            this.btn_AddToList.TabIndex = 24;
            this.btn_AddToList.UseVisualStyleBackColor = false;
            this.btn_AddToList.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1178, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = " Fecha de Inicio:";
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
            this.dt_DateBegin.Value = new System.DateTime(2021, 9, 17, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1216, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1192, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo de Cupo:";
            // 
            // cb_TypeMembership
            // 
            this.cb_TypeMembership.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_TypeMembership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TypeMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TypeMembership.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_TypeMembership.ForeColor = System.Drawing.Color.Black;
            this.cb_TypeMembership.FormattingEnabled = true;
            this.cb_TypeMembership.Location = new System.Drawing.Point(1124, 162);
            this.cb_TypeMembership.Name = "cb_TypeMembership";
            this.cb_TypeMembership.Size = new System.Drawing.Size(239, 30);
            this.cb_TypeMembership.TabIndex = 31;
            // 
            // num_MembershipCost
            // 
            this.num_MembershipCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num_MembershipCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_MembershipCost.Location = new System.Drawing.Point(1124, 244);
            this.num_MembershipCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_MembershipCost.Name = "num_MembershipCost";
            this.num_MembershipCost.Size = new System.Drawing.Size(239, 29);
            this.num_MembershipCost.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1172, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Método de Pago:";
            // 
            // cb_PaymentMethod
            // 
            this.cb_PaymentMethod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_PaymentMethod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_PaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.cb_PaymentMethod.FormattingEnabled = true;
            this.cb_PaymentMethod.Location = new System.Drawing.Point(1124, 326);
            this.cb_PaymentMethod.Name = "cb_PaymentMethod";
            this.cb_PaymentMethod.Size = new System.Drawing.Size(239, 30);
            this.cb_PaymentMethod.TabIndex = 34;
            // 
            // btn_AddMembership
            // 
            this.btn_AddMembership.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.btn_AddMembership.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AddMembership.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddMembership.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.btn_AddMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMembership.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddMembership.ForeColor = System.Drawing.Color.Black;
            this.btn_AddMembership.Location = new System.Drawing.Point(1124, 439);
            this.btn_AddMembership.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddMembership.Name = "btn_AddMembership";
            this.btn_AddMembership.Size = new System.Drawing.Size(239, 51);
            this.btn_AddMembership.TabIndex = 35;
            this.btn_AddMembership.Text = "GUARDAR";
            this.btn_AddMembership.UseVisualStyleBackColor = false;
            this.btn_AddMembership.Click += new System.EventHandler(this.btn_AddMembership_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Memberships_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1385, 539);
            this.Controls.Add(this.btn_AddMembership);
            this.Controls.Add(this.cb_PaymentMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_MembershipCost);
            this.Controls.Add(this.cb_TypeMembership);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_DateBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddToList);
            this.Controls.Add(this.lv_SelectedClients);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_SearchField);
            this.Controls.Add(this.lv_Clients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Memberships_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Memberships_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_MembershipCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
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
        private System.Windows.Forms.Button btn_AddToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_DateBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_TypeMembership;
        private System.Windows.Forms.NumericUpDown num_MembershipCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_PaymentMethod;
        private System.Windows.Forms.Button btn_AddMembership;
        private System.Windows.Forms.ErrorProvider Error;
    }
}