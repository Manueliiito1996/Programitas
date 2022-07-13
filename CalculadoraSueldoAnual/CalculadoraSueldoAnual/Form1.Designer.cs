namespace CalculadoraSueldoAnual
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
            this.gboxSueldoSemanal = new System.Windows.Forms.GroupBox();
            this.lblSueldoSemanal = new System.Windows.Forms.Label();
            this.btnCalcularSueldoSemanal = new System.Windows.Forms.Button();
            this.gboxSueldoMensual = new System.Windows.Forms.GroupBox();
            this.lblSueldoMensual = new System.Windows.Forms.Label();
            this.btnCalcularSueldoMensual = new System.Windows.Forms.Button();
            this.gboxSueldoAnual = new System.Windows.Forms.GroupBox();
            this.lblSueldoAnual = new System.Windows.Forms.Label();
            this.btnCalcularSueldoAnual = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSueldoPorHora = new System.Windows.Forms.Label();
            this.lblHorasDiarias = new System.Windows.Forms.Label();
            this.lblDiasLibres = new System.Windows.Forms.Label();
            this.txtSueldoPorHora = new System.Windows.Forms.TextBox();
            this.txtDiasLibres = new System.Windows.Forms.TextBox();
            this.txtHorasDeTrabajo = new System.Windows.Forms.TextBox();
            this.btnCalcularTodo = new System.Windows.Forms.Button();
            this.lblCulo = new System.Windows.Forms.Label();
            this.gboxSueldoSemanal.SuspendLayout();
            this.gboxSueldoMensual.SuspendLayout();
            this.gboxSueldoAnual.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSueldoSemanal
            // 
            this.gboxSueldoSemanal.Controls.Add(this.lblSueldoSemanal);
            this.gboxSueldoSemanal.Controls.Add(this.btnCalcularSueldoSemanal);
            this.gboxSueldoSemanal.Location = new System.Drawing.Point(22, 99);
            this.gboxSueldoSemanal.Name = "gboxSueldoSemanal";
            this.gboxSueldoSemanal.Size = new System.Drawing.Size(250, 125);
            this.gboxSueldoSemanal.TabIndex = 0;
            this.gboxSueldoSemanal.TabStop = false;
            this.gboxSueldoSemanal.Text = "               Sueldo Semanal";
            // 
            // lblSueldoSemanal
            // 
            this.lblSueldoSemanal.AutoSize = true;
            this.lblSueldoSemanal.Location = new System.Drawing.Point(6, 47);
            this.lblSueldoSemanal.Name = "lblSueldoSemanal";
            this.lblSueldoSemanal.Size = new System.Drawing.Size(50, 20);
            this.lblSueldoSemanal.TabIndex = 1;
            this.lblSueldoSemanal.Text = "label1";
            // 
            // btnCalcularSueldoSemanal
            // 
            this.btnCalcularSueldoSemanal.Location = new System.Drawing.Point(48, 87);
            this.btnCalcularSueldoSemanal.Name = "btnCalcularSueldoSemanal";
            this.btnCalcularSueldoSemanal.Size = new System.Drawing.Size(121, 29);
            this.btnCalcularSueldoSemanal.TabIndex = 0;
            this.btnCalcularSueldoSemanal.Text = "Calcular";
            this.btnCalcularSueldoSemanal.UseVisualStyleBackColor = true;
            this.btnCalcularSueldoSemanal.Click += new System.EventHandler(this.btnCalcularSueldoSemanal_Click);
            // 
            // gboxSueldoMensual
            // 
            this.gboxSueldoMensual.Controls.Add(this.lblSueldoMensual);
            this.gboxSueldoMensual.Controls.Add(this.btnCalcularSueldoMensual);
            this.gboxSueldoMensual.Location = new System.Drawing.Point(287, 99);
            this.gboxSueldoMensual.Name = "gboxSueldoMensual";
            this.gboxSueldoMensual.Size = new System.Drawing.Size(250, 125);
            this.gboxSueldoMensual.TabIndex = 1;
            this.gboxSueldoMensual.TabStop = false;
            this.gboxSueldoMensual.Text = "               Sueldo Mensual";
            // 
            // lblSueldoMensual
            // 
            this.lblSueldoMensual.AutoSize = true;
            this.lblSueldoMensual.Location = new System.Drawing.Point(6, 47);
            this.lblSueldoMensual.Name = "lblSueldoMensual";
            this.lblSueldoMensual.Size = new System.Drawing.Size(50, 20);
            this.lblSueldoMensual.TabIndex = 4;
            this.lblSueldoMensual.Text = "label4";
            // 
            // btnCalcularSueldoMensual
            // 
            this.btnCalcularSueldoMensual.Location = new System.Drawing.Point(62, 87);
            this.btnCalcularSueldoMensual.Name = "btnCalcularSueldoMensual";
            this.btnCalcularSueldoMensual.Size = new System.Drawing.Size(121, 29);
            this.btnCalcularSueldoMensual.TabIndex = 1;
            this.btnCalcularSueldoMensual.Text = "Calcular";
            this.btnCalcularSueldoMensual.UseVisualStyleBackColor = true;
            this.btnCalcularSueldoMensual.Click += new System.EventHandler(this.btnCalcularSueldoMensual_Click);
            // 
            // gboxSueldoAnual
            // 
            this.gboxSueldoAnual.Controls.Add(this.lblSueldoAnual);
            this.gboxSueldoAnual.Controls.Add(this.btnCalcularSueldoAnual);
            this.gboxSueldoAnual.Location = new System.Drawing.Point(558, 99);
            this.gboxSueldoAnual.Name = "gboxSueldoAnual";
            this.gboxSueldoAnual.Size = new System.Drawing.Size(250, 125);
            this.gboxSueldoAnual.TabIndex = 2;
            this.gboxSueldoAnual.TabStop = false;
            this.gboxSueldoAnual.Text = "               Sueldo Anual";
            // 
            // lblSueldoAnual
            // 
            this.lblSueldoAnual.AutoSize = true;
            this.lblSueldoAnual.Location = new System.Drawing.Point(6, 47);
            this.lblSueldoAnual.Name = "lblSueldoAnual";
            this.lblSueldoAnual.Size = new System.Drawing.Size(50, 20);
            this.lblSueldoAnual.TabIndex = 4;
            this.lblSueldoAnual.Text = "label5";
            // 
            // btnCalcularSueldoAnual
            // 
            this.btnCalcularSueldoAnual.Location = new System.Drawing.Point(68, 87);
            this.btnCalcularSueldoAnual.Name = "btnCalcularSueldoAnual";
            this.btnCalcularSueldoAnual.Size = new System.Drawing.Size(121, 29);
            this.btnCalcularSueldoAnual.TabIndex = 1;
            this.btnCalcularSueldoAnual.Text = "Calcular";
            this.btnCalcularSueldoAnual.UseVisualStyleBackColor = true;
            this.btnCalcularSueldoAnual.Click += new System.EventHandler(this.btnCalcularSueldoAnual_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(586, 241);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(118, 40);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(710, 241);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSueldoPorHora
            // 
            this.lblSueldoPorHora.AutoSize = true;
            this.lblSueldoPorHora.Location = new System.Drawing.Point(12, 12);
            this.lblSueldoPorHora.Name = "lblSueldoPorHora";
            this.lblSueldoPorHora.Size = new System.Drawing.Size(109, 20);
            this.lblSueldoPorHora.TabIndex = 5;
            this.lblSueldoPorHora.Text = "Sueldo x Culito";
            // 
            // lblHorasDiarias
            // 
            this.lblHorasDiarias.AutoSize = true;
            this.lblHorasDiarias.Location = new System.Drawing.Point(12, 41);
            this.lblHorasDiarias.Name = "lblHorasDiarias";
            this.lblHorasDiarias.Size = new System.Drawing.Size(102, 20);
            this.lblHorasDiarias.TabIndex = 6;
            this.lblHorasDiarias.Text = "Cuantas al dia";
            // 
            // lblDiasLibres
            // 
            this.lblDiasLibres.AutoSize = true;
            this.lblDiasLibres.Location = new System.Drawing.Point(12, 69);
            this.lblDiasLibres.Name = "lblDiasLibres";
            this.lblDiasLibres.Size = new System.Drawing.Size(115, 20);
            this.lblDiasLibres.TabIndex = 7;
            this.lblDiasLibres.Text = "Dias Trabajados";
            // 
            // txtSueldoPorHora
            // 
            this.txtSueldoPorHora.Location = new System.Drawing.Point(177, 5);
            this.txtSueldoPorHora.Name = "txtSueldoPorHora";
            this.txtSueldoPorHora.Size = new System.Drawing.Size(125, 27);
            this.txtSueldoPorHora.TabIndex = 8;
            this.txtSueldoPorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiasLibres
            // 
            this.txtDiasLibres.Location = new System.Drawing.Point(177, 62);
            this.txtDiasLibres.Name = "txtDiasLibres";
            this.txtDiasLibres.Size = new System.Drawing.Size(125, 27);
            this.txtDiasLibres.TabIndex = 9;
            this.txtDiasLibres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHorasDeTrabajo
            // 
            this.txtHorasDeTrabajo.Location = new System.Drawing.Point(177, 34);
            this.txtHorasDeTrabajo.Name = "txtHorasDeTrabajo";
            this.txtHorasDeTrabajo.Size = new System.Drawing.Size(125, 27);
            this.txtHorasDeTrabajo.TabIndex = 10;
            this.txtHorasDeTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcularTodo
            // 
            this.btnCalcularTodo.Location = new System.Drawing.Point(22, 241);
            this.btnCalcularTodo.Name = "btnCalcularTodo";
            this.btnCalcularTodo.Size = new System.Drawing.Size(250, 35);
            this.btnCalcularTodo.TabIndex = 11;
            this.btnCalcularTodo.Text = "Calcular Todo";
            this.btnCalcularTodo.UseVisualStyleBackColor = true;
            this.btnCalcularTodo.Click += new System.EventHandler(this.btnCalcularTodo_Click);
            // 
            // lblCulo
            // 
            this.lblCulo.AutoSize = true;
            this.lblCulo.Location = new System.Drawing.Point(326, 34);
            this.lblCulo.Name = "lblCulo";
            this.lblCulo.Size = new System.Drawing.Size(0, 20);
            this.lblCulo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 293);
            this.Controls.Add(this.lblCulo);
            this.Controls.Add(this.btnCalcularTodo);
            this.Controls.Add(this.txtHorasDeTrabajo);
            this.Controls.Add(this.txtDiasLibres);
            this.Controls.Add(this.txtSueldoPorHora);
            this.Controls.Add(this.lblDiasLibres);
            this.Controls.Add(this.lblHorasDiarias);
            this.Controls.Add(this.lblSueldoPorHora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.gboxSueldoAnual);
            this.Controls.Add(this.gboxSueldoMensual);
            this.Controls.Add(this.gboxSueldoSemanal);
            this.Name = "Form1";
            this.Text = "Calculadora para saber cuanta plata genera dar culito";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxSueldoSemanal.ResumeLayout(false);
            this.gboxSueldoSemanal.PerformLayout();
            this.gboxSueldoMensual.ResumeLayout(false);
            this.gboxSueldoMensual.PerformLayout();
            this.gboxSueldoAnual.ResumeLayout(false);
            this.gboxSueldoAnual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gboxSueldoSemanal;
        private Label lblSueldoSemanal;
        private Button btnCalcularSueldoSemanal;
        private GroupBox gboxSueldoMensual;
        private Label lblSueldoMensual;
        private Button btnCalcularSueldoMensual;
        private GroupBox gboxSueldoAnual;
        private Label lblSueldoAnual;
        private Button btnCalcularSueldoAnual;
        private Button btnReiniciar;
        private Button btnSalir;
        private Label lblSueldoPorHora;
        private Label lblHorasDiarias;
        private Label lblDiasLibres;
        private TextBox txtSueldoPorHora;
        private TextBox txtDiasLibres;
        private TextBox txtHorasDeTrabajo;
        private Button btnCalcularTodo;
        private Label lblCulo;
    }
}