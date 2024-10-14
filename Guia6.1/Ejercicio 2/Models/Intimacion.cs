using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
	public class Intimacion
	{
		public string LugarDeEmision { get; set;}
		public DateTime FechaDeEmision { get; set;}
		public string PersonaDemandada { get; set;}
		public string EstudioJuridico { get; set;}
		public string PersonaDemandante {  get; set;} 
		public DateTime FechaEjecucion { get; set;}
		public double MontoAdeudado { get; set;}

	}
}
