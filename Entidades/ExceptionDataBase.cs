using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class ExceptionDataBase
	{
		string mensaje;
		public ExceptionDataBase(string mensaje)
		{
			LogExcepcion();
			this.mensaje = mensaje;
		}

		private void LogExcepcion()
		{
			string filePath = "../../../../Exepciones/log.txt";

			using (StreamWriter writer = new StreamWriter(filePath, true))
			{
				writer.WriteLine($"{DateTime.Now}: Exception: {this.mensaje}");
			}
		}
	}
}
