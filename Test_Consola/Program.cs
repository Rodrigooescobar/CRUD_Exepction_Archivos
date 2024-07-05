using DataBase;
using Entidades;
using System.Reflection.PortableExecutable;

namespace Test_Consola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Empleado> empleados = new List<Empleado>();
			//Desarollador d1 = new Desarollador(1, "juan", "perez", 50, "senior", 10, 500);

			//Desarollador nuevoDesarrollador = new Desarollador
			//{
			//	Id = 1,
			//	Nombre = "Juan",
			//	Apellido = "Pérez",
			//	Edad = 30,
			//	Puesto = "Desarrollador",
			//	Salario = 40000,
			//	LineasDeCodigo = 1500
			//};
   //         Console.WriteLine(nuevoDesarrollador);

            //empleados.Add(d1);

			foreach (Empleado empleado in empleados)
			{
				Console.WriteLine(empleado.ToString());
                Console.WriteLine(empleado.Salario);
            }

            Console.WriteLine("*****************************************");

			Empresa miEmpresa = new Empresa("UTN");
			DataEmpleado data = new DataEmpleado();
			empleados = data.ObtenerEmpleados();

			foreach (Empleado empleado in empleados)
			{
				miEmpresa.AgregarEmpleado(empleado);
				Console.WriteLine(empleado);
			}
		}
	}
}
