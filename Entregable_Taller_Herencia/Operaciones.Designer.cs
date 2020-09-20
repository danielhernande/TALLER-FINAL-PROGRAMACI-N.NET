namespace Entregable_Taller_Herencia
{
    partial class Operaciones
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
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.pbxsalir = new System.Windows.Forms.PictureBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPERACIONES MATEMÁTICAS.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(95, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "NÚMERO 1 :";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(272, 139);
            this.txtnumero1.Multiline = true;
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 54);
            this.txtnumero1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(95, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "NÚMERO 2 :";
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(272, 265);
            this.txtnumero2.Multiline = true;
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 54);
            this.txtnumero2.TabIndex = 5;
            // 
            // pbxsalir
            // 
            this.pbxsalir.Image = global::Entregable_Taller_Herencia.Properties.Resources.salir;
            this.pbxsalir.Location = new System.Drawing.Point(595, 378);
            this.pbxsalir.Name = "pbxsalir";
            this.pbxsalir.Size = new System.Drawing.Size(76, 43);
            this.pbxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxsalir.TabIndex = 9;
            this.pbxsalir.TabStop = false;
            this.pbxsalir.Click += new System.EventHandler(this.pbxsalir_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblresultado.Location = new System.Drawing.Point(239, 392);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(173, 29);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "RESULTADO.";
            this.lblresultado.Visible = false;
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnsuma.Location = new System.Drawing.Point(480, 127);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(45, 35);
            this.btnsuma.TabIndex = 11;
            this.btnsuma.Text = " +";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnresta.Location = new System.Drawing.Point(480, 184);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(45, 37);
            this.btnresta.TabIndex = 12;
            this.btnresta.Text = " -";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnmultiplicar.Location = new System.Drawing.Point(480, 245);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(45, 30);
            this.btnmultiplicar.TabIndex = 13;
            this.btnmultiplicar.Text = " * ";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btndividir.Location = new System.Drawing.Point(480, 309);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(45, 29);
            this.btndividir.TabIndex = 14;
            this.btndividir.Text = " /";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.pbxsalir);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.pbxsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.PictureBox pbxsalir;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
    }
}