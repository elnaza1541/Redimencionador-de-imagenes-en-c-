namespace redimencion
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
            this.txtRutaOrigen = new System.Windows.Forms.TextBox();
            this.btnCarpetaOrigen = new System.Windows.Forms.Button();
            this.txtRutaDestino = new System.Windows.Forms.TextBox();
            this.btnCarpetaDestino = new System.Windows.Forms.Button();
            this.nupAncho = new System.Windows.Forms.NumericUpDown();
            this.nupAlto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbprogreso = new System.Windows.Forms.ProgressBar();
            this.btnRedimensionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomenclatura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAlto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutaOrigen
            // 
            this.txtRutaOrigen.Location = new System.Drawing.Point(118, 15);
            this.txtRutaOrigen.Name = "txtRutaOrigen";
            this.txtRutaOrigen.Size = new System.Drawing.Size(456, 23);
            this.txtRutaOrigen.TabIndex = 0;
            // 
            // btnCarpetaOrigen
            // 
            this.btnCarpetaOrigen.Location = new System.Drawing.Point(601, 15);
            this.btnCarpetaOrigen.Name = "btnCarpetaOrigen";
            this.btnCarpetaOrigen.Size = new System.Drawing.Size(100, 23);
            this.btnCarpetaOrigen.TabIndex = 1;
            this.btnCarpetaOrigen.Text = "Carpeta Origen";
            this.btnCarpetaOrigen.UseVisualStyleBackColor = true;
            this.btnCarpetaOrigen.Click += new System.EventHandler(this.btnCarpetaOrigen_Click);
            // 
            // txtRutaDestino
            // 
            this.txtRutaDestino.Location = new System.Drawing.Point(118, 61);
            this.txtRutaDestino.Name = "txtRutaDestino";
            this.txtRutaDestino.Size = new System.Drawing.Size(456, 23);
            this.txtRutaDestino.TabIndex = 2;
            // 
            // btnCarpetaDestino
            // 
            this.btnCarpetaDestino.Location = new System.Drawing.Point(601, 61);
            this.btnCarpetaDestino.Name = "btnCarpetaDestino";
            this.btnCarpetaDestino.Size = new System.Drawing.Size(100, 23);
            this.btnCarpetaDestino.TabIndex = 3;
            this.btnCarpetaDestino.Text = "Carpeta Destino";
            this.btnCarpetaDestino.UseVisualStyleBackColor = true;
            this.btnCarpetaDestino.Click += new System.EventHandler(this.btnCarpetaDestino_Click);
            // 
            // nupAncho
            // 
            this.nupAncho.Location = new System.Drawing.Point(361, 99);
            this.nupAncho.Name = "nupAncho";
            this.nupAncho.Size = new System.Drawing.Size(78, 23);
            this.nupAncho.TabIndex = 4;
            this.nupAncho.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupAncho.ValueChanged += new System.EventHandler(this.nupAncho_ValueChanged);
            // 
            // nupAlto
            // 
            this.nupAlto.Location = new System.Drawing.Point(496, 99);
            this.nupAlto.Name = "nupAlto";
            this.nupAlto.Size = new System.Drawing.Size(78, 23);
            this.nupAlto.TabIndex = 5;
            this.nupAlto.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ancho";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carpeta de Origen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Carpeta de destino";
            // 
            // pbprogreso
            // 
            this.pbprogreso.Location = new System.Drawing.Point(118, 142);
            this.pbprogreso.Name = "pbprogreso";
            this.pbprogreso.Size = new System.Drawing.Size(456, 23);
            this.pbprogreso.TabIndex = 10;
            this.pbprogreso.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.Location = new System.Drawing.Point(601, 99);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(100, 23);
            this.btnRedimensionar.TabIndex = 11;
            this.btnRedimensionar.Text = "Redimensionar";
            this.btnRedimensionar.UseVisualStyleBackColor = true;
            this.btnRedimensionar.Click += new System.EventHandler(this.btnRedimensionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nomenclatura";
            // 
            // txtNomenclatura
            // 
            this.txtNomenclatura.Location = new System.Drawing.Point(118, 99);
            this.txtNomenclatura.Name = "txtNomenclatura";
            this.txtNomenclatura.Size = new System.Drawing.Size(121, 23);
            this.txtNomenclatura.TabIndex = 13;
            this.txtNomenclatura.Text = "_thumb";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(765, 191);
            this.Controls.Add(this.txtNomenclatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRedimensionar);
            this.Controls.Add(this.pbprogreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupAlto);
            this.Controls.Add(this.nupAncho);
            this.Controls.Add(this.btnCarpetaDestino);
            this.Controls.Add(this.txtRutaDestino);
            this.Controls.Add(this.btnCarpetaOrigen);
            this.Controls.Add(this.txtRutaOrigen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAlto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRutaOrigen;
        private Button btnCarpetaOrigen;
        private TextBox txtRutaDestino;
        private Button btnCarpetaDestino;
        private NumericUpDown nupAncho;
        private NumericUpDown nupAlto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar pbprogreso;
        private Button btnRedimensionar;
        private Label label5;
        private TextBox txtNomenclatura;
    }
}