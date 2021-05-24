namespace ImpresosBernal.Ramificaciones
{
    partial class Crear_Jefe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Jefe));
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Image = global::ImpresosBernal.Properties.Resources.user;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(58, 109);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(139, 63);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Usuarios";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.Image = global::ImpresosBernal.Properties.Resources.rollo;
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(231, 109);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(139, 63);
            this.btnMaterial.TabIndex = 1;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaterial.UseVisualStyleBackColor = true;
            // 
            // btnTask
            // 
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.Image = global::ImpresosBernal.Properties.Resources.task;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(404, 109);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(139, 63);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Ordenes";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTask.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Que deseas crear?";
            // 
            // Crear_Jefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(600, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crear_Jefe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_Jefe";
            this.Load += new System.EventHandler(this.Crear_Jefe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Label label1;
    }
}