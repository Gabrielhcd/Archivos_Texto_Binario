namespace Archivos_Texto_Binario
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.oFD1 = new System.Windows.Forms.OpenFileDialog();
			this.sFD1 = new System.Windows.Forms.SaveFileDialog();
			this.btnselecBMP = new System.Windows.Forms.Button();
			this.txtCaractBMP = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// oFD1
			// 
			this.oFD1.FileName = "openFileDialog1";
			// 
			// btnselecBMP
			// 
			this.btnselecBMP.Location = new System.Drawing.Point(12, 12);
			this.btnselecBMP.Name = "btnselecBMP";
			this.btnselecBMP.Size = new System.Drawing.Size(106, 56);
			this.btnselecBMP.TabIndex = 0;
			this.btnselecBMP.Text = "Seleccionar BMP";
			this.btnselecBMP.UseVisualStyleBackColor = true;
			this.btnselecBMP.Click += new System.EventHandler(this.btnselecBMP_Click);
			// 
			// txtCaractBMP
			// 
			this.txtCaractBMP.Location = new System.Drawing.Point(145, 12);
			this.txtCaractBMP.Multiline = true;
			this.txtCaractBMP.Name = "txtCaractBMP";
			this.txtCaractBMP.Size = new System.Drawing.Size(188, 161);
			this.txtCaractBMP.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 485);
			this.Controls.Add(this.txtCaractBMP);
			this.Controls.Add(this.btnselecBMP);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog oFD1;
		private System.Windows.Forms.SaveFileDialog sFD1;
		private System.Windows.Forms.Button btnselecBMP;
		private System.Windows.Forms.TextBox txtCaractBMP;
	}
}

