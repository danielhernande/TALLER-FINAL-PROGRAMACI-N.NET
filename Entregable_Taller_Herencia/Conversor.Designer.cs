namespace Entregable_Taller_Herencia
{
    partial class Conversor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkilos = new System.Windows.Forms.TextBox();
            this.btnmiligramos = new System.Windows.Forms.Button();
            this.btngramos = new System.Windows.Forms.Button();
            this.btndecagramos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.pbxsalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(116, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSOR DE TEMPERATURA.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(28, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el peso en Kilogramos que desea convertir:";
            // 
            // txtkilos
            // 
            this.txtkilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkilos.Location = new System.Drawing.Point(467, 152);
            this.txtkilos.MaxLength = 10;
            this.txtkilos.Multiline = true;
            this.txtkilos.Name = "txtkilos";
            this.txtkilos.Size = new System.Drawing.Size(151, 54);
            this.txtkilos.TabIndex = 2;
            // 
            // btnmiligramos
            // 
            this.btnmiligramos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnmiligramos.Location = new System.Drawing.Point(70, 305);
            this.btnmiligramos.Name = "btnmiligramos";
            this.btnmiligramos.Size = new System.Drawing.Size(104, 39);
            this.btnmiligramos.TabIndex = 3;
            this.btnmiligramos.Text = "Miligramos";
            this.btnmiligramos.UseVisualStyleBackColor = true;
            this.btnmiligramos.Click += new System.EventHandler(this.btnmiligramos_Click);
            // 
            // btngramos
            // 
            this.btngramos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btngramos.Location = new System.Drawing.Point(211, 305);
            this.btngramos.Name = "btngramos";
            this.btngramos.Size = new System.Drawing.Size(101, 39);
            this.btngramos.TabIndex = 4;
            this.btngramos.Text = "Gramos";
            this.btngramos.UseVisualStyleBackColor = true;
            this.btngramos.Click += new System.EventHandler(this.btngramos_Click);
            // 
            // btndecagramos
            // 
            this.btndecagramos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btndecagramos.Location = new System.Drawing.Point(349, 305);
            this.btndecagramos.Name = "btndecagramos";
            this.btndecagramos.Size = new System.Drawing.Size(117, 39);
            this.btndecagramos.TabIndex = 5;
            this.btndecagramos.Text = "Decagramos";
            this.btndecagramos.UseVisualStyleBackColor = true;
            this.btndecagramos.Click += new System.EventHandler(this.btndecagramos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(240, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONVERTIR A :";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblresultado.Location = new System.Drawing.Point(538, 307);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(173, 29);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "RESULTADO.";
            this.lblresultado.Visible = false;
            // 
            // pbxsalir
            // 
            this.pbxsalir.Image = global::Entregable_Taller_Herencia.Properties.Resources.salir;
            this.pbxsalir.Location = new System.Drawing.Point(658, 389);
            this.pbxsalir.Name = "pbxsalir";
            this.pbxsalir.Size = new System.Drawing.Size(76, 43);
            this.pbxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxsalir.TabIndex = 8;
            this.pbxsalir.TabStop = false;
            this.pbxsalir.Click += new System.EventHandler(this.pbxsalir_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxsalir);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndecagramos);
            this.Controls.Add(this.btngramos);
            this.Controls.Add(this.btnmiligramos);
            this.Controls.Add(this.txtkilos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conversor";
            this.Text = "Conversor";
            ((System.ComponentModel.ISupportInitialize)(this.pbxsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkilos;
        private System.Windows.Forms.Button btnmiligramos;
        private System.Windows.Forms.Button btngramos;
        private System.Windows.Forms.Button btndecagramos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.PictureBox pbxsalir;
    }
}