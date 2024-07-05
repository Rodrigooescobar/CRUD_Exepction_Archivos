using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
	[Serializable]
	[XmlInclude(typeof(Desarollador))]
	public abstract class Empleado
	{
		private int id;
		private string nombre;
		private string apellido;
		private string? puesto;
		private int edad;
		private double? salario;

		public int Id { get => id; set => id = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public string Apellido { get => apellido; set => apellido = value; }
		public string Puesto { get => puesto; set => puesto = value; }
		public double? Salario
		{
			get => salario;
			set
			{
				if (value < 0 || value >= 50000)
				{
					throw new ExceptionSalarioInvalido("Salario fuera de rango", value.Value);
				}
				salario = value;
			}
		}

		protected abstract double SalarioBase(double salarioBase);

		public int Edad { get => edad; set => edad = value; }

		public Empleado()
		{

		}

		public Empleado(int id, string nombre, string apellido, int edad):this()
		{
			this.id = id;
			this.nombre = nombre;
			this.apellido = apellido;
			this.edad = edad;
		}
		

		//public virtual double SalarioBase(double salarioBase)
		//{
		//	salario = salarioBase;

		//	return salario;
		//}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"Nombre: {this.nombre}");
			stringBuilder.AppendLine($"Apellido: {this.apellido}");
			stringBuilder.AppendLine($"Puesto: {this.puesto}");

			return stringBuilder.ToString();
		}

		#region Sobrcarga de Operador ==
		// sobrecarga de operador ==
		public static bool operator ==(Empleado a, Empleado b)
		{
			bool esIgual;
			esIgual = false;
			if (a.id == b.id && a.apellido == b.apellido)
			{
				esIgual = true;
			}
			return esIgual;
		}

		public static bool operator !=(Empleado a, Empleado b)
		{
			return !(a == b);
		}
		#endregion
	}
}
