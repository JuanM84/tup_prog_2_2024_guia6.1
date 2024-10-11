using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
	public interface IProcesable
	{
		string Procesar(string patente, out string procesada);
	}
}
