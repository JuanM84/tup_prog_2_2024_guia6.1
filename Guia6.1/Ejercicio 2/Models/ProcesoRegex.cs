using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ejercicio_2.Models
{
	public class ProcesoRegex : IProcesable
	{
		
		public Intimacion Procesar(string contenido) 
		{
			Intimacion intimacionDePago = new Intimacion();
			// Scrapping
			//Lugar de Emisión
			Match m = Regex.Match(contenido, @"^\s+\w*");
			if (m.Success) 
			{
				intimacionDePago.LugarDeEmision= m.Value.Trim();
			}
			//Fecha de Emisión
			m = Regex.Match(contenido, @"([0-9]{1,2}) de ([a-zA-Z]+) de ([0-9]{1,4})");
			if (m.Success)
			{
				string fechaEm = $"{m.Groups[1].Value},{m.Groups[2].Value},{m.Groups[3].Value}";
				string formatoEm = "dd,MMMM,yyyy";
				DateTime fechaEmision = DateTime.ParseExact(fechaEm, formatoEm, CultureInfo.CurrentCulture);
				intimacionDePago.FechaDeEmision = fechaEmision;
			}
			// Demandando
			m = Regex.Match(contenido, @"(Sr\(a\))([ a-zA-Záéíóú]+)");
			if (m.Groups.Count > 1) 
			{
				intimacionDePago.PersonaDemandada = m.Groups[2].Value;
			}
			// Estudio Jurídico
			m = Regex.Match(contenido, @"(despacho)([ a-zA-ZáéíóúÁÉÍÓÚ&]+)");
			if (m.Groups.Count > 1)
			{
				intimacionDePago.EstudioJuridico = m.Groups[2].Value;
			}
			// Demandante
			m = Regex.Match(contenido, @"(corporativo)([ a-zA-ZáéíóúÁÉÍÓÚ&]+)");
			if (m.Groups.Count > 1)
			{
				intimacionDePago.PersonaDemandante = m.Groups[2].Value;
			}
			// Fecha de Ejecución
			m = Regex.Match(contenido, @"(a las) ([0-9]{1,2}):([0-9]{1,2})( horas del día )([0-9]{1,2}) de ([a-zA-Z]+) del año ([0-9]{1,4})");
			if (m.Groups.Count > 1)
			{
				string fechaEj = $"{m.Groups[5].Value},{m.Groups[6].Value},{m.Groups[7].Value},{m.Groups[2].Value}:{m.Groups[3].Value}";
				string formatoEj = "d,MMMM,yyyy,HH:mm";
				DateTime fechaEjecucion = DateTime.ParseExact(fechaEj, formatoEj, CultureInfo.CurrentCulture);
				intimacionDePago.FechaEjecucion = fechaEjecucion;
			}
			// Monto Adeudado
			m = Regex.Match(contenido, @"(\$)([0-9\.]+)");
			if (m.Groups.Count > 1)
			{
				intimacionDePago.MontoAdeudado = Convert.ToDouble(m.Groups[2].Value);
			}
			return intimacionDePago;
		} 
	}
}
