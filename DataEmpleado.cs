using Entidades;
using MySql.Data.MySqlClient;

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
		//public List<Empleado> SeleccionarEmpleados()
		//{
		//	List<Empleado> listaEmpleados = new List<Empleado>();

		//	// administrador de contextos, cierra la conexcion automaticamente
		//	using (var conexcion = ObtenerConexion())
		//	{
		//		conexcion.Open();

		//		//consulta (query) mediante un comando, le paso la query y la conexion
		//		string query = "select * from empleados";
		//		MySqlCommand cmd = new MySqlCommand(query, conexcion);

		//		// data reader para traer muchos datos de mi consulta
		//		MySqlDataReader reader = cmd.ExecuteReader();
		//		while (reader.Read())
		//		{
		//			var empleado = new Desarollador
		//			{
		//				Id = reader.GetInt32("id"),
		//				Nombre = reader.GetString("nombre"),
		//				Apellido = reader.GetString("apellido"),
		//				Edad = reader.GetInt32("edad"),
		//				Puesto = reader.GetString("puesto"),
		//				Salario = reader.GetFloat("salario"),
		//			};

		//			listaEmpleados.Add(empleado);
		//		}
		//	}
		//	return listaEmpleados;
		//}

		public List<Empleado> ObtenerEmpleados()
		{
			List<Empleado> listaEmpleados = new List<Empleado>();

			using (var conexcion = ObtenerConexion())
			{
				conexcion.Open();

				string query = "select * from empleados";
				MySqlCommand cmd = new MySqlCommand(query, conexcion);

				MySqlDataReader reader = cmd.ExecuteReader();
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
			string puesto = reader.GetString("puesto");

			if (puesto.ToLower() == "desarollador")
			{
				return new Desarollador
				{
					Id = reader.GetInt32("id"),
					Nombre = reader.GetString("nombre"),
					Apellido = reader.GetString("apellido"),
					Edad = reader.GetInt32("edad"),
					Puesto = puesto,
					Salario = reader.GetFloat("salario"),
					LineasDeCodigo = reader.GetInt32("lineasDeCodigo")
				};
			}
			//else if (puesto == "Tester")
			//{
			//	return new Tester
			//	{
			//		Id = reader.GetInt32("id"),
			//		Nombre = reader.GetString("nombre"),
			//		Apellido = reader.GetString("apellido"),
			//		Edad = reader.GetInt32("edad"),
			//		Puesto = puesto,
			//		Salario = reader.GetFloat("salario"),
			//		BugsEncontrados = reader.GetInt32("bugsEncontrados")
			//	};
			//}

			// Otros tipos de empleados pueden ser manejados aquí

			throw new Exception($"Tipo de empleado desconocido: {puesto}");
		}

		public void InsertarEmpleado(Empleado empleado)
		{
			using (var conexion = ObtenerConexion())
			{
				conexion.Open();

				// creo la consulta
				string query = "Insert into empleados(Nombre, Puesto, Salario)" +
					$"values (@nombre, @puesto, @salario)";
				MySqlCommand comando = new MySqlCommand(query, conexion);
				comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
				comando.Parameters.AddWithValue("@puesto", empleado.Puesto);
				comando.Parameters.AddWithValue("@salario", empleado.Salario);

				// ejecuto la consulta (insertcion, eliminacion o actualizacion)
				int valor = comando.ExecuteNonQuery();
				Console.WriteLine(valor);
			}
		}

		public void ModificarEmpleado(Empleado empleado)
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
				comando.Parameters.AddWithValue("@puesto", empleado.Puesto);
				comando.Parameters.AddWithValue("@salario", empleado.Salario);

				// ejecuto la consulta (insertcion, eliminacion o actualizacion)
				int valor = comando.ExecuteNonQuery();
				Console.WriteLine(valor);
			}
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
