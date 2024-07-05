using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
	[Serializable]
	public class Desarollador : Empleado
	{
		//private double salario;
		//private int lineasDeCodigo;
		//private string puesto;

		//public int LineasDeCodigo { get => lineasDeCodigo; set => lineasDeCodigo = value; }

		public Desarollador()
		{

		}
		public Desarollador(int id, string nombre, string apellido, int edad, string puesto, int lineasDeCodigo, double salario) : base(id, nombre, apellido, edad)
		{
			//this.lineasDeCodigo = lineasDeCodigo;
			this.Puesto = puesto;
			this.Salario = SalarioBase(salario);
		}


		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(base.ToString());
			//sb.AppendLine($"Lineas de codigos: {this.lineasDeCodigo}");

			return sb.ToString();
		}

		protected override double SalarioBase(double salarioBase)
		{
			//return salarioBase + (this.lineasDeCodigo * 1.5f);
			return salarioBase;
		}
		//public override double Salario
		//{
		//	get => base.Salario;
		//	set
		//	{
		//		if (value < 0 || value >= 50000)
		//		{
		//			throw new ExceptionSalarioInvalido("Salario fuera de rango", value);
		//		}
		//		base.Salario = value;
		//	}
		//}




	}
}
