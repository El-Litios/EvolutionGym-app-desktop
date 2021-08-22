
namespace EvolutionGym
{
    partial class SuccessMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuccessMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operación realizada exitosamente.";
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.LightGray;
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(179)))), ((int)(((byte)(30)))));
            this.btn_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accept.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Accept.ForeColor = System.Drawing.Color.Black;
            this.btn_Accept.Location = new System.Drawing.Point(262, 105);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(112, 30);
            this.btn_Accept.TabIndex = 16;
            this.btn_Accept.Text = "Aceptar";
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // SuccessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 147);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessMessage";
            this.Text = "SuccessMessage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Accept;
    }
}