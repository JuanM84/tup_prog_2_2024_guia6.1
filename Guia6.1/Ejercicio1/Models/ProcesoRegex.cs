using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
	public class ProcesoRegex : IProcesable
	{
		public string Procesar(string patente, out string procesada)
		{
			Match match = null;
			procesada = "";

			// Casos de Expresiones Regulares
			// Caso Base
			string caso = $"No reconocido {patente}";
			// Hasta a 2016
			match = Regex.Match(patente, @"^[A-Z]{3}[\s-]*\d{3}$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				procesada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
				caso = "Automoviles y Camionetas hasta 2016";
			}
			// Posteriores a 2016
			match = Regex.Match(patente, @"^[A-Z]{2}\s*\d{3}\s*[A-Z]{2}$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				procesada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
				caso = "Automoviles y Camionetas desde 2016";
			}
			// Motocicletas
			match = Regex.Match(patente, @"^[A-Z]{2}\s*\d{3}\s*[A-Z]{3}$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				procesada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
				caso = "Motocicletas";
			}
			// Acoplados
			match = Regex.Match(patente, @"^[A-Z]{2}\s*\d{4}$", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				procesada = match.Value.Replace(" ", "").Replace("-", "").ToUpper();
				caso = "Acoplados";
			}
			return caso;
		}
	}
}

