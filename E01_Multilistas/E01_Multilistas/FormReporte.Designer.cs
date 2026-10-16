namespace E01_Multilistas
{
    partial class FormReporte
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
            this.btnObtenerAlbumConMasHeroe = new System.Windows.Forms.Button();
            this.btnListarAbumSegunHeroes = new System.Windows.Forms.Button();
            this.btnObtenerHeroeConMenorPoder = new System.Windows.Forms.Button();
            this.btnObtenerHeroeConMayorPoder = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigoHeroe = new System.Windows.Forms.TextBox();
            this.tbCodigoAlbum = new System.Windows.Forms.TextBox();
            this.dgvHeroes = new System.Windows.Forms.DataGridView();
            this.dgvAlbumes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtenerAlbumConMasHeroe
            // 
            this.btnObtenerAlbumConMasHeroe.Location = new System.Drawing.Point(28, 160);
            this.btnObtenerAlbumConMasHeroe.Name = "btnObtenerAlbumConMasHeroe";
            this.btnObtenerAlbumConMasHeroe.Size = new System.Drawing.Size(164, 44);
            this.btnObtenerAlbumConMasHeroe.TabIndex = 0;
            this.btnObtenerAlbumConMasHeroe.Text = "Obtener album con más Heroe";
            this.btnObtenerAlbumConMasHeroe.UseVisualStyleBackColor = true;
            this.btnObtenerAlbumConMasHeroe.Click += new System.EventHandler(this.btnObtenerAlbumConMasHeroe_Click);
            // 
            // btnListarAbumSegunHeroes
            // 
            this.btnListarAbumSegunHeroes.Location = new System.Drawing.Point(224, 160);
            this.btnListarAbumSegunHeroes.Name = "btnListarAbumSegunHeroes";
            this.btnListarAbumSegunHeroes.Size = new System.Drawing.Size(164, 44);
            this.btnListarAbumSegunHeroes.TabIndex = 1;
            this.btnListarAbumSegunHeroes.Text = "Listar albumes segun heroes";
            this.btnListarAbumSegunHeroes.UseVisualStyleBackColor = true;
            this.btnListarAbumSegunHeroes.Click += new System.EventHandler(this.btnListarAbumSegunHeroes_Click);
            // 
            // btnObtenerHeroeConMenorPoder
            // 
            this.btnObtenerHeroeConMenorPoder.Location = new System.Drawing.Point(428, 160);
            this.btnObtenerHeroeConMenorPoder.Name = "btnObtenerHeroeConMenorPoder";
            this.btnObtenerHeroeConMenorPoder.Size = new System.Drawing.Size(164, 44);
            this.btnObtenerHeroeConMenorPoder.TabIndex = 2;
            this.btnObtenerHeroeConMenorPoder.Text = "Obtener heroes con menor poder";
            this.btnObtenerHeroeConMenorPoder.UseVisualStyleBackColor = true;
            this.btnObtenerHeroeConMenorPoder.Click += new System.EventHandler(this.btnObtenerHeroeConMenorPoder_Click);
            // 
            // btnObtenerHeroeConMayorPoder
            // 
            this.btnObtenerHeroeConMayorPoder.Location = new System.Drawing.Point(624, 160);
            this.btnObtenerHeroeConMayorPoder.Name = "btnObtenerHeroeConMayorPoder";
            this.btnObtenerHeroeConMayorPoder.Size = new System.Drawing.Size(164, 44);
            this.btnObtenerHeroeConMayorPoder.TabIndex = 3;
            this.btnObtenerHeroeConMayorPoder.Text = "Obtener heroe con mayor poder";
            this.btnObtenerHeroeConMayorPoder.UseVisualStyleBackColor = true;
            this.btnObtenerHeroeConMayorPoder.Click += new System.EventHandler(this.btnObtenerHeroeConMayorPoder_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(624, 34);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 71);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo de heroe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo de album:";
            // 
            // tbCodigoHeroe
            // 
            this.tbCodigoHeroe.Location = new System.Drawing.Point(172, 34);
            this.tbCodigoHeroe.Name = "tbCodigoHeroe";
            this.tbCodigoHeroe.Size = new System.Drawing.Size(152, 22);
            this.tbCodigoHeroe.TabIndex = 7;
            // 
            // tbCodigoAlbum
            // 
            this.tbCodigoAlbum.Location = new System.Drawing.Point(172, 106);
            this.tbCodigoAlbum.Name = "tbCodigoAlbum";
            this.tbCodigoAlbum.Size = new System.Drawing.Size(152, 22);
            this.tbCodigoAlbum.TabIndex = 8;
            // 
            // dgvHeroes
            // 
            this.dgvHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeroes.Location = new System.Drawing.Point(403, 211);
            this.dgvHeroes.Name = "dgvHeroes";
            this.dgvHeroes.RowHeadersWidth = 51;
            this.dgvHeroes.RowTemplate.Height = 24;
            this.dgvHeroes.Size = new System.Drawing.Size(390, 228);
            this.dgvHeroes.TabIndex = 16;
            // 
            // dgvAlbumes
            // 
            this.dgvAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumes.Location = new System.Drawing.Point(7, 210);
            this.dgvAlbumes.Name = "dgvAlbumes";
            this.dgvAlbumes.RowHeadersWidth = 51;
            this.dgvAlbumes.RowTemplate.Height = 24;
            this.dgvAlbumes.Size = new System.Drawing.Size(390, 228);
            this.dgvAlbumes.TabIndex = 17;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.dgvAlbumes);
            this.Controls.Add(this.dgvHeroes);
            this.Controls.Add(this.tbCodigoAlbum);
            this.Controls.Add(this.tbCodigoHeroe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnObtenerHeroeConMayorPoder);
            this.Controls.Add(this.btnObtenerHeroeConMenorPoder);
            this.Controls.Add(this.btnListarAbumSegunHeroes);
            this.Controls.Add(this.btnObtenerAlbumConMasHeroe);
            this.Name = "FormReporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerAlbumConMasHeroe;
        private System.Windows.Forms.Button btnListarAbumSegunHeroes;
        private System.Windows.Forms.Button btnObtenerHeroeConMenorPoder;
        private System.Windows.Forms.Button btnObtenerHeroeConMayorPoder;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodigoHeroe;
        private System.Windows.Forms.TextBox tbCodigoAlbum;
        private System.Windows.Forms.DataGridView dgvHeroes;
        private System.Windows.Forms.DataGridView dgvAlbumes;
    }
}