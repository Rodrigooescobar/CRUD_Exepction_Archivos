using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class ExceptionSalarioInvalido : Exception
	{
		private double? valor;

		public double? Valor { get => valor; set => valor = value; }

		public ExceptionSalarioInvalido(string mensaje, double valor) : base(mensaje)
		{
			this.valor = valor;
			LogExepction();
		}

		private void LogExepction()
		{
			string filePath = "../../../../Exepciones/log.txt";
			// StreamWriter es una clase que me permite generar un string de dato contra un archivo
			using (StreamWriter writer = new StreamWriter(filePath, true))
			{
				writer.WriteLine($"{DateTime.Now}: Exception: {this.Message}. valor: {this.valor}");
			}
		}
	}
}
