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
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxBusqueda = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(459, 329);
            this.panel1.TabIndex = 0;
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
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(81, 57);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(277, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
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
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(344, 135);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudios.TabIndex = 6;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
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
            // listBoxBusqueda
            // 
            this.listBoxBusqueda.FormattingEnabled = true;
            this.listBoxBusqueda.Location = new System.Drawing.Point(166, 180);
            this.listBoxBusqueda.Name = "listBoxBusqueda";
            this.listBoxBusqueda.Size = new System.Drawing.Size(120, 95);
            this.listBoxBusqueda.TabIndex = 8;
            this.listBoxBusqueda.SelectedIndexChanged += new System.EventHandler(this.listBoxBusqueda_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 375);
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
    }
}

