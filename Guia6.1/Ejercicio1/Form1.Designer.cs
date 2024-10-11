namespace Ejercicio1
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnProcesar = new System.Windows.Forms.Button();
			this.rbString = new System.Windows.Forms.RadioButton();
			this.rbRegex = new System.Windows.Forms.RadioButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Resultados";
			// 
			// btnProcesar
			// 
			this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcesar.Location = new System.Drawing.Point(630, 51);
			this.btnProcesar.Name = "btnProcesar";
			this.btnProcesar.Size = new System.Drawing.Size(131, 67);
			this.btnProcesar.TabIndex = 2;
			this.btnProcesar.Text = "Procesar";
			this.btnProcesar.UseVisualStyleBackColor = true;
			this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
			// 
			// rbString
			// 
			this.rbString.AutoSize = true;
			this.rbString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbString.Location = new System.Drawing.Point(658, 147);
			this.rbString.Name = "rbString";
			this.rbString.Size = new System.Drawing.Size(74, 24);
			this.rbString.TabIndex = 3;
			this.rbString.TabStop = true;
			this.rbString.Text = "String";
			this.rbString.UseVisualStyleBackColor = true;
			// 
			// rbRegex
			// 
			this.rbRegex.AutoSize = true;
			this.rbRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbRegex.Location = new System.Drawing.Point(656, 200);
			this.rbRegex.Name = "rbRegex";
			this.rbRegex.Size = new System.Drawing.Size(79, 24);
			this.rbRegex.TabIndex = 4;
			this.rbRegex.TabStop = true;
			this.rbRegex.Text = "RegEx";
			this.rbRegex.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(37, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(539, 324);
			this.listBox1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rbRegex);
			this.Controls.Add(this.rbString);
			this.Controls.Add(this.btnProcesar);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Ejercicio 1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnProcesar;
		public System.Windows.Forms.RadioButton rbString;
		public System.Windows.Forms.RadioButton rbRegex;
		public System.Windows.Forms.ListBox listBox1;
	}
}

