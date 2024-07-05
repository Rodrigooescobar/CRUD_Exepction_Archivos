using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Empresa 
	{
		#region Atributos
		private List<Empleado> empleados;
		private Dictionary<int, Empleado> diccionarioEmpleados;
		private Stack<Empleado> pilaEmpleados;
		private static DateTime inicioActividades;
		private string nombre;
		#endregion

		#region Propiedades
		internal List<Empleado> Empleados { get => empleados; set => empleados = value; }
		internal Dictionary<int, Empleado> DiccionarioEmpleados { get => diccionarioEmpleados; set => diccionarioEmpleados = value; }
		internal Stack<Empleado> PilaEmpleados { get => pilaEmpleados; set => pilaEmpleados = value; }
		public static DateTime InicioActividades { get => inicioActividades; set => inicioActividades = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		#endregion

		#region Constructores
		static Empresa()
		{
			inicioActividades = DateTime.Now;
		}

		public Empresa(string nombre) : this()
		{
			this.nombre = nombre;
		}

		// inicializo las listas
		private Empresa()
		{
			empleados = new List<Empleado>();
			diccionarioEmpleados = new Dictionary<int, Empleado>();
			pilaEmpleados = new Stack<Empleado>();
		}
		#endregion

		#region Metodos
		// creo el metodo bool para que me devuelva true o false
		public bool AgregarEmpleado(Empleado empleado) // reemplazar por eventos
		{
			bool agrego;
			agrego = false;

			// negamos asi si encuentra devuelve false
			if (!BuscarEmpleado(empleado))
			{
				this.empleados.Add(empleado);
				// forma 1 de añadir a un dic
				this.diccionarioEmpleados.Add(empleado.Id, empleado);
				this.pilaEmpleados.Push(empleado);
				agrego = true;
			}

			return agrego;
		}

		private bool BuscarEmpleado(Empleado empleado)
		{
			bool existe;
			existe = false;

			//usamos sobrecarga ==
			foreach (Empleado unEmpleado in this.empleados)
			{
				if (unEmpleado == empleado)
				{
					existe = true;
					break;
				}
			}
			return existe;
		}
		//public bool Serializar()
		//{
		//	throw new NotImplementedException();
		//}

		//public bool Deserializar()
		//{
		//	throw new NotImplementedException();
		//}
		#endregion

		

	}
}
