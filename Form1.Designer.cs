namespace App_MCVill
{
    partial class Form1
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFechas = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNomEmp = new System.Windows.Forms.TextBox();
            this.lblNomEmp = new System.Windows.Forms.Label();
            this.tbApeEmp = new System.Windows.Forms.TextBox();
            this.lblApeEmp = new System.Windows.Forms.Label();
            this.tbFechaIng = new System.Windows.Forms.TextBox();
            this.lblFechaIng = new System.Windows.Forms.Label();
            this.tbVacTom = new System.Windows.Forms.TextBox();
            this.lblVacTom = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(328, 46);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(564, 376);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(328, 12);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(89, 23);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Tag = "Listado de Empleados";
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFechas
            // 
            this.btnFechas.Location = new System.Drawing.Point(435, 12);
            this.btnFechas.Name = "btnFechas";
            this.btnFechas.Size = new System.Drawing.Size(89, 23);
            this.btnFechas.TabIndex = 2;
            this.btnFechas.Tag = "Listado de Fechas de cada Empleado";
            this.btnFechas.Text = "Fechas";
            this.btnFechas.UseVisualStyleBackColor = true;
            this.btnFechas.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID Empleado";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(164, 106);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(121, 20);
            this.tbID.TabIndex = 4;
            // 
            // tbNomEmp
            // 
            this.tbNomEmp.Location = new System.Drawing.Point(164, 146);
            this.tbNomEmp.Name = "tbNomEmp";
            this.tbNomEmp.Size = new System.Drawing.Size(121, 20);
            this.tbNomEmp.TabIndex = 6;
            // 
            // lblNomEmp
            // 
            this.lblNomEmp.AutoSize = true;
            this.lblNomEmp.Location = new System.Drawing.Point(26, 149);
            this.lblNomEmp.Name = "lblNomEmp";
            this.lblNomEmp.Size = new System.Drawing.Size(94, 13);
            this.lblNomEmp.TabIndex = 5;
            this.lblNomEmp.Text = "Nombre Empleado";
            // 
            // tbApeEmp
            // 
            this.tbApeEmp.Location = new System.Drawing.Point(164, 183);
            this.tbApeEmp.Name = "tbApeEmp";
            this.tbApeEmp.Size = new System.Drawing.Size(121, 20);
            this.tbApeEmp.TabIndex = 8;
            // 
            // lblApeEmp
            // 
            this.lblApeEmp.AutoSize = true;
            this.lblApeEmp.Location = new System.Drawing.Point(25, 186);
            this.lblApeEmp.Name = "lblApeEmp";
            this.lblApeEmp.Size = new System.Drawing.Size(94, 13);
            this.lblApeEmp.TabIndex = 7;
            this.lblApeEmp.Text = "Apellido Empleado";
            // 
            // tbFechaIng
            // 
            this.tbFechaIng.Location = new System.Drawing.Point(164, 223);
            this.tbFechaIng.Name = "tbFechaIng";
            this.tbFechaIng.Size = new System.Drawing.Size(121, 20);
            this.tbFechaIng.TabIndex = 10;
            // 
            // lblFechaIng
            // 
            this.lblFechaIng.AutoSize = true;
            this.lblFechaIng.Location = new System.Drawing.Point(25, 226);
            this.lblFechaIng.Name = "lblFechaIng";
            this.lblFechaIng.Size = new System.Drawing.Size(75, 13);
            this.lblFechaIng.TabIndex = 9;
            this.lblFechaIng.Text = "Fecha Ingreso";
            // 
            // tbVacTom
            // 
            this.tbVacTom.Location = new System.Drawing.Point(164, 261);
            this.tbVacTom.Name = "tbVacTom";
            this.tbVacTom.Size = new System.Drawing.Size(121, 20);
            this.tbVacTom.TabIndex = 12;
            this.tbVacTom.Visible = false;
            // 
            // lblVacTom
            // 
            this.lblVacTom.AutoSize = true;
            this.lblVacTom.Location = new System.Drawing.Point(26, 264);
            this.lblVacTom.Name = "lblVacTom";
            this.lblVacTom.Size = new System.Drawing.Size(35, 13);
            this.lblVacTom.TabIndex = 11;
            this.lblVacTom.Text = "label1";
            this.lblVacTom.Visible = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(34, 373);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(115, 373);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(196, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(34, 33);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 16;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(128, 33);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(84, 23);
            this.btnDesconectar.TabIndex = 17;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(28, 308);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 18;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 435);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbVacTom);
            this.Controls.Add(this.lblVacTom);
            this.Controls.Add(this.tbFechaIng);
            this.Controls.Add(this.lblFechaIng);
            this.Controls.Add(this.tbApeEmp);
            this.Controls.Add(this.lblApeEmp);
            this.Controls.Add(this.tbNomEmp);
            this.Controls.Add(this.lblNomEmp);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnFechas);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Form1";
            this.Text = "MCVill DataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFechas;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNomEmp;
        private System.Windows.Forms.Label lblNomEmp;
        private System.Windows.Forms.TextBox tbApeEmp;
        private System.Windows.Forms.Label lblApeEmp;
        private System.Windows.Forms.TextBox tbFechaIng;
        private System.Windows.Forms.Label lblFechaIng;
        private System.Windows.Forms.TextBox tbVacTom;
        private System.Windows.Forms.Label lblVacTom;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnBusqueda;
    }
}

