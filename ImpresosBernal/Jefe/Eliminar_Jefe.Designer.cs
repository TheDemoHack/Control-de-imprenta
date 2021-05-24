namespace ImpresosBernal.Jefe
{
    partial class Eliminar_Jefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_Jefe));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿Que deseas eliminar?";
            // 
            // btnTask
            // 
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.Image = global::ImpresosBernal.Properties.Resources.task;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(396, 100);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(139, 63);
            this.btnTask.TabIndex = 6;
            this.btnTask.Text = "Ordenes";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTask.UseVisualStyleBackColor = true;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.Image = global::ImpresosBernal.Properties.Resources.rollo;
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(223, 100);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(139, 63);
            this.btnMaterial.TabIndex = 5;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaterial.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = global::ImpresosBernal.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(50, 100);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(139, 63);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "Usuarios";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // Eliminar_Jefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminar_Jefe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar_Jefe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnUser;
    }
}