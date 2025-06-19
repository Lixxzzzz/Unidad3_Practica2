namespace Ejercicio_del_4to_Video
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPromedio = new TextBox();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            btnBuscar = new Button();
            label4 = new Label();
            txtBuscar = new TextBox();
            dgAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 85);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 138);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 2;
            label3.Text = "Promedio:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Menu;
            txtCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(165, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(143, 34);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Menu;
            txtNombre.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(165, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 33);
            txtNombre.TabIndex = 4;
            // 
            // txtPromedio
            // 
            txtPromedio.BackColor = SystemColors.Menu;
            txtPromedio.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPromedio.Location = new Point(165, 141);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(143, 35);
            txtPromedio.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(255, 192, 192);
            btnRegistrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(442, 73);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(129, 61);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(448, 208);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 58);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.FromArgb(255, 192, 192);
            btnOrdenar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Location = new Point(566, 208);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(112, 58);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 192, 192);
            btnBuscar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(330, 208);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 58);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 222);
            label4.Name = "label4";
            label4.Size = new Size(199, 26);
            label4.TabIndex = 10;
            label4.Text = "Buscar por codigo";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Menu;
            txtBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(241, 222);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(83, 34);
            txtBuscar.TabIndex = 11;
            // 
            // dgAlumnos
            // 
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(54, 316);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowHeadersWidth = 62;
            dgAlumnos.Size = new Size(699, 250);
            dgAlumnos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 597);
            Controls.Add(dgAlumnos);
            Controls.Add(txtBuscar);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPromedio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPromedio;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Button btnBuscar;
        private Label label4;
        private TextBox txtBuscar;
        private DataGridView dgAlumnos;
    }
}
