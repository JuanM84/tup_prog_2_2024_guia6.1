using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
	public class ProcesoString : IProcesable
	{
		public string Procesar(string patente, out string procesada)
		{
			string patenteNormalizada = patente.Replace("-", "").Replace(" ", "").ToUpper();

			bool isHasta2016 = patenteNormalizada.Length == 6;
			bool isAcoplado = patenteNormalizada.Length == 6;
			bool isDesde2016 = patenteNormalizada.Length == 7;
			bool isMotocicleta = patenteNormalizada.Length == 8;

			// Hasta a 2016
			for (int n = 0; n < patenteNormalizada.Length && isHasta2016; n++)
			{
				char d = patenteNormalizada[n];
				isHasta2016 &= (char.IsLetter(d) && n < 3 || (char.IsNumber(d) && n < 6 && n >= 3));
			}

			if (isHasta2016)
			{
				procesada = patenteNormalizada;
				return "Automoviles y Camionetas hasta 2016";
			}

			// Posteriores a 2016
			for (int n = 0; n < patenteNormalizada.Length && isDesde2016; n++)
			{
				char d = patenteNormalizada[n];
				isDesde2016 &= (char.IsLetter(d) && n < 2) ||
					(char.IsNumber(d) && n < 5 && n >= 2) ||
					(char.IsLetter(d) && n < 7 && n >= 5);
			}
			if (isDesde2016)
			{
				procesada = patenteNormalizada;
				return "Automoviles y Camionetas desde 2016";
			}

			// Motocicleta
			for (int n = 0; n < patenteNormalizada.Length && isMotocicleta; n++)
			{
				char d = patenteNormalizada[n];
				isMotocicleta &= (char.IsLetter(d) && n < 2) ||
					(char.IsNumber(d) && n < 5 && n >= 2) ||
					(char.IsLetter(d) && n < 8 && n <= 5);
			}
			if (isMotocicleta)
			{
				procesada = patenteNormalizada;
				return "Motocicleta";
			}

			// Acoplados
			for (int n = 0; n < patenteNormalizada.Length && isAcoplado; n++)
			{
				char d = patenteNormalizada[n];
				isAcoplado &= (char.IsLetter(d) && n < 2 || (char.IsNumber(d) && n < 6 && n >= 2));
			}

			if (isAcoplado)
			{
				procesada = patenteNormalizada;
				return "Acoplado";
			}

			// Caso de No cumplir con ninguna de los casos
			procesada = "";
			return $"No reconocido {patente}";

		}

	}
}