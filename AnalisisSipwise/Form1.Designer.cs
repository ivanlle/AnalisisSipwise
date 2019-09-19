namespace AnalisisSipwise
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Refresco = new System.Windows.Forms.Timer(this.components);
            this.LB_cuentaatras = new System.Windows.Forms.Label();
            this.ch_autorefresco = new System.Windows.Forms.CheckBox();
            this.num_Segundos = new System.Windows.Forms.NumericUpDown();
            this.lb_segundos = new System.Windows.Forms.Label();
            this.txt_srv2 = new System.Windows.Forms.TextBox();
            this.lb_srv2 = new System.Windows.Forms.Label();
            this.lb_srv3 = new System.Windows.Forms.Label();
            this.txt_srv3 = new System.Windows.Forms.TextBox();
            this.lb_srv4 = new System.Windows.Forms.Label();
            this.txt_srv4 = new System.Windows.Forms.TextBox();
            this.lb_srv5 = new System.Windows.Forms.Label();
            this.txt_srv5 = new System.Windows.Forms.TextBox();
            this.lb_srv6 = new System.Windows.Forms.Label();
            this.txt_srv6 = new System.Windows.Forms.TextBox();
            this.btm_refrescar = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_1 = new System.Windows.Forms.TabPage();
            this.tab_2 = new System.Windows.Forms.TabPage();
            this.lb_srv6_2 = new System.Windows.Forms.Label();
            this.btm_refrescar_2 = new System.Windows.Forms.Button();
            this.txt_srv6_2 = new System.Windows.Forms.TextBox();
            this.txt_srv2_2 = new System.Windows.Forms.TextBox();
            this.lb_srv5_2 = new System.Windows.Forms.Label();
            this.ch_autorefresco_2 = new System.Windows.Forms.CheckBox();
            this.txt_srv5_2 = new System.Windows.Forms.TextBox();
            this.txt_srv3_2 = new System.Windows.Forms.TextBox();
            this.lb_srv4_2 = new System.Windows.Forms.Label();
            this.lb_srv3_2 = new System.Windows.Forms.Label();
            this.txt_srv4_2 = new System.Windows.Forms.TextBox();
            this.lb_srv2_2 = new System.Windows.Forms.Label();
            this.LB_cuentaatras_2 = new System.Windows.Forms.Label();
            this.lb_segundos_2 = new System.Windows.Forms.Label();
            this.num_segundos_2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_Segundos)).BeginInit();
            this.tab.SuspendLayout();
            this.tab_1.SuspendLayout();
            this.tab_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_segundos_2)).BeginInit();
            this.SuspendLayout();
            // 
            // Refresco
            // 
            this.Refresco.Interval = 1000;
            this.Refresco.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LB_cuentaatras
            // 
            this.LB_cuentaatras.AutoSize = true;
            this.LB_cuentaatras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_cuentaatras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_cuentaatras.Location = new System.Drawing.Point(316, 27);
            this.LB_cuentaatras.Name = "LB_cuentaatras";
            this.LB_cuentaatras.Size = new System.Drawing.Size(123, 24);
            this.LB_cuentaatras.TabIndex = 1;
            this.LB_cuentaatras.Text = "CuentaAtras";
            // 
            // ch_autorefresco
            // 
            this.ch_autorefresco.AutoSize = true;
            this.ch_autorefresco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_autorefresco.Location = new System.Drawing.Point(26, 25);
            this.ch_autorefresco.Name = "ch_autorefresco";
            this.ch_autorefresco.Size = new System.Drawing.Size(154, 28);
            this.ch_autorefresco.TabIndex = 3;
            this.ch_autorefresco.Text = "Autorefrescar";
            this.ch_autorefresco.UseVisualStyleBackColor = true;
            this.ch_autorefresco.CheckedChanged += new System.EventHandler(this.Ch_autorefresco_CheckedChanged);
            // 
            // num_Segundos
            // 
            this.num_Segundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Segundos.Location = new System.Drawing.Point(26, 85);
            this.num_Segundos.Name = "num_Segundos";
            this.num_Segundos.Size = new System.Drawing.Size(154, 29);
            this.num_Segundos.TabIndex = 4;
            this.num_Segundos.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.num_Segundos.ValueChanged += new System.EventHandler(this.Num_Segundos_ValueChanged);
            // 
            // lb_segundos
            // 
            this.lb_segundos.AutoSize = true;
            this.lb_segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_segundos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_segundos.Location = new System.Drawing.Point(202, 87);
            this.lb_segundos.Name = "lb_segundos";
            this.lb_segundos.Size = new System.Drawing.Size(105, 24);
            this.lb_segundos.TabIndex = 5;
            this.lb_segundos.Text = "Segundos";
            // 
            // txt_srv2
            // 
            this.txt_srv2.Location = new System.Drawing.Point(26, 249);
            this.txt_srv2.Multiline = true;
            this.txt_srv2.Name = "txt_srv2";
            this.txt_srv2.Size = new System.Drawing.Size(187, 375);
            this.txt_srv2.TabIndex = 6;
            // 
            // lb_srv2
            // 
            this.lb_srv2.AutoSize = true;
            this.lb_srv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv2.Location = new System.Drawing.Point(78, 233);
            this.lb_srv2.Name = "lb_srv2";
            this.lb_srv2.Size = new System.Drawing.Size(39, 13);
            this.lb_srv2.TabIndex = 7;
            this.lb_srv2.Text = "SRV2";
            // 
            // lb_srv3
            // 
            this.lb_srv3.AutoSize = true;
            this.lb_srv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv3.Location = new System.Drawing.Point(329, 233);
            this.lb_srv3.Name = "lb_srv3";
            this.lb_srv3.Size = new System.Drawing.Size(39, 13);
            this.lb_srv3.TabIndex = 9;
            this.lb_srv3.Text = "SRV3";
            // 
            // txt_srv3
            // 
            this.txt_srv3.AcceptsReturn = true;
            this.txt_srv3.AcceptsTab = true;
            this.txt_srv3.Location = new System.Drawing.Point(252, 249);
            this.txt_srv3.Multiline = true;
            this.txt_srv3.Name = "txt_srv3";
            this.txt_srv3.Size = new System.Drawing.Size(187, 375);
            this.txt_srv3.TabIndex = 8;
            this.txt_srv3.TextChanged += new System.EventHandler(this.Txt_srv3_TextChanged);
            // 
            // lb_srv4
            // 
            this.lb_srv4.AutoSize = true;
            this.lb_srv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv4.Location = new System.Drawing.Point(551, 233);
            this.lb_srv4.Name = "lb_srv4";
            this.lb_srv4.Size = new System.Drawing.Size(39, 13);
            this.lb_srv4.TabIndex = 11;
            this.lb_srv4.Text = "SRV4";
            // 
            // txt_srv4
            // 
            this.txt_srv4.Location = new System.Drawing.Point(485, 249);
            this.txt_srv4.Multiline = true;
            this.txt_srv4.Name = "txt_srv4";
            this.txt_srv4.Size = new System.Drawing.Size(187, 375);
            this.txt_srv4.TabIndex = 10;
            // 
            // lb_srv5
            // 
            this.lb_srv5.AutoSize = true;
            this.lb_srv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv5.Location = new System.Drawing.Point(797, 233);
            this.lb_srv5.Name = "lb_srv5";
            this.lb_srv5.Size = new System.Drawing.Size(39, 13);
            this.lb_srv5.TabIndex = 13;
            this.lb_srv5.Text = "SRV5";
            this.lb_srv5.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txt_srv5
            // 
            this.txt_srv5.Location = new System.Drawing.Point(722, 249);
            this.txt_srv5.Multiline = true;
            this.txt_srv5.Name = "txt_srv5";
            this.txt_srv5.Size = new System.Drawing.Size(187, 375);
            this.txt_srv5.TabIndex = 12;
            // 
            // lb_srv6
            // 
            this.lb_srv6.AutoSize = true;
            this.lb_srv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv6.Location = new System.Drawing.Point(1031, 233);
            this.lb_srv6.Name = "lb_srv6";
            this.lb_srv6.Size = new System.Drawing.Size(39, 13);
            this.lb_srv6.TabIndex = 15;
            this.lb_srv6.Text = "SRV6";
            // 
            // txt_srv6
            // 
            this.txt_srv6.Location = new System.Drawing.Point(953, 249);
            this.txt_srv6.Multiline = true;
            this.txt_srv6.Name = "txt_srv6";
            this.txt_srv6.Size = new System.Drawing.Size(187, 375);
            this.txt_srv6.TabIndex = 14;
            // 
            // btm_refrescar
            // 
            this.btm_refrescar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btm_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_refrescar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btm_refrescar.Location = new System.Drawing.Point(26, 149);
            this.btm_refrescar.Name = "btm_refrescar";
            this.btm_refrescar.Size = new System.Drawing.Size(126, 38);
            this.btm_refrescar.TabIndex = 16;
            this.btm_refrescar.Text = "Refrescar";
            this.btm_refrescar.UseVisualStyleBackColor = false;
            this.btm_refrescar.Click += new System.EventHandler(this.Btm_refrescar_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_1);
            this.tab.Controls.Add(this.tab_2);
            this.tab.Location = new System.Drawing.Point(2, 2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1225, 656);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 17;
            // 
            // tab_1
            // 
            this.tab_1.BackColor = System.Drawing.SystemColors.Menu;
            this.tab_1.Controls.Add(this.lb_srv6);
            this.tab_1.Controls.Add(this.btm_refrescar);
            this.tab_1.Controls.Add(this.txt_srv6);
            this.tab_1.Controls.Add(this.txt_srv2);
            this.tab_1.Controls.Add(this.lb_srv5);
            this.tab_1.Controls.Add(this.ch_autorefresco);
            this.tab_1.Controls.Add(this.txt_srv5);
            this.tab_1.Controls.Add(this.txt_srv3);
            this.tab_1.Controls.Add(this.lb_srv4);
            this.tab_1.Controls.Add(this.lb_srv3);
            this.tab_1.Controls.Add(this.txt_srv4);
            this.tab_1.Controls.Add(this.lb_srv2);
            this.tab_1.Controls.Add(this.LB_cuentaatras);
            this.tab_1.Controls.Add(this.lb_segundos);
            this.tab_1.Controls.Add(this.num_Segundos);
            this.tab_1.Location = new System.Drawing.Point(4, 22);
            this.tab_1.Name = "tab_1";
            this.tab_1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_1.Size = new System.Drawing.Size(1217, 630);
            this.tab_1.TabIndex = 0;
            this.tab_1.Text = "Canales";
            // 
            // tab_2
            // 
            this.tab_2.BackColor = System.Drawing.SystemColors.Menu;
            this.tab_2.Controls.Add(this.lb_srv6_2);
            this.tab_2.Controls.Add(this.btm_refrescar_2);
            this.tab_2.Controls.Add(this.txt_srv6_2);
            this.tab_2.Controls.Add(this.txt_srv2_2);
            this.tab_2.Controls.Add(this.lb_srv5_2);
            this.tab_2.Controls.Add(this.ch_autorefresco_2);
            this.tab_2.Controls.Add(this.txt_srv5_2);
            this.tab_2.Controls.Add(this.txt_srv3_2);
            this.tab_2.Controls.Add(this.lb_srv4_2);
            this.tab_2.Controls.Add(this.lb_srv3_2);
            this.tab_2.Controls.Add(this.txt_srv4_2);
            this.tab_2.Controls.Add(this.lb_srv2_2);
            this.tab_2.Controls.Add(this.LB_cuentaatras_2);
            this.tab_2.Controls.Add(this.lb_segundos_2);
            this.tab_2.Controls.Add(this.num_segundos_2);
            this.tab_2.Location = new System.Drawing.Point(4, 22);
            this.tab_2.Name = "tab_2";
            this.tab_2.Padding = new System.Windows.Forms.Padding(3);
            this.tab_2.Size = new System.Drawing.Size(1217, 531);
            this.tab_2.TabIndex = 1;
            this.tab_2.Text = "Estadistica";
            // 
            // lb_srv6_2
            // 
            this.lb_srv6_2.AutoSize = true;
            this.lb_srv6_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv6_2.Location = new System.Drawing.Point(1064, 237);
            this.lb_srv6_2.Name = "lb_srv6_2";
            this.lb_srv6_2.Size = new System.Drawing.Size(39, 13);
            this.lb_srv6_2.TabIndex = 30;
            this.lb_srv6_2.Text = "SRV6";
            // 
            // btm_refrescar_2
            // 
            this.btm_refrescar_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btm_refrescar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_refrescar_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btm_refrescar_2.Location = new System.Drawing.Point(31, 153);
            this.btm_refrescar_2.Name = "btm_refrescar_2";
            this.btm_refrescar_2.Size = new System.Drawing.Size(126, 38);
            this.btm_refrescar_2.TabIndex = 31;
            this.btm_refrescar_2.Text = "Refrescar";
            this.btm_refrescar_2.UseVisualStyleBackColor = false;
            // 
            // txt_srv6_2
            // 
            this.txt_srv6_2.Location = new System.Drawing.Point(1007, 253);
            this.txt_srv6_2.Multiline = true;
            this.txt_srv6_2.Name = "txt_srv6_2";
            this.txt_srv6_2.Size = new System.Drawing.Size(154, 179);
            this.txt_srv6_2.TabIndex = 29;
            // 
            // txt_srv2_2
            // 
            this.txt_srv2_2.Location = new System.Drawing.Point(31, 253);
            this.txt_srv2_2.Multiline = true;
            this.txt_srv2_2.Name = "txt_srv2_2";
            this.txt_srv2_2.Size = new System.Drawing.Size(154, 179);
            this.txt_srv2_2.TabIndex = 21;
            this.txt_srv2_2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lb_srv5_2
            // 
            this.lb_srv5_2.AutoSize = true;
            this.lb_srv5_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv5_2.Location = new System.Drawing.Point(830, 237);
            this.lb_srv5_2.Name = "lb_srv5_2";
            this.lb_srv5_2.Size = new System.Drawing.Size(39, 13);
            this.lb_srv5_2.TabIndex = 28;
            this.lb_srv5_2.Text = "SRV5";
            // 
            // ch_autorefresco_2
            // 
            this.ch_autorefresco_2.AutoSize = true;
            this.ch_autorefresco_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_autorefresco_2.Location = new System.Drawing.Point(31, 29);
            this.ch_autorefresco_2.Name = "ch_autorefresco_2";
            this.ch_autorefresco_2.Size = new System.Drawing.Size(154, 28);
            this.ch_autorefresco_2.TabIndex = 18;
            this.ch_autorefresco_2.Text = "Autorefrescar";
            this.ch_autorefresco_2.UseVisualStyleBackColor = true;
            this.ch_autorefresco_2.CheckedChanged += new System.EventHandler(this.Ch_autorefresco_2_CheckedChanged);
            // 
            // txt_srv5_2
            // 
            this.txt_srv5_2.Location = new System.Drawing.Point(775, 253);
            this.txt_srv5_2.Multiline = true;
            this.txt_srv5_2.Name = "txt_srv5_2";
            this.txt_srv5_2.Size = new System.Drawing.Size(154, 179);
            this.txt_srv5_2.TabIndex = 27;
            // 
            // txt_srv3_2
            // 
            this.txt_srv3_2.Location = new System.Drawing.Point(267, 253);
            this.txt_srv3_2.Multiline = true;
            this.txt_srv3_2.Name = "txt_srv3_2";
            this.txt_srv3_2.Size = new System.Drawing.Size(154, 179);
            this.txt_srv3_2.TabIndex = 23;
            // 
            // lb_srv4_2
            // 
            this.lb_srv4_2.AutoSize = true;
            this.lb_srv4_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv4_2.Location = new System.Drawing.Point(583, 237);
            this.lb_srv4_2.Name = "lb_srv4_2";
            this.lb_srv4_2.Size = new System.Drawing.Size(39, 13);
            this.lb_srv4_2.TabIndex = 26;
            this.lb_srv4_2.Text = "SRV4";
            // 
            // lb_srv3_2
            // 
            this.lb_srv3_2.AutoSize = true;
            this.lb_srv3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv3_2.Location = new System.Drawing.Point(322, 237);
            this.lb_srv3_2.Name = "lb_srv3_2";
            this.lb_srv3_2.Size = new System.Drawing.Size(39, 13);
            this.lb_srv3_2.TabIndex = 24;
            this.lb_srv3_2.Text = "SRV3";
            this.lb_srv3_2.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // txt_srv4_2
            // 
            this.txt_srv4_2.Location = new System.Drawing.Point(526, 253);
            this.txt_srv4_2.Multiline = true;
            this.txt_srv4_2.Name = "txt_srv4_2";
            this.txt_srv4_2.Size = new System.Drawing.Size(154, 179);
            this.txt_srv4_2.TabIndex = 25;
            // 
            // lb_srv2_2
            // 
            this.lb_srv2_2.AutoSize = true;
            this.lb_srv2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_srv2_2.Location = new System.Drawing.Point(83, 237);
            this.lb_srv2_2.Name = "lb_srv2_2";
            this.lb_srv2_2.Size = new System.Drawing.Size(39, 13);
            this.lb_srv2_2.TabIndex = 22;
            this.lb_srv2_2.Text = "SRV2";
            // 
            // LB_cuentaatras_2
            // 
            this.LB_cuentaatras_2.AutoSize = true;
            this.LB_cuentaatras_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_cuentaatras_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_cuentaatras_2.Location = new System.Drawing.Point(321, 31);
            this.LB_cuentaatras_2.Name = "LB_cuentaatras_2";
            this.LB_cuentaatras_2.Size = new System.Drawing.Size(123, 24);
            this.LB_cuentaatras_2.TabIndex = 17;
            this.LB_cuentaatras_2.Text = "CuentaAtras";
            // 
            // lb_segundos_2
            // 
            this.lb_segundos_2.AutoSize = true;
            this.lb_segundos_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_segundos_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_segundos_2.Location = new System.Drawing.Point(207, 91);
            this.lb_segundos_2.Name = "lb_segundos_2";
            this.lb_segundos_2.Size = new System.Drawing.Size(105, 24);
            this.lb_segundos_2.TabIndex = 20;
            this.lb_segundos_2.Text = "Segundos";
            // 
            // num_segundos_2
            // 
            this.num_segundos_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_segundos_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_segundos_2.Location = new System.Drawing.Point(31, 89);
            this.num_segundos_2.Name = "num_segundos_2";
            this.num_segundos_2.Size = new System.Drawing.Size(154, 29);
            this.num_segundos_2.TabIndex = 19;
            this.num_segundos_2.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1259, 808);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Analisis Sipwise";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Segundos)).EndInit();
            this.tab.ResumeLayout(false);
            this.tab_1.ResumeLayout(false);
            this.tab_1.PerformLayout();
            this.tab_2.ResumeLayout(false);
            this.tab_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_segundos_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Refresco;
        private System.Windows.Forms.Label LB_cuentaatras;
        private System.Windows.Forms.CheckBox ch_autorefresco;
        private System.Windows.Forms.NumericUpDown num_Segundos;
        private System.Windows.Forms.Label lb_segundos;
        private System.Windows.Forms.TextBox txt_srv2;
        private System.Windows.Forms.Label lb_srv2;
        private System.Windows.Forms.Label lb_srv3;
        private System.Windows.Forms.TextBox txt_srv3;
        private System.Windows.Forms.Label lb_srv4;
        private System.Windows.Forms.TextBox txt_srv4;
        private System.Windows.Forms.Label lb_srv5;
        private System.Windows.Forms.TextBox txt_srv5;
        private System.Windows.Forms.Label lb_srv6;
        private System.Windows.Forms.TextBox txt_srv6;
        private System.Windows.Forms.Button btm_refrescar;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_1;
        private System.Windows.Forms.TabPage tab_2;
        private System.Windows.Forms.Label lb_srv6_2;
        private System.Windows.Forms.Button btm_refrescar_2;
        private System.Windows.Forms.TextBox txt_srv6_2;
        private System.Windows.Forms.TextBox txt_srv2_2;
        private System.Windows.Forms.Label lb_srv5_2;
        private System.Windows.Forms.CheckBox ch_autorefresco_2;
        private System.Windows.Forms.TextBox txt_srv5_2;
        private System.Windows.Forms.TextBox txt_srv3_2;
        private System.Windows.Forms.Label lb_srv4_2;
        private System.Windows.Forms.Label lb_srv3_2;
        private System.Windows.Forms.TextBox txt_srv4_2;
        private System.Windows.Forms.Label lb_srv2_2;
        private System.Windows.Forms.Label LB_cuentaatras_2;
        private System.Windows.Forms.Label lb_segundos_2;
        private System.Windows.Forms.NumericUpDown num_segundos_2;
    }
}

