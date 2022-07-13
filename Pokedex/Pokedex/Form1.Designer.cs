namespace Pokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pboxPokedex = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPokedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxPokedex
            // 
            this.pboxPokedex.Image = global::Pokedex.Properties.Resources.plantilla;
            this.pboxPokedex.Location = new System.Drawing.Point(0, 1);
            this.pboxPokedex.Name = "pboxPokedex";
            this.pboxPokedex.Size = new System.Drawing.Size(794, 420);
            this.pboxPokedex.TabIndex = 0;
            this.pboxPokedex.TabStop = false;
            this.pboxPokedex.Click += new System.EventHandler(this.pboxPokedex_Click);
            this.pboxPokedex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pboxPokedex_MouseDown);
            this.pboxPokedex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxPokedex_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(72, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.btnDerecha.FlatAppearance.BorderSize = 0;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Image = global::Pokedex.Properties.Resources.btn_der;
            this.btnDerecha.Location = new System.Drawing.Point(319, 345);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(34, 27);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Pokedex.Properties.Resources.btn_izq;
            this.button1.Location = new System.Drawing.Point(261, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Pokedex.Properties.Resources.btn_apagado;
            this.button2.Location = new System.Drawing.Point(44, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 37);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(528, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(150, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Pokedex.Properties.Resources.btn_arr;
            this.button3.Location = new System.Drawing.Point(291, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 27);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Pokedex.Properties.Resources.btn_abj;
            this.button4.Location = new System.Drawing.Point(291, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 27);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Image = global::Pokedex.Properties.Resources.btn_characteristic;
            this.btnDetalles.Location = new System.Drawing.Point(512, 382);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(88, 27);
            this.btnDetalles.TabIndex = 10;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Pokedex.Properties.Resources.btn_der;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Pokedex.Properties.Resources.btn_characteristic;
            this.button5.Location = new System.Drawing.Point(629, 382);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 27);
            this.button5.TabIndex = 11;
            this.button5.Text = "Detalles";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 421);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pboxPokedex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPokedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pboxPokedex;
        private PictureBox pictureBox1;
        private Button btnDerecha;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button btnDetalles;
        private Button button5;
    }
}