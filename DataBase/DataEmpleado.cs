using Entidades;
using MySql.Data.MySqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

namespace DataBase
{
	public class DataEmpleado
	{
		// conecction db


		// metodo para devolver la coneccion, que se pueda abrir y cerrarla
		private MySqlConnection ObtenerConexion()
		{
			return new MySqlConnection(ConnectionDB.connection);
		}

		// metodo para interactuar con la bd
		public List<Empleado> ObtenerEmpleadoss()
		{
			List<Empleado> listaEmpleados = new List<Empleado>();
			try
			{
				using (var conexcion = ObtenerConexion())
				{
					conexcion.Open();

					string query = "select * from empleados";
					MySqlCommand cmd = new MySqlCommand(query, conexcion);

					MySqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						//Empleado empleado = CrearEmpleadoDesdeReader(reader);
						var empleado = new Desarollador
						{
							Id = reader.GetInt32("id"),
							Nombre = reader.GetString("nombre"),
							Apellido = reader.GetString("apellido"),
							Edad = reader.GetInt32("edad"),
							Puesto = reader.GetString("puesto"),
							Salario = reader.GetDouble("salario"),
						};

						listaEmpleados.Add(empleado);
					}
				}
			}
			catch (MySqlException ex)
			{
				new ExceptionDataBase($"Excepcion al cargar los empleados: {ex.Message}");
			}
			catch (Exception ex)
			{

			}

			return listaEmpleados;
		}

		public List<Empleado> ObtenerEmpleados()
		{
			List<Empleado> listaEmpleados = new List<Empleado>();

			using (var conexcion = ObtenerConexion())
			{
				conexcion.Open();

				string query = "select * from empleados";
				MySqlCommand cmd = new MySqlCommand(query, conexcion);

				MySqlDataReader reader = cmd.ExecuteReader();

				// obtengo el puesto y despues hago un if

				while (reader.Read())
				{
					Empleado empleado = CrearEmpleadoDesdeReader(reader);
					listaEmpleados.Add(empleado);
				}
			}
			return listaEmpleados;
		}

		private Empleado CrearEmpleadoDesdeReader(MySqlDataReader reader)
		{
			string puesto = reader.GetString("puesto").ToLower();

			if (puesto == "desarrollador")
			{
				var empleado = new Desarollador
				{
					Id = reader.GetInt32("id"),
					Nombre = reader.GetString("nombre"),
					Apellido = reader.GetString("apellido"),
					Edad = reader.GetInt32("edad"),
					Puesto = puesto,
					Salario = reader.GetFloat("salario"),
					//LineasDeCodigo = reader.GetInt32("lineasDeCodigo")
				};
				return empleado;
			}
			else if (puesto == "qa")
			{
				return new Tester
				{
					Id = reader.GetInt32("id"),
					Nombre = reader.GetString("nombre"),
					Apellido = reader.GetString("apellido"),
					Edad = reader.GetInt32("edad"),
					Puesto = puesto,
					Salario = reader.GetFloat("salario"),
					//BugsEncontrados = reader.GetInt32("bugsEncontrados")
				};
			}

			//Otros tipos de empleados pueden ser manejados aquí
			throw new Exception($"Tipo de empleado desconocido: {puesto}");
		}

		public bool InsertarEmpleado(Empleado empleado)
		{
			bool insertar;
			try
			{
				using (var conexion = ObtenerConexion())
				{
					conexion.Open();

					// creo la consulta
					string query = "Insert into empleados(Nombre, Apellido, Puesto, Salario)" +
						$"values (@nombre, @apellido, @puesto, @salario)";
					MySqlCommand comando = new MySqlCommand(query, conexion);
					comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
					comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
					comando.Parameters.AddWithValue("@puesto", empleado.Puesto);
					comando.Parameters.AddWithValue("@salario", empleado.Salario);

					// ejecuto la consulta (insertcion, eliminacion o actualizacion)
					int valor = comando.ExecuteNonQuery();
					insertar = true;
				}
			}
			catch 
			{
				insertar = false;
			}
			return insertar;
		}

		public void ModificarEmpleado(Empleado empleado)
		{
			try
			{
				using (var conexion = ObtenerConexion())
				{
					conexion.Open();

					// creo la consulta
					string query = "update empleados set Nombre = @nombre, Puesto = @puesto, Salario=@salario" +
						$" where id = @id";
					MySqlCommand comando = new MySqlCommand(query, conexion);
					comando.Parameters.AddWithValue("@id", empleado.Id);
					comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
					comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
					comando.Parameters.AddWithValue("@puesto", empleado.Puesto);
					comando.Parameters.AddWithValue("@salario", empleado.Salario);

					// ejecuto la consulta (insertcion, eliminacion o actualizacion)
					int valor = comando.ExecuteNonQuery();
				}
			}
			catch (Exception ex) { }
		}

		public void ElminarEmpleado(int id)
		{
			using (var conexion = ObtenerConexion())
			{
				conexion.Open();

				// creo la consulta
				string query = "delete from empleados where id = @id";
				MySqlCommand comando = new MySqlCommand(query, conexion);
				comando.Parameters.AddWithValue("@id", id);

				// ejecuto la consulta (insertcion, eliminacion o actualizacion)
				int valor = comando.ExecuteNonQuery();
				Console.WriteLine(valor);
			}
		}
	}
}
