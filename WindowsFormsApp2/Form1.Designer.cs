namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxBusqueda = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.listBoxPersonas = new System.Windows.Forms.ListBox();
            this.listBoxDirectores = new System.Windows.Forms.ListBox();
            this.listBoxProductores = new System.Windows.Forms.ListBox();
            this.listBoxEstudios = new System.Windows.Forms.ListBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVolver);
            this.panel1.Controls.Add(this.listBoxPeliculas);
            this.panel1.Controls.Add(this.listBoxEstudios);
            this.panel1.Controls.Add(this.listBoxProductores);
            this.panel1.Controls.Add(this.listBoxDirectores);
            this.panel1.Controls.Add(this.listBoxPersonas);
            this.panel1.Controls.Add(this.listBoxBusqueda);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.buttonEstudios);
            this.panel1.Controls.Add(this.buttonProductores);
            this.panel1.Controls.Add(this.buttonDirectores);
            this.panel1.Controls.Add(this.buttonActores);
            this.panel1.Controls.Add(this.buttonPeliculas);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Location = new System.Drawing.Point(21, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 334);
            this.panel1.TabIndex = 0;
            // 
            // listBoxBusqueda
            // 
            this.listBoxBusqueda.FormattingEnabled = true;
            this.listBoxBusqueda.Location = new System.Drawing.Point(152, 234);
            this.listBoxBusqueda.Name = "listBoxBusqueda";
            this.listBoxBusqueda.Size = new System.Drawing.Size(120, 95);
            this.listBoxBusqueda.TabIndex = 8;
            this.listBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.listBoxBusqueda_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(364, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(344, 135);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudios.TabIndex = 6;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(263, 135);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(75, 23);
            this.buttonProductores.TabIndex = 5;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(182, 135);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(75, 23);
            this.buttonDirectores.TabIndex = 4;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(101, 135);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(75, 23);
            this.buttonActores.TabIndex = 3;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(20, 135);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.buttonPeliculas.TabIndex = 2;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(81, 57);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(277, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(31, 60);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // listBoxPersonas
            // 
            this.listBoxPersonas.FormattingEnabled = true;
            this.listBoxPersonas.Location = new System.Drawing.Point(101, 180);
            this.listBoxPersonas.Name = "listBoxPersonas";
            this.listBoxPersonas.Size = new System.Drawing.Size(120, 95);
            this.listBoxPersonas.TabIndex = 9;
            this.listBoxPersonas.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonas_SelectedIndexChanged);
            // 
            // listBoxDirectores
            // 
            this.listBoxDirectores.FormattingEnabled = true;
            this.listBoxDirectores.Location = new System.Drawing.Point(182, 180);
            this.listBoxDirectores.Name = "listBoxDirectores";
            this.listBoxDirectores.Size = new System.Drawing.Size(120, 95);
            this.listBoxDirectores.TabIndex = 10;
            this.listBoxDirectores.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectores_SelectedIndexChanged);
            // 
            // listBoxProductores
            // 
            this.listBoxProductores.FormattingEnabled = true;
            this.listBoxProductores.Location = new System.Drawing.Point(263, 180);
            this.listBoxProductores.Name = "listBoxProductores";
            this.listBoxProductores.Size = new System.Drawing.Size(120, 95);
            this.listBoxProductores.TabIndex = 11;
            this.listBoxProductores.SelectedIndexChanged += new System.EventHandler(this.listBoxProductores_SelectedIndexChanged);
            // 
            // listBoxEstudios
            // 
            this.listBoxEstudios.FormattingEnabled = true;
            this.listBoxEstudios.Location = new System.Drawing.Point(344, 180);
            this.listBoxEstudios.Name = "listBoxEstudios";
            this.listBoxEstudios.Size = new System.Drawing.Size(120, 95);
            this.listBoxEstudios.TabIndex = 12;
            this.listBoxEstudios.SelectedIndexChanged += new System.EventHandler(this.listBoxEstudios_SelectedIndexChanged);
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.Location = new System.Drawing.Point(20, 180);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(120, 95);
            this.listBoxPeliculas.TabIndex = 13;
            this.listBoxPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxPeliculas_SelectedIndexChanged);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(389, 308);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 394);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxBusqueda;
        private System.Windows.Forms.ListBox listBoxPersonas;
        private System.Windows.Forms.ListBox listBoxDirectores;
        private System.Windows.Forms.ListBox listBoxProductores;
        private System.Windows.Forms.ListBox listBoxEstudios;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.Button buttonVolver;
    }
}

