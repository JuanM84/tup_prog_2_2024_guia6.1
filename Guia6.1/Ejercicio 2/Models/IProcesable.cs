﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Models
{
	public interface IProcesable
	{
		Intimacion Procesar(string contenido);
	}
}
