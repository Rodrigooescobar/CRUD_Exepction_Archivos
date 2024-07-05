namespace CRUD_Exepction_Archivos
{
	partial class frmPrincipal
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelPrincipal = new Panel();
			menuStrip1 = new MenuStrip();
			empleadosToolStripMenuItem = new ToolStripMenuItem();
			ingresarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
			modificarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
			eliminarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// panelPrincipal
			// 
			panelPrincipal.Dock = DockStyle.Fill;
			panelPrincipal.Location = new Point(0, 24);
			panelPrincipal.Name = "panelPrincipal";
			panelPrincipal.Size = new Size(800, 426);
			panelPrincipal.TabIndex = 0;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, ingresarEmpleadoToolStripMenuItem, modificarEmpleadoToolStripMenuItem, eliminarEmpleadoToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// empleadosToolStripMenuItem
			// 
			empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			empleadosToolStripMenuItem.Size = new Size(77, 20);
			empleadosToolStripMenuItem.Text = "Empleados";
			empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
			// 
			// ingresarEmpleadoToolStripMenuItem
			// 
			ingresarEmpleadoToolStripMenuItem.Name = "ingresarEmpleadoToolStripMenuItem";
			ingresarEmpleadoToolStripMenuItem.Size = new Size(117, 20);
			ingresarEmpleadoToolStripMenuItem.Text = "Ingresar Empleado";
			// 
			// modificarEmpleadoToolStripMenuItem
			// 
			modificarEmpleadoToolStripMenuItem.Name = "modificarEmpleadoToolStripMenuItem";
			modificarEmpleadoToolStripMenuItem.Size = new Size(126, 20);
			modificarEmpleadoToolStripMenuItem.Text = "Modificar Empleado";
			// 
			// eliminarEmpleadoToolStripMenuItem
			// 
			eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
			eliminarEmpleadoToolStripMenuItem.Size = new Size(118, 20);
			eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
			// 
			// frmPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panelPrincipal);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "frmPrincipal";
			Text = "Principal";
			Load += frmPrincipal_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelPrincipal;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem empleadosToolStripMenuItem;
		private ToolStripMenuItem ingresarEmpleadoToolStripMenuItem;
		private ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
		private ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
	}
}
