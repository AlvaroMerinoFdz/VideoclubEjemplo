
namespace VideoclubEjemplo
{
    partial class frmPanelPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSocios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPeliculas = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlquileres = new System.Windows.Forms.ToolStripButton();
            this.tsbtnListados = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSocios,
            this.tsbtnPeliculas,
            this.tsbtnAlquileres,
            this.tsbtnListados,
            this.tsbtnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1151, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSocios
            // 
            this.tsbtnSocios.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSocios.Image")));
            this.tsbtnSocios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSocios.Name = "tsbtnSocios";
            this.tsbtnSocios.Size = new System.Drawing.Size(45, 35);
            this.tsbtnSocios.Text = "Socios";
            this.tsbtnSocios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSocios.Click += new System.EventHandler(this.tsbtnSocios_Click);
            // 
            // tsbtnPeliculas
            // 
            this.tsbtnPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPeliculas.Image")));
            this.tsbtnPeliculas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPeliculas.Name = "tsbtnPeliculas";
            this.tsbtnPeliculas.Size = new System.Drawing.Size(57, 35);
            this.tsbtnPeliculas.Text = "Peliculas";
            this.tsbtnPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPeliculas.Click += new System.EventHandler(this.tsbtnPeliculas_Click);
            // 
            // tsbtnAlquileres
            // 
            this.tsbtnAlquileres.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlquileres.Image")));
            this.tsbtnAlquileres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlquileres.Name = "tsbtnAlquileres";
            this.tsbtnAlquileres.Size = new System.Drawing.Size(63, 35);
            this.tsbtnAlquileres.Text = "Alquileres";
            this.tsbtnAlquileres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAlquileres.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnListados
            // 
            this.tsbtnListados.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnListados.Image")));
            this.tsbtnListados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnListados.Name = "tsbtnListados";
            this.tsbtnListados.Size = new System.Drawing.Size(54, 35);
            this.tsbtnListados.Text = "Listados";
            this.tsbtnListados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnListados.Click += new System.EventHandler(this.tsbtnListados_Click);
            // 
            // tsbtnSalir
            // 
            this.tsbtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalir.Image")));
            this.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalir.Name = "tsbtnSalir";
            this.tsbtnSalir.Size = new System.Drawing.Size(33, 35);
            this.tsbtnSalir.Text = "Salir";
            this.tsbtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSalir.Click += new System.EventHandler(this.tsbtnSalir_Click);
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 613);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPanelPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSocios;
        private System.Windows.Forms.ToolStripButton tsbtnPeliculas;
        private System.Windows.Forms.ToolStripButton tsbtnAlquileres;
        private System.Windows.Forms.ToolStripButton tsbtnListados;
        private System.Windows.Forms.ToolStripButton tsbtnSalir;
    }
}