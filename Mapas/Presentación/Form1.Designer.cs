namespace Mapas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvPuntosNegros = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonMas = new System.Windows.Forms.Button();
            this.groupBoxMapa = new System.Windows.Forms.GroupBox();
            this.checkBoxRT = new System.Windows.Forms.CheckBox();
            this.checkBoxPN = new System.Windows.Forms.CheckBox();
            this.checkBoxR = new System.Windows.Forms.CheckBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuntosNegros)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBoxMapa.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.DgvPuntosNegros);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta datos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(760, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "Retenciones";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(760, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Radares";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Puntos negros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvPuntosNegros
            // 
            this.DgvPuntosNegros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuntosNegros.Location = new System.Drawing.Point(3, 6);
            this.DgvPuntosNegros.Name = "DgvPuntosNegros";
            this.DgvPuntosNegros.Size = new System.Drawing.Size(703, 407);
            this.DgvPuntosNegros.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.buttonMenos);
            this.tabPage1.Controls.Add(this.buttonMas);
            this.tabPage1.Controls.Add(this.groupBoxMapa);
            this.tabPage1.Controls.Add(this.buttonLimpiar);
            this.tabPage1.Controls.Add(this.gmap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mapa geográfico";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(891, 120);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(45, 254);
            this.trackBar1.TabIndex = 16;
            // 
            // buttonMenos
            // 
            this.buttonMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenos.Location = new System.Drawing.Point(888, 380);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(36, 25);
            this.buttonMenos.TabIndex = 15;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.buttonMenos_Click);
            // 
            // buttonMas
            // 
            this.buttonMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMas.Location = new System.Drawing.Point(888, 89);
            this.buttonMas.Name = "buttonMas";
            this.buttonMas.Size = new System.Drawing.Size(36, 25);
            this.buttonMas.TabIndex = 14;
            this.buttonMas.Text = "+";
            this.buttonMas.UseVisualStyleBackColor = true;
            this.buttonMas.Click += new System.EventHandler(this.buttonMas_Click);
            // 
            // groupBoxMapa
            // 
            this.groupBoxMapa.BackColor = System.Drawing.Color.Snow;
            this.groupBoxMapa.Controls.Add(this.checkBoxRT);
            this.groupBoxMapa.Controls.Add(this.checkBoxPN);
            this.groupBoxMapa.Controls.Add(this.checkBoxR);
            this.groupBoxMapa.Location = new System.Drawing.Point(33, 16);
            this.groupBoxMapa.Name = "groupBoxMapa";
            this.groupBoxMapa.Size = new System.Drawing.Size(352, 51);
            this.groupBoxMapa.TabIndex = 13;
            this.groupBoxMapa.TabStop = false;
            this.groupBoxMapa.Text = "Mapa";
            // 
            // checkBoxRT
            // 
            this.checkBoxRT.AutoSize = true;
            this.checkBoxRT.Checked = true;
            this.checkBoxRT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRT.Location = new System.Drawing.Point(249, 27);
            this.checkBoxRT.Name = "checkBoxRT";
            this.checkBoxRT.Size = new System.Drawing.Size(86, 17);
            this.checkBoxRT.TabIndex = 10;
            this.checkBoxRT.Text = "Retenciones";
            this.checkBoxRT.UseVisualStyleBackColor = true;
            this.checkBoxRT.CheckedChanged += new System.EventHandler(this.checkBoxRT_CheckedChanged);
            this.checkBoxRT.CheckStateChanged += new System.EventHandler(this.checkBoxRT_CheckedChanged);
            // 
            // checkBoxPN
            // 
            this.checkBoxPN.AutoSize = true;
            this.checkBoxPN.Checked = true;
            this.checkBoxPN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPN.Location = new System.Drawing.Point(6, 27);
            this.checkBoxPN.Name = "checkBoxPN";
            this.checkBoxPN.Size = new System.Drawing.Size(94, 17);
            this.checkBoxPN.TabIndex = 8;
            this.checkBoxPN.Text = "Puntos negros";
            this.checkBoxPN.UseVisualStyleBackColor = true;
            this.checkBoxPN.CheckedChanged += new System.EventHandler(this.checkBoxPN_CheckedChanged);
            this.checkBoxPN.CheckStateChanged += new System.EventHandler(this.checkBoxPN_CheckedChanged);
            // 
            // checkBoxR
            // 
            this.checkBoxR.AutoSize = true;
            this.checkBoxR.Checked = true;
            this.checkBoxR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxR.Location = new System.Drawing.Point(145, 27);
            this.checkBoxR.Name = "checkBoxR";
            this.checkBoxR.Size = new System.Drawing.Size(66, 17);
            this.checkBoxR.TabIndex = 9;
            this.checkBoxR.Text = "Radares";
            this.checkBoxR.UseVisualStyleBackColor = true;
            this.checkBoxR.CheckedChanged += new System.EventHandler(this.checkBoxR_CheckedChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(780, 34);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(91, 33);
            this.buttonLimpiar.TabIndex = 12;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.button5_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(33, 89);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 5;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(838, 316);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 5D;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 441);
            this.tabControl1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 449);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GPS TRÁFICO";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuntosNegros)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBoxMapa.ResumeLayout(false);
            this.groupBoxMapa.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.DataGridView DgvPuntosNegros;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.CheckBox checkBoxR;
        private System.Windows.Forms.CheckBox checkBoxRT;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.CheckBox checkBoxPN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBoxMapa;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonMas;
    }
}

