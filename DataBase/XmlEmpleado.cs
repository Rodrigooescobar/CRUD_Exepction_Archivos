using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entidades;

namespace DataBase
{
	public class XmlEmpleado :ISerializable
	{
		List<Empleado> listaEmpleados;
		string fecha;
		string path;

		public XmlEmpleado(List<Empleado> empleadoList):this()
		{
			listaEmpleados = empleadoList;
		}
        public XmlEmpleado()
        {
			this.path = $"../../../../Serializaciones/listaEmpleados.xml";
		}

		public bool Serializar()
		{
			bool retorno;

			//string fecha = DateTime.Now.ToString("ddMMyyyy");
			try
			{
				using (StreamWriter sw = new StreamWriter(this.path))
				{
					XmlSerializer ser = new XmlSerializer(typeof(List<Empleado>));
					ser.Serialize(sw, this.listaEmpleados);
					
				}
				retorno = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				retorno = false;
			}
			return retorno;
		}
		
		public List<Empleado> Deserializar()
		{
			try
			{
				using (StreamReader rs = new StreamReader(this.path))
				{
					XmlSerializer des = new XmlSerializer(typeof(List<Empleado>));
					this.listaEmpleados = (List<Empleado>)des.Deserialize(rs);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return listaEmpleados;
		}

	}
}
