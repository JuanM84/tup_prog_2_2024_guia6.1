namespace Ejercicio_2
{
	partial class FormPrincipal
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.rbString = new System.Windows.Forms.RadioButton();
			this.rbRegex = new System.Windows.Forms.RadioButton();
			this.lbResultados = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbResultados);
			this.groupBox1.Controls.Add(this.rbRegex);
			this.groupBox1.Controls.Add(this.rbString);
			this.groupBox1.Controls.Add(this.btnProcesar);
			this.groupBox1.Location = new System.Drawing.Point(42, 17);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(723, 398);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Resultados";
			// 
			// btnProcesar
			// 
			this.btnProcesar.Location = new System.Drawing.Point(577, 40);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(113, 83);
			this.btnProcesar.TabIndex = 1;
			this.btnProcesar.Text = "Procesar";
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// rbString
			// 
			this.rbString.AutoSize = true;
			this.rbString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbString.Location = new System.Drawing.Point(596, 159);
			this.rbString.Name = "rbString";
			this.rbString.Size = new System.Drawing.Size(74, 24);
			this.rbString.TabIndex = 2;
			this.rbString.TabStop = true;
			this.rbString.Text = "String";
			this.rbString.UseVisualStyleBackColor = true;
			this.rbString.CheckedChanged += new System.EventHandler(this.rbString_CheckedChanged);
			// 
			// rbRegex
			// 
			this.rbRegex.AutoSize = true;
			this.rbRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbRegex.Location = new System.Drawing.Point(594, 219);
			this.rbRegex.Name = "rbRegex";
			this.rbRegex.Size = new System.Drawing.Size(79, 24);
			this.rbRegex.TabIndex = 3;
			this.rbRegex.TabStop = true;
			this.rbRegex.Text = "RegEx";
			this.rbRegex.UseVisualStyleBackColor = true;
			this.rbRegex.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
			// 
			// lbResultados
			// 
			this.lbResultados.FormattingEnabled = true;
			this.lbResultados.ItemHeight = 16;
			this.lbResultados.Location = new System.Drawing.Point(31, 21);
			this.lbResultados.Name = "lbResultados";
			this.lbResultados.Size = new System.Drawing.Size(491, 340);
			this.lbResultados.TabIndex = 4;
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormPrincipal";
			this.Text = "Intimaciones";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnProcesar;
		private System.Windows.Forms.RadioButton rbRegex;
		private System.Windows.Forms.RadioButton rbString;
		private System.Windows.Forms.ListBox lbResultados;
	}
}

