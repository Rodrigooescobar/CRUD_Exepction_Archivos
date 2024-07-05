namespace CRUD_Exepction_Archivos
{
	partial class FrmModificar
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
			panel1 = new Panel();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			lblId = new Label();
			btnAceptar = new Button();
			txtSalario = new TextBox();
			btnCancelar = new Button();
			txtPuesto = new TextBox();
			txtEdad = new TextBox();
			txtApellido = new TextBox();
			txtNombre = new TextBox();
			txtId = new TextBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.None;
			panel1.Controls.Add(label6);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(lblId);
			panel1.Controls.Add(btnAceptar);
			panel1.Controls.Add(txtSalario);
			panel1.Controls.Add(btnCancelar);
			panel1.Controls.Add(txtPuesto);
			panel1.Controls.Add(txtEdad);
			panel1.Controls.Add(txtApellido);
			panel1.Controls.Add(txtNombre);
			panel1.Controls.Add(txtId);
			panel1.Location = new Point(181, 29);
			panel1.Name = "panel1";
			panel1.Size = new Size(456, 409);
			panel1.TabIndex = 0;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(35, 220);
			label6.Name = "label6";
			label6.Size = new Size(42, 15);
			label6.TabIndex = 11;
			label6.Text = "Salario";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(35, 180);
			label5.Name = "label5";
			label5.Size = new Size(43, 15);
			label5.TabIndex = 10;
			label5.Text = "Puesto";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(35, 141);
			label4.Name = "label4";
			label4.Size = new Size(33, 15);
			label4.TabIndex = 9;
			label4.Text = "Edad";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(35, 101);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 8;
			label3.Text = "Apellido";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(35, 63);
			label2.Name = "label2";
			label2.Size = new Size(51, 15);
			label2.TabIndex = 7;
			label2.Text = "Nombre";
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Location = new Point(35, 22);
			lblId.Name = "lblId";
			lblId.Size = new Size(17, 15);
			lblId.TabIndex = 6;
			lblId.Text = "Id";
			// 
			// btnAceptar
			// 
			btnAceptar.Location = new Point(138, 330);
			btnAceptar.Name = "btnAceptar";
			btnAceptar.Size = new Size(93, 53);
			btnAceptar.TabIndex = 0;
			btnAceptar.Text = "Aceptar";
			btnAceptar.UseVisualStyleBackColor = true;
			btnAceptar.Click += btnAceptar_Click;
			// 
			// txtSalario
			// 
			txtSalario.Location = new Point(142, 217);
			txtSalario.Name = "txtSalario";
			txtSalario.Size = new Size(250, 23);
			txtSalario.TabIndex = 5;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(313, 330);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(93, 53);
			btnCancelar.TabIndex = 1;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// txtPuesto
			// 
			txtPuesto.Location = new Point(142, 177);
			txtPuesto.Name = "txtPuesto";
			txtPuesto.Size = new Size(250, 23);
			txtPuesto.TabIndex = 4;
			// 
			// txtEdad
			// 
			txtEdad.Location = new Point(142, 138);
			txtEdad.Name = "txtEdad";
			txtEdad.Size = new Size(250, 23);
			txtEdad.TabIndex = 3;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(142, 98);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(250, 23);
			txtApellido.TabIndex = 2;
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(142, 60);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(250, 23);
			txtNombre.TabIndex = 1;
			// 
			// txtId
			// 
			txtId.Location = new Point(142, 19);
			txtId.Name = "txtId";
			txtId.Size = new Size(250, 23);
			txtId.TabIndex = 0;
			// 
			// FrmModificar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FrmModificar";
			Text = "FrmModificar";
			Load += FrmModificar_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button btnCancelar;
		private Button btnAceptar;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label lblId;
		public TextBox txtSalario;
		public TextBox txtPuesto;
		public TextBox txtEdad;
		public TextBox txtApellido;
		public TextBox txtNombre;
		public TextBox txtId;
	}
}