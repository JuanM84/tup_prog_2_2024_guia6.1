using Ejercicio_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
	public partial class FormPrincipal : Form
	{
		public FormPrincipal()
		{
			InitializeComponent();
		}

		private void btnProcesar_Click(object sender, EventArgs e)
		{
			string contenido = @"                                            Paraná, 20 de Diciembre de 2024
Sr(a) Medina Noemí, El despacho JURÍDICO GUTIERREZ & ASOCIADOS, mediante el
presente EXHORTO EXTRA JUDICIAL de  cobro se le Notifica:
Basados en el  en  el préstamo emitido por el corporativo LEANDRO KRUGER,
se ejecutará a las 16:00 horas del día 1 de enero del año 2024, UNA
DILIGENCIA DE RECUPERACIÓN DE CARTERA EN SU DOMICILIO, debido a la EVASIÓN 
DE PAGO consumada contra mi cliente, por el adeudo de su crédito por la
cantidad de $6.000,00 (seis mil pesos).
";

			IProcesable procesable = null;

			procesable = new ProcesoRegex();

			lbResultados.Items.Clear();

			Intimacion intimacion = procesable.Procesar(contenido);

			lbResultados.Items.Add($"Lugar de Emisión: {intimacion.LugarDeEmision}");
			lbResultados.Items.Add($"Fecha de Emisión: {intimacion.FechaDeEmision: dd/MM/yyyy}");
			lbResultados.Items.Add($"Demandado: Sra(a) {intimacion.PersonaDemandada}");
			lbResultados.Items.Add($"-------------------------------------------");
			lbResultados.Items.Add($"Estudio Juridico: {intimacion.EstudioJuridico}");
			lbResultados.Items.Add($"Demandante: {intimacion.PersonaDemandante}");
			lbResultados.Items.Add($"Fecha de Ejecución: {intimacion.FechaEjecucion: dd/MM/yyyy HH:mm} hs");
			lbResultados.Items.Add($"Monto: $ {intimacion.MontoAdeudado}");

		}

		private void rbString_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbRegex_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
