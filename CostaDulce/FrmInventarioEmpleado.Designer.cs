
namespace CostaDulce
{
    partial class FrmInventarioEmpleado
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
            this.Wrapper = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelefono_E = new System.Windows.Forms.TextBox();
            this.txtDireccion_E = new System.Windows.Forms.TextBox();
            this.txtSalario_E = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoM_E = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellidoP_E = new System.Windows.Forms.TextBox();
            this.txtEdad_E = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID_Empleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmpledoBasedeDatos = new System.Windows.Forms.DataGridView();
            this.Wrapper.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpledoBasedeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(227)))));
            this.Wrapper.Controls.Add(this.groupBox4);
            this.Wrapper.Controls.Add(this.groupBox3);
            this.Wrapper.Controls.Add(this.groupBox2);
            this.Wrapper.Controls.Add(this.groupBox1);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1224, 741);
            this.Wrapper.TabIndex = 3;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(36, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(853, 79);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "-BUSQUEDA-";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(705, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscar.Location = new System.Drawing.Point(107, 38);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(423, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.groupBox3.Controls.Add(this.txtTelefono_E);
            this.groupBox3.Controls.Add(this.txtDireccion_E);
            this.groupBox3.Controls.Add(this.txtSalario_E);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtApellidoM_E);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtApellidoP_E);
            this.groupBox3.Controls.Add(this.txtEdad_E);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtID_Empleado);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(36, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 170);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "-DATOS-";
            // 
            // txtTelefono_E
            // 
            this.txtTelefono_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefono_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefono_E.Location = new System.Drawing.Point(443, 131);
            this.txtTelefono_E.Name = "txtTelefono_E";
            this.txtTelefono_E.Size = new System.Drawing.Size(190, 20);
            this.txtTelefono_E.TabIndex = 17;
            // 
            // txtDireccion_E
            // 
            this.txtDireccion_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDireccion_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDireccion_E.Location = new System.Drawing.Point(443, 101);
            this.txtDireccion_E.Name = "txtDireccion_E";
            this.txtDireccion_E.Size = new System.Drawing.Size(190, 20);
            this.txtDireccion_E.TabIndex = 16;
            // 
            // txtSalario_E
            // 
            this.txtSalario_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalario_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalario_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalario_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSalario_E.Location = new System.Drawing.Point(443, 69);
            this.txtSalario_E.Name = "txtSalario_E";
            this.txtSalario_E.Size = new System.Drawing.Size(70, 20);
            this.txtSalario_E.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Edad:";
            // 
            // txtApellidoM_E
            // 
            this.txtApellidoM_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoM_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoM_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoM_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellidoM_E.Location = new System.Drawing.Point(161, 131);
            this.txtApellidoM_E.Name = "txtApellidoM_E";
            this.txtApellidoM_E.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoM_E.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Apellido Materno: ";
            // 
            // txtApellidoP_E
            // 
            this.txtApellidoP_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidoP_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoP_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoP_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellidoP_E.Location = new System.Drawing.Point(161, 101);
            this.txtApellidoP_E.Name = "txtApellidoP_E";
            this.txtApellidoP_E.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoP_E.TabIndex = 10;
            // 
            // txtEdad_E
            // 
            this.txtEdad_E.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdad_E.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEdad_E.Location = new System.Drawing.Point(443, 41);
            this.txtEdad_E.Name = "txtEdad_E";
            this.txtEdad_E.Size = new System.Drawing.Size(70, 20);
            this.txtEdad_E.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(161, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtID_Empleado
            // 
            this.txtID_Empleado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID_Empleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID_Empleado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID_Empleado.Location = new System.Drawing.Point(161, 44);
            this.txtID_Empleado.Name = "txtID_Empleado";
            this.txtID_Empleado.Size = new System.Drawing.Size(61, 20);
            this.txtID_Empleado.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Paterno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.groupBox2.Controls.Add(this.Agregar);
            this.groupBox2.Controls.Add(this.Modificar);
            this.groupBox2.Controls.Add(this.Eliminar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(910, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 188);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "-ACCIONES-";
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Agregar.Location = new System.Drawing.Point(22, 33);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(133, 42);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modificar.Location = new System.Drawing.Point(22, 81);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(133, 42);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Eliminar.Location = new System.Drawing.Point(22, 129);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(133, 42);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            this.groupBox1.Controls.Add(this.EmpledoBasedeDatos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 280);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "-EMPLEADO-";
            // 
            // EmpledoBasedeDatos
            // 
            this.EmpledoBasedeDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpledoBasedeDatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpledoBasedeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpledoBasedeDatos.Location = new System.Drawing.Point(6, 37);
            this.EmpledoBasedeDatos.Name = "EmpledoBasedeDatos";
            this.EmpledoBasedeDatos.Size = new System.Drawing.Size(1039, 237);
            this.EmpledoBasedeDatos.TabIndex = 0;
            this.EmpledoBasedeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpledoBasedeDatos_CellContentClick);
            // 
            // FrmInventarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 741);
            this.ControlBox = false;
            this.Controls.Add(this.Wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventarioEmpleado";
            this.Text = "FrmCompras";
            this.Wrapper.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpledoBasedeDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EmpledoBasedeDatos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtApellidoP_E;
        private System.Windows.Forms.TextBox txtEdad_E;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID_Empleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox txtApellidoM_E;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono_E;
        private System.Windows.Forms.TextBox txtDireccion_E;
        private System.Windows.Forms.TextBox txtSalario_E;
        private System.Windows.Forms.Label label10;
    }
}