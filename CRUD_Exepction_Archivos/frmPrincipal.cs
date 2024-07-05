namespace CRUD_Exepction_Archivos
{
	public partial class frmPrincipal : Form
	{

		private string formActual;

		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{

		}

		private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LimpiarPanel("frmCrud");
			frmCRUD form = new frmCRUD();
			form.panelPrincipal = panelPrincipal;
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			panelPrincipal.Controls.Add(form);

			form.Show();
			//CargarForm(new frmCRUD());
		}

		private void LimpiarPanel(string ventanaActual)
		{
			if (formActual != ventanaActual)
			{
				panelPrincipal.Controls.Clear();
				formActual = ventanaActual;
			}
			//foreach (Control control in panelPrincipal.Controls) 
			//{
			//	if(control is Form)
			//	{
			//		Form form = (Form)control;
			//		if(form.Name != this.Name)
			//		{
			//			panelPrincipal.Controls.Clear();
			//		}
			//	}
			//}
		}

		private void CargarForm(object formulario)
		{
			LimpiarPanel("frmCrud");
			Form form = formulario as Form;
			form.TopLevel = false;
			panelPrincipal.Controls.Add(form);
			form.Dock = DockStyle.Fill;
			form.Show();
		}

	}
}
