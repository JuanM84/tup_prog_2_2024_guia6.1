using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnProcesar_Click(object sender, EventArgs e)
		{
			List<string> patentes = new List<string>
			{
				"OXY333", "OYZ 013", "AAA 123", "BCD-456", "AB 123 CD", "YZ5432EF", "QW 3456 AB"
			};

			IProcesable procesar = null;
			listBox1.Items.Clear();

			if (rbString.Checked)
			{
				procesar = new ProcesoString();
				listBox1.Items.Add("Procesado via Strings");
			}
			else if (rbRegex.Checked)
			{
				procesar = new ProcesoRegex();
				listBox1.Items.Add("Procesado via RegEx");
			}
			else 
			{
				MessageBox.Show("Debe seleccionar una opción");
				return;
			}
			
			foreach (string patente in patentes)
			{
				string linea = procesar.Procesar(patente, out string patenteProcesada);
				listBox1.Items.Add(patente + " - " + linea);
			}
		}
	}
}
