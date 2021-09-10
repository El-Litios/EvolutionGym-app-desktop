
namespace EvolutionGym.View.Users
{
    partial class Users_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Rut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FatherLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MotherLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut:";
            // 
            // tb_Rut
            // 
            this.tb_Rut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Rut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Rut.ForeColor = System.Drawing.Color.Black;
            this.tb_Rut.Location = new System.Drawing.Point(62, 34);
            this.tb_Rut.MaxLength = 12;
            this.tb_Rut.Name = "tb_Rut";
            this.tb_Rut.Size = new System.Drawing.Size(239, 29);
            this.tb_Rut.TabIndex = 12;
            this.tb_Rut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(143, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_Name.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Name.ForeColor = System.Drawing.Color.Black;
            this.tb_Name.Location = new System.Drawing.Point(62, 117);
            this.tb_Name.MaxLength = 12;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(239, 29);
            this.tb_Name.TabIndex = 14;
            this.tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(110, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido Paterno:";
            // 
            // tb_FatherLastName
            // 
            this.tb_FatherLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_FatherLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_FatherLastName.ForeColor = System.Drawing.Color.Black;
            this.tb_FatherLastName.Location = new System.Drawing.Point(62, 202);
            this.tb_FatherLastName.MaxLength = 12;
            this.tb_FatherLastName.Name = "tb_FatherLastName";
            this.tb_FatherLastName.Size = new System.Drawing.Size(239, 29);
            this.tb_FatherLastName.TabIndex = 16;
            this.tb_FatherLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(105, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellido Materno:";
            // 
            // tb_MotherLastName
            // 
            this.tb_MotherLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_MotherLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_MotherLastName.ForeColor = System.Drawing.Color.Black;
            this.tb_MotherLastName.Location = new System.Drawing.Point(62, 286);
            this.tb_MotherLastName.MaxLength = 12;
            this.tb_MotherLastName.Name = "tb_MotherLastName";
            this.tb_MotherLastName.Size = new System.Drawing.Size(239, 29);
            this.tb_MotherLastName.TabIndex = 19;
            this.tb_MotherLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(148, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Usuario:";
            // 
            // tb_User
            // 
            this.tb_User.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_User.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_User.ForeColor = System.Drawing.Color.Black;
            this.tb_User.Location = new System.Drawing.Point(62, 370);
            this.tb_User.MaxLength = 12;
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(239, 29);
            this.tb_User.TabIndex = 21;
            this.tb_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(145)))));
            this.btn_EditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_EditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.btn_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EditUser.ForeColor = System.Drawing.Color.Black;
            this.btn_EditUser.Location = new System.Drawing.Point(62, 540);
            this.btn_EditUser.Margin = new System.Windows.Forms.Padding(0);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(239, 51);
            this.btn_EditUser.TabIndex = 24;
            this.btn_EditUser.Text = "GUARDAR CAMBIOS";
            this.btn_EditUser.UseVisualStyleBackColor = false;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // cb_Role
            // 
            this.cb_Role.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Role.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_Role.ForeColor = System.Drawing.Color.Black;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(62, 454);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(239, 23);
            this.cb_Role.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(165, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Rol:";
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // Users_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(353, 605);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_Role);
            this.Controls.Add(this.btn_EditUser);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_MotherLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_FatherLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Rut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users_Edit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Rut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FatherLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MotherLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider Error;
    }
}