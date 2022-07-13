namespace Calculadora_Turca
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.btnLiras = new System.Windows.Forms.Button();
            this.btnDolares = new System.Windows.Forms.Button();
            this.gboxDolares = new System.Windows.Forms.GroupBox();
            this.lblResultadoDolar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.gboxLiras = new System.Windows.Forms.GroupBox();
            this.lblResultadoLiras = new System.Windows.Forms.Label();
            this.txtLiras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxBienvenida = new System.Windows.Forms.GroupBox();
            this.btnBienvenido = new System.Windows.Forms.Button();
            this.gboxDolares.SuspendLayout();
            this.gboxLiras.SuspendLayout();
            this.gboxBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLiras
            // 
            this.btnLiras.Location = new System.Drawing.Point(59, 175);
            this.btnLiras.Name = "btnLiras";
            this.btnLiras.Size = new System.Drawing.Size(125, 29);
            this.btnLiras.TabIndex = 4;
            this.btnLiras.Text = "Liras";
            this.btnLiras.UseVisualStyleBackColor = true;
            this.btnLiras.Click += new System.EventHandler(this.btnDolares_Click);
            // 
            // btnDolares
            // 
            this.btnDolares.Location = new System.Drawing.Point(61, 175);
            this.btnDolares.Name = "btnDolares";
            this.btnDolares.Size = new System.Drawing.Size(125, 29);
            this.btnDolares.TabIndex = 5;
            this.btnDolares.Text = "Dolares";
            this.btnDolares.UseVisualStyleBackColor = true;
            this.btnDolares.Click += new System.EventHandler(this.btnLiras_Click);
            // 
            // gboxDolares
            // 
            this.gboxDolares.Controls.Add(this.lblResultadoDolar);
            this.gboxDolares.Controls.Add(this.label1);
            this.gboxDolares.Controls.Add(this.txtDolares);
            this.gboxDolares.Controls.Add(this.btnLiras);
            this.gboxDolares.Location = new System.Drawing.Point(26, 108);
            this.gboxDolares.Name = "gboxDolares";
            this.gboxDolares.Size = new System.Drawing.Size(245, 237);
            this.gboxDolares.TabIndex = 7;
            this.gboxDolares.TabStop = false;
            this.gboxDolares.Text = "Dolares > Liras";
            this.gboxDolares.Enter += new System.EventHandler(this.gboxDolares_Enter);
            // 
            // lblResultadoDolar
            // 
            this.lblResultadoDolar.AutoSize = true;
            this.lblResultadoDolar.Location = new System.Drawing.Point(27, 119);
            this.lblResultadoDolar.Name = "lblResultadoDolar";
            this.lblResultadoDolar.Size = new System.Drawing.Size(75, 20);
            this.lblResultadoDolar.TabIndex = 8;
            this.lblResultadoDolar.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dolares";
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(95, 39);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(125, 27);
            this.txtDolares.TabIndex = 5;
            this.txtDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gboxLiras
            // 
            this.gboxLiras.Controls.Add(this.lblResultadoLiras);
            this.gboxLiras.Controls.Add(this.txtLiras);
            this.gboxLiras.Controls.Add(this.label3);
            this.gboxLiras.Controls.Add(this.btnDolares);
            this.gboxLiras.Location = new System.Drawing.Point(300, 108);
            this.gboxLiras.Name = "gboxLiras";
            this.gboxLiras.Size = new System.Drawing.Size(245, 237);
            this.gboxLiras.TabIndex = 8;
            this.gboxLiras.TabStop = false;
            this.gboxLiras.Text = "Liras > Dolares";
            // 
            // lblResultadoLiras
            // 
            this.lblResultadoLiras.AutoSize = true;
            this.lblResultadoLiras.Location = new System.Drawing.Point(23, 119);
            this.lblResultadoLiras.Name = "lblResultadoLiras";
            this.lblResultadoLiras.Size = new System.Drawing.Size(75, 20);
            this.lblResultadoLiras.TabIndex = 8;
            this.lblResultadoLiras.Text = "Resultado";
            // 
            // txtLiras
            // 
            this.txtLiras.Location = new System.Drawing.Point(89, 39);
            this.txtLiras.Name = "txtLiras";
            this.txtLiras.Size = new System.Drawing.Size(125, 27);
            this.txtLiras.TabIndex = 7;
            this.txtLiras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liras";
            // 
            // gboxBienvenida
            // 
            this.gboxBienvenida.Controls.Add(this.btnBienvenido);
            this.gboxBienvenida.Location = new System.Drawing.Point(52, 21);
            this.gboxBienvenida.Name = "gboxBienvenida";
            this.gboxBienvenida.Size = new System.Drawing.Size(480, 68);
            this.gboxBienvenida.TabIndex = 9;
            this.gboxBienvenida.TabStop = false;
            // 
            // btnBienvenido
            // 
            this.btnBienvenido.Location = new System.Drawing.Point(53, 23);
            this.btnBienvenido.Name = "btnBienvenido";
            this.btnBienvenido.Size = new System.Drawing.Size(381, 29);
            this.btnBienvenido.TabIndex = 0;
            this.btnBienvenido.Text = "Bienvenido";
            this.btnBienvenido.UseVisualStyleBackColor = true;
            this.btnBienvenido.Click += new System.EventHandler(this.btnBienvenido_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 369);
            this.Controls.Add(this.gboxBienvenida);
            this.Controls.Add(this.gboxLiras);
            this.Controls.Add(this.gboxDolares);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxDolares.ResumeLayout(false);
            this.gboxDolares.PerformLayout();
            this.gboxLiras.ResumeLayout(false);
            this.gboxLiras.PerformLayout();
            this.gboxBienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnLiras;
        private Button btnDolares;
        private GroupBox gboxDolares;
        private GroupBox gboxLiras;
        private GroupBox gboxBienvenida;
        private Button btnBienvenido;
        private Label label1;
        private TextBox txtDolares;
        private Label lblResultadoDolar;
        private Label lblResultadoLiras;
        private TextBox txtLiras;
        private Label label3;
    }
}