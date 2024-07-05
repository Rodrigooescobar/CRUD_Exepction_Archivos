using DataBase;
using Entidades;
using Org.BouncyCastle.Asn1.Esf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CRUD_Exepction_Archivos.frmPrincipal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD_Exepction_Archivos
{
	public partial class FrmModificar : Form
	{
		public Panel panelPrincipal;

		string formActual;
		DataEmpleado data;
		List<Empleado> listaEmpleados;
		Empleado empleadoModificado;
		string Metodo;

		public FrmModificar(string metodo)
		{
			InitializeComponent();
			this.Metodo = metodo;

		}

		private void FrmModificar_Load(object sender, EventArgs e)
		{
			data = new DataEmpleado();

		}

		private Empleado ModificarEmpleado()
		{
			int id = int.Parse(txtId.Text);
			string nombre = txtNombre.Text;
			string apellido = txtApellido.Text;
			int edad = int.Parse(txtEdad.Text);
			string puesto = txtPuesto.Text;
			double salario;
			if (string.IsNullOrEmpty(txtSalario.Text))
			{
				 salario = 0;
			}
			else
			{
				 salario = double.Parse(txtSalario.Text);
			}

				Empleado empleado = new Desarollador();

			empleado.Id = id;
			empleado.Nombre = nombre;
			empleado.Apellido = apellido;
			empleado.Edad = edad;
			empleado.Puesto = puesto;
			empleado.Salario = salario;

			return empleado;

			//empleadoModificado.Id = id;
			//empleadoModificado.Nombre = nombre;
			//empleadoModificado.Apellido = apellido;
			//empleadoModificado.Edad = edad;
			//empleadoModificado.Puesto = puesto;
			//empleadoModificado.Salario = salario;

			//try
			//{
			//	data.ModificarEmpleado(empleado);
			//	listaEmpleados = data.ObtenerEmpleados();
			//}
			//catch (Exception ex)
			//{
			//}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Esta seguro que quieres cancelar?", "Confirmar Cancelacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				DialogResult = DialogResult.Cancel;
				//LimpiarPanel("frmCrud");
				this.panelPrincipal.Controls.Clear();
				frmCRUD form = new frmCRUD();
				form.panelPrincipal = panelPrincipal;
				form.TopLevel = false;
				panelPrincipal.Controls.Add(form);
				form.Dock = DockStyle.Fill;
				form.Show();

				//this.Close();
			}

		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			try
			{
				switch (Metodo)
				{
					case "agregar":
						if (data.InsertarEmpleado(AgregarEmpleado()))
						{
							MessageBox.Show("Empleado agregado Correctamente", "Agregar empleado a la lista", MessageBoxButtons.OK);
						}
						break;
					case "modificar":
						data.ModificarEmpleado(ModificarEmpleado());
						break;
					case "eliminar":
						data.ElminarEmpleado(int.Parse(txtId.Text));
						break;
				}
				this.panelPrincipal.Controls.Clear();

				frmCRUD form = new frmCRUD();
				form.panelPrincipal = panelPrincipal;
				form.TopLevel = false;
				panelPrincipal.Controls.Add(form);
				form.Dock = DockStyle.Fill;

				form.Show();
			}
			catch (Exception ex) { }

			//btnCancelar_Click(sender, e);
			//listaEmpleados = data.ObtenerEmpleados();
		}

		private void LimpiarPanel(string ventanaActual)
		{
			if (formActual != ventanaActual)
			{
				panelPrincipal.Controls.Clear();
				formActual = ventanaActual;
			}
		}

		private Empleado AgregarEmpleado()
		{
			Empleado empleado = new Desarollador();
			empleado.Nombre = txtNombre.Text;
			empleado.Apellido = txtApellido.Text;
			empleado.Edad = int.Parse(txtEdad.Text);
			empleado.Puesto = txtPuesto.Text;
			if (string.IsNullOrEmpty(txtSalario.Text))
			{
				empleado.Salario = 0;
			}
			else
			{
				empleado.Salario = double.Parse(txtSalario.Text);
			}

			return empleado;
		}

	}
}
