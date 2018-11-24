namespace TFComplejidadAlgoritmica
{
    partial class Form1
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
            this.mapaFormulario = new GMap.NET.WindowsForms.GMapControl();
            this.btnFiltrarTodosCentrosPoblados = new System.Windows.Forms.Button();
            this.btnFiltrarCentrosPobladosCapitalesDistrito = new System.Windows.Forms.Button();
            this.btnFiltrarCentrosPobladosCapitalesProvincia = new System.Windows.Forms.Button();
            this.btnFiltrarCentrosPobladosCapitalesRegion = new System.Windows.Forms.Button();
            this.btnFiltrarCentrosPobladosNoCapitales = new System.Windows.Forms.Button();
            this.btnFiltrarCentrosEducativos = new System.Windows.Forms.Button();
            this.btnFiltrarCentrosEducativosPorDistrito = new System.Windows.Forms.Button();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.btnFiltrarCentrosEducativosPorRegion = new System.Windows.Forms.Button();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnFiltrarCentrosEducativosPorProvincia = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // mapaFormulario
            // 
            this.mapaFormulario.Bearing = 0F;
            this.mapaFormulario.CanDragMap = true;
            this.mapaFormulario.Dock = System.Windows.Forms.DockStyle.Left;
            this.mapaFormulario.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapaFormulario.GrayScaleMode = false;
            this.mapaFormulario.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapaFormulario.LevelsKeepInMemmory = 5;
            this.mapaFormulario.Location = new System.Drawing.Point(0, 0);
            this.mapaFormulario.MarkersEnabled = true;
            this.mapaFormulario.MaxZoom = 2;
            this.mapaFormulario.MinZoom = 2;
            this.mapaFormulario.MouseWheelZoomEnabled = true;
            this.mapaFormulario.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapaFormulario.Name = "mapaFormulario";
            this.mapaFormulario.NegativeMode = false;
            this.mapaFormulario.PolygonsEnabled = true;
            this.mapaFormulario.RetryLoadTile = 0;
            this.mapaFormulario.RoutesEnabled = true;
            this.mapaFormulario.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapaFormulario.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapaFormulario.ShowTileGridLines = false;
            this.mapaFormulario.Size = new System.Drawing.Size(926, 1055);
            this.mapaFormulario.TabIndex = 0;
            this.mapaFormulario.Zoom = 0D;
            // 
            // btnFiltrarTodosCentrosPoblados
            // 
            this.btnFiltrarTodosCentrosPoblados.Location = new System.Drawing.Point(946, 298);
            this.btnFiltrarTodosCentrosPoblados.Name = "btnFiltrarTodosCentrosPoblados";
            this.btnFiltrarTodosCentrosPoblados.Size = new System.Drawing.Size(228, 72);
            this.btnFiltrarTodosCentrosPoblados.TabIndex = 1;
            this.btnFiltrarTodosCentrosPoblados.Text = "Filtrar Todos Centros Poblados";
            this.btnFiltrarTodosCentrosPoblados.UseVisualStyleBackColor = true;
            this.btnFiltrarTodosCentrosPoblados.Click += new System.EventHandler(this.btnFiltrarTodosCentrosPoblados_Click);
            // 
            // btnFiltrarCentrosPobladosCapitalesDistrito
            // 
            this.btnFiltrarCentrosPobladosCapitalesDistrito.Location = new System.Drawing.Point(946, 532);
            this.btnFiltrarCentrosPobladosCapitalesDistrito.Name = "btnFiltrarCentrosPobladosCapitalesDistrito";
            this.btnFiltrarCentrosPobladosCapitalesDistrito.Size = new System.Drawing.Size(228, 72);
            this.btnFiltrarCentrosPobladosCapitalesDistrito.TabIndex = 2;
            this.btnFiltrarCentrosPobladosCapitalesDistrito.Text = "Filtrar Centros Poblados Capitales De Distrito";
            this.btnFiltrarCentrosPobladosCapitalesDistrito.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosPobladosCapitalesDistrito.Click += new System.EventHandler(this.btnFiltrarCentrosPobladosCapitalesDistrito_Click);
            // 
            // btnFiltrarCentrosPobladosCapitalesProvincia
            // 
            this.btnFiltrarCentrosPobladosCapitalesProvincia.Location = new System.Drawing.Point(946, 454);
            this.btnFiltrarCentrosPobladosCapitalesProvincia.Name = "btnFiltrarCentrosPobladosCapitalesProvincia";
            this.btnFiltrarCentrosPobladosCapitalesProvincia.Size = new System.Drawing.Size(228, 72);
            this.btnFiltrarCentrosPobladosCapitalesProvincia.TabIndex = 3;
            this.btnFiltrarCentrosPobladosCapitalesProvincia.Text = "Filtrar Centros Poblados Capitales De Provincia";
            this.btnFiltrarCentrosPobladosCapitalesProvincia.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosPobladosCapitalesProvincia.Click += new System.EventHandler(this.btnFiltrarCentrosPobladosCapitalesProvincia_Click);
            // 
            // btnFiltrarCentrosPobladosCapitalesRegion
            // 
            this.btnFiltrarCentrosPobladosCapitalesRegion.Location = new System.Drawing.Point(946, 376);
            this.btnFiltrarCentrosPobladosCapitalesRegion.Name = "btnFiltrarCentrosPobladosCapitalesRegion";
            this.btnFiltrarCentrosPobladosCapitalesRegion.Size = new System.Drawing.Size(228, 72);
            this.btnFiltrarCentrosPobladosCapitalesRegion.TabIndex = 4;
            this.btnFiltrarCentrosPobladosCapitalesRegion.Text = "Filtrar Centros Poblados Capitales De Region";
            this.btnFiltrarCentrosPobladosCapitalesRegion.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosPobladosCapitalesRegion.Click += new System.EventHandler(this.btnFiltrarCentrosPobladosCapitalesRegion_Click);
            // 
            // btnFiltrarCentrosPobladosNoCapitales
            // 
            this.btnFiltrarCentrosPobladosNoCapitales.Location = new System.Drawing.Point(946, 610);
            this.btnFiltrarCentrosPobladosNoCapitales.Name = "btnFiltrarCentrosPobladosNoCapitales";
            this.btnFiltrarCentrosPobladosNoCapitales.Size = new System.Drawing.Size(228, 72);
            this.btnFiltrarCentrosPobladosNoCapitales.TabIndex = 5;
            this.btnFiltrarCentrosPobladosNoCapitales.Text = "Filtrar Centros Poblados Que No Son Capitales";
            this.btnFiltrarCentrosPobladosNoCapitales.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosPobladosNoCapitales.Click += new System.EventHandler(this.btnFiltrarCentrosPobladosNoCapitales_Click);
            // 
            // btnFiltrarCentrosEducativos
            // 
            this.btnFiltrarCentrosEducativos.Location = new System.Drawing.Point(946, 688);
            this.btnFiltrarCentrosEducativos.Name = "btnFiltrarCentrosEducativos";
            this.btnFiltrarCentrosEducativos.Size = new System.Drawing.Size(228, 72);
            this.btnFiltrarCentrosEducativos.TabIndex = 6;
            this.btnFiltrarCentrosEducativos.Text = "Filtrar Centros Educativos";
            this.btnFiltrarCentrosEducativos.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosEducativos.Click += new System.EventHandler(this.btnFiltrarCentrosEducativos_Click);
            // 
            // btnFiltrarCentrosEducativosPorDistrito
            // 
            this.btnFiltrarCentrosEducativosPorDistrito.Location = new System.Drawing.Point(1224, 75);
            this.btnFiltrarCentrosEducativosPorDistrito.Name = "btnFiltrarCentrosEducativosPorDistrito";
            this.btnFiltrarCentrosEducativosPorDistrito.Size = new System.Drawing.Size(239, 62);
            this.btnFiltrarCentrosEducativosPorDistrito.TabIndex = 7;
            this.btnFiltrarCentrosEducativosPorDistrito.Text = "Filtrar Centros Educativos Por Distrito";
            this.btnFiltrarCentrosEducativosPorDistrito.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosEducativosPorDistrito.Click += new System.EventHandler(this.btnFiltrarCentrosEducativosPorDistrito_Click);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(1218, 25);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(56, 17);
            this.lblDistrito.TabIndex = 8;
            this.lblDistrito.Text = "Distrito:";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(1307, 25);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(156, 22);
            this.txtDistrito.TabIndex = 9;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(1636, 22);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(156, 22);
            this.txtRegion.TabIndex = 12;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(1547, 22);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(57, 17);
            this.lblRegion.TabIndex = 11;
            this.lblRegion.Text = "Region:";
            // 
            // btnFiltrarCentrosEducativosPorRegion
            // 
            this.btnFiltrarCentrosEducativosPorRegion.Location = new System.Drawing.Point(1553, 72);
            this.btnFiltrarCentrosEducativosPorRegion.Name = "btnFiltrarCentrosEducativosPorRegion";
            this.btnFiltrarCentrosEducativosPorRegion.Size = new System.Drawing.Size(239, 62);
            this.btnFiltrarCentrosEducativosPorRegion.TabIndex = 10;
            this.btnFiltrarCentrosEducativosPorRegion.Text = "Filtrar Centros Educativos Por Region";
            this.btnFiltrarCentrosEducativosPorRegion.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosEducativosPorRegion.Click += new System.EventHandler(this.btnFiltrarCentrosEducativosPorRegion_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(1479, 167);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(156, 22);
            this.txtProvincia.TabIndex = 15;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(1400, 172);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 17);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Provincia:";
            // 
            // btnFiltrarCentrosEducativosPorProvincia
            // 
            this.btnFiltrarCentrosEducativosPorProvincia.Location = new System.Drawing.Point(1406, 222);
            this.btnFiltrarCentrosEducativosPorProvincia.Name = "btnFiltrarCentrosEducativosPorProvincia";
            this.btnFiltrarCentrosEducativosPorProvincia.Size = new System.Drawing.Size(239, 62);
            this.btnFiltrarCentrosEducativosPorProvincia.TabIndex = 13;
            this.btnFiltrarCentrosEducativosPorProvincia.Text = "Filtrar Centros Educativos Por Provincia";
            this.btnFiltrarCentrosEducativosPorProvincia.UseVisualStyleBackColor = true;
            this.btnFiltrarCentrosEducativosPorProvincia.Click += new System.EventHandler(this.btnFiltrarCentrosEducativosPorProvincia_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(1207, 332);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(705, 541);
            this.dgvLista.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.btnFiltrarCentrosEducativosPorProvincia);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.btnFiltrarCentrosEducativosPorRegion);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.btnFiltrarCentrosEducativosPorDistrito);
            this.Controls.Add(this.btnFiltrarCentrosEducativos);
            this.Controls.Add(this.btnFiltrarCentrosPobladosNoCapitales);
            this.Controls.Add(this.btnFiltrarCentrosPobladosCapitalesRegion);
            this.Controls.Add(this.btnFiltrarCentrosPobladosCapitalesProvincia);
            this.Controls.Add(this.btnFiltrarCentrosPobladosCapitalesDistrito);
            this.Controls.Add(this.btnFiltrarTodosCentrosPoblados);
            this.Controls.Add(this.mapaFormulario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapaFormulario;
        private System.Windows.Forms.Button btnFiltrarTodosCentrosPoblados;
        private System.Windows.Forms.Button btnFiltrarCentrosPobladosCapitalesDistrito;
        private System.Windows.Forms.Button btnFiltrarCentrosPobladosCapitalesProvincia;
        private System.Windows.Forms.Button btnFiltrarCentrosPobladosCapitalesRegion;
        private System.Windows.Forms.Button btnFiltrarCentrosPobladosNoCapitales;
        private System.Windows.Forms.Button btnFiltrarCentrosEducativos;
        private System.Windows.Forms.Button btnFiltrarCentrosEducativosPorDistrito;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Button btnFiltrarCentrosEducativosPorRegion;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnFiltrarCentrosEducativosPorProvincia;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}

