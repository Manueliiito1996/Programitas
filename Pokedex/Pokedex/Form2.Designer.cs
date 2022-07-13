namespace Pokedex
{
    partial class Form2
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
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.lblPokemon = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblNamePokemon = new System.Windows.Forms.Label();
            this.lblBaseExperience = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCharacteristic = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImages
            // 
            this.pbImages.Location = new System.Drawing.Point(25, 74);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(242, 218);
            this.pbImages.TabIndex = 0;
            this.pbImages.TabStop = false;
            // 
            // lblPokemon
            // 
            this.lblPokemon.AutoSize = true;
            this.lblPokemon.Location = new System.Drawing.Point(295, 122);
            this.lblPokemon.Name = "lblPokemon";
            this.lblPokemon.Size = new System.Drawing.Size(70, 20);
            this.lblPokemon.TabIndex = 1;
            this.lblPokemon.Text = "Pokemon";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(295, 156);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(120, 20);
            this.lblExperiencia.TabIndex = 2;
            this.lblExperiencia.Text = "Experiencia Base";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(295, 190);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(61, 20);
            this.lblTamaño.TabIndex = 3;
            this.lblTamaño.Text = "Tamaño";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(295, 223);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 20);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // lblNamePokemon
            // 
            this.lblNamePokemon.AutoSize = true;
            this.lblNamePokemon.Location = new System.Drawing.Point(430, 122);
            this.lblNamePokemon.Name = "lblNamePokemon";
            this.lblNamePokemon.Size = new System.Drawing.Size(50, 20);
            this.lblNamePokemon.TabIndex = 5;
            this.lblNamePokemon.Text = "label1";
            // 
            // lblBaseExperience
            // 
            this.lblBaseExperience.AutoSize = true;
            this.lblBaseExperience.Location = new System.Drawing.Point(430, 156);
            this.lblBaseExperience.Name = "lblBaseExperience";
            this.lblBaseExperience.Size = new System.Drawing.Size(50, 20);
            this.lblBaseExperience.TabIndex = 6;
            this.lblBaseExperience.Text = "label2";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(430, 190);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(50, 20);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "label3";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(430, 223);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(50, 20);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "label4";
            // 
            // lblCharacteristic
            // 
            this.lblCharacteristic.AutoSize = true;
            this.lblCharacteristic.Location = new System.Drawing.Point(236, 26);
            this.lblCharacteristic.Name = "lblCharacteristic";
            this.lblCharacteristic.Size = new System.Drawing.Size(98, 20);
            this.lblCharacteristic.TabIndex = 9;
            this.lblCharacteristic.Text = "Characteristic";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(373, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 36);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 362);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCharacteristic);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblBaseExperience);
            this.Controls.Add(this.lblNamePokemon);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblPokemon);
            this.Controls.Add(this.pbImages);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbImages;
        private Label lblPokemon;
        private Label lblExperiencia;
        private Label lblTamaño;
        private Label lblPeso;
        private Label lblNamePokemon;
        private Label lblBaseExperience;
        private Label lblHeight;
        private Label lblWeight;
        private Label lblCharacteristic;
        private Button btnSalir;
    }
}