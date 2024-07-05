using DataBase;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static CRUD_Exepction_Archivos.frmPrincipal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_Exepction_Archivos
{
	public partial class frmCRUD : Form
	{
		public Panel panelPrincipal;
		List<Empleado> listaEmpleados;
		int indice;
		string formActual;

		public frmCRUD()
		{
			InitializeComponent();
		}

		private void frmCRUD_Load(object sender, EventArgs e)
		{
			//DataEmpleado data = new DataEmpleado();
			//listaEmpleados = data.ObtenerEmpleados();

			//dataGridView1.DataSource = listaEmpleados;
			dataGridView1.DataSource = CargarLista();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			LimpiarPanel("frmAgregar");
			FrmModificar form = new FrmModificar("agregar");
			form.panelPrincipal = panelPrincipal;
			form.TopLevel = false;
			panelPrincipal.Controls.Add(form);
			form.Dock = DockStyle.Fill;

			form.Show();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			LimpiarPanel("frmModificar");
			FrmModificar form = new FrmModificar("modificar");
			form.panelPrincipal = panelPrincipal;
			form.TopLevel = false;
			panelPrincipal.Controls.Add(form);
			form.Dock = DockStyle.Fill;

			Empleado emp = listaEmpleados[indice];

			form.txtId.Text = emp.Id.ToString();
			form.txtNombre.Text = emp.Nombre;
			form.txtApellido.Text = emp.Apellido;
			form.txtEdad.Text = emp.Edad.ToString();
			form.txtPuesto.Text = emp.Puesto;
			form.txtSalario.Text = emp.Salario.ToString();

			form.Show();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			LimpiarPanel("frmEliminar");
			FrmModificar form = new FrmModificar("eliminar");
			form.panelPrincipal = panelPrincipal;
			form.TopLevel = false;
			panelPrincipal.Controls.Add(form);
			form.Dock = DockStyle.Fill;

			Empleado emp = listaEmpleados[indice];

			form.txtId.Text = emp.Id.ToString();
			form.txtNombre.Text = emp.Nombre;
			form.txtApellido.Text = emp.Apellido;
			form.txtEdad.Text = emp.Edad.ToString();
			form.txtPuesto.Text = emp.Puesto;
			form.txtSalario.Text = emp.Salario.ToString();

			form.Show();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{

		}

		private void btnExportar_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	using (StreamWriter sw = new StreamWriter("../../../../Serializaciones/listaEmpleados.xml"))
			//	{
			//		XmlSerializer ser = new XmlSerializer(typeof(List<Empleado>));
			//		ser.Serialize(sw, this.listaEmpleados);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}
			XmlEmpleado xml = new XmlEmpleado(listaEmpleados);
			xml.Serializar();
		}

		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0) // el indice sea >0
			{
				indice = e.RowIndex;
			}
		}

		private void LimpiarPanel(string ventanaActual)
		{
			if (formActual != ventanaActual)
			{
				panelPrincipal.Controls.Clear();
				formActual = ventanaActual;
			}
		}

		private void btnImportar_Click(object sender, EventArgs e)
		{
			XmlEmpleado xml = new XmlEmpleado();
			listaEmpleados = xml.Deserializar();

			dataGridView1.DataSource = listaEmpleados;
		}

		private List<Empleado> CargarLista()
		{
			DataEmpleado data = new DataEmpleado();
			listaEmpleados = data.ObtenerEmpleados();

			if(listaEmpleados.Count <= 0)
			{
				XmlEmpleado xml = new XmlEmpleado();
				listaEmpleados = xml.Deserializar();
				MessageBox.Show("Datos Cargados desde el archivo XML", "Carga de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			return listaEmpleados;
		}


	}
}
