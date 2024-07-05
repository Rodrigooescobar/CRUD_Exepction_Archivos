namespace CRUD_Exepction_Archivos
{
	partial class frmCRUD
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnEliminar = new Button();
			btnModificar = new Button();
			btnLimpiar = new Button();
			btnAgregar = new Button();
			btnExportar = new Button();
			dataGridView1 = new DataGridView();
			btnImportar = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnEliminar
			// 
			btnEliminar.Location = new Point(341, 324);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(124, 58);
			btnEliminar.TabIndex = 3;
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseVisualStyleBackColor = true;
			btnEliminar.Click += btnEliminar_Click;
			// 
			// btnModificar
			// 
			btnModificar.Location = new Point(181, 324);
			btnModificar.Name = "btnModificar";
			btnModificar.Size = new Size(120, 58);
			btnModificar.TabIndex = 2;
			btnModificar.Text = "Modificar";
			btnModificar.UseVisualStyleBackColor = true;
			btnModificar.Click += btnModificar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Location = new Point(499, 324);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(120, 58);
			btnLimpiar.TabIndex = 4;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(21, 324);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(119, 58);
			btnAgregar.TabIndex = 1;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// btnExportar
			// 
			btnExportar.Location = new Point(650, 324);
			btnExportar.Name = "btnExportar";
			btnExportar.Size = new Size(128, 58);
			btnExportar.TabIndex = 5;
			btnExportar.Text = "Exportar";
			btnExportar.UseVisualStyleBackColor = true;
			btnExportar.Click += btnExportar_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(15, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(773, 306);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
			// 
			// btnImportar
			// 
			btnImportar.Location = new Point(459, 397);
			btnImportar.Name = "btnImportar";
			btnImportar.Size = new Size(122, 41);
			btnImportar.TabIndex = 6;
			btnImportar.Text = "Importar";
			btnImportar.UseVisualStyleBackColor = true;
			btnImportar.Click += btnImportar_Click;
			// 
			// frmCRUD
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(800, 450);
			Controls.Add(btnImportar);
			Controls.Add(dataGridView1);
			Controls.Add(btnExportar);
			Controls.Add(btnAgregar);
			Controls.Add(btnEliminar);
			Controls.Add(btnLimpiar);
			Controls.Add(btnModificar);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmCRUD";
			Text = "frmCRUD";
			Load += frmCRUD_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnEliminar;
		private Button btnModificar;
		private Button btnLimpiar;
		private Button btnAgregar;
		private Button btnExportar;
		private DataGridView dataGridView1;
		private Button btnImportar;
	}
}