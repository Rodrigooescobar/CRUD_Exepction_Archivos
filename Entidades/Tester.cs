using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Tester : Empleado
	{
		private double salario;
		public Tester()
		{

		}

		protected override double SalarioBase(double salarioBase)
		{
			throw new NotImplementedException();
		}
	}
}
