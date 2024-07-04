namespace FormComputadora
{
    partial class FormAltaComputadora
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
            gpb_harware = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            lbl_procesador = new Label();
            num_disco = new NumericUpDown();
            num_memoriaRam = new NumericUpDown();
            cmb_procesadores = new ComboBox();
            gpb_sitemasOperativos = new GroupBox();
            rdb_macOs = new RadioButton();
            rdb_linux = new RadioButton();
            rdb_windows = new RadioButton();
            gpb_programas = new GroupBox();
            chk_avast = new CheckBox();
            chK_dropbox = new CheckBox();
            chk_winrar = new CheckBox();
            chk_adobeReader = new CheckBox();
            chk_office = new CheckBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            gpb_harware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_disco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_memoriaRam).BeginInit();
            gpb_sitemasOperativos.SuspendLayout();
            gpb_programas.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_harware
            // 
            gpb_harware.Controls.Add(label3);
            gpb_harware.Controls.Add(label2);
            gpb_harware.Controls.Add(lbl_procesador);
            gpb_harware.Controls.Add(num_disco);
            gpb_harware.Controls.Add(num_memoriaRam);
            gpb_harware.Controls.Add(cmb_procesadores);
            gpb_harware.Location = new Point(39, 35);
            gpb_harware.Name = "gpb_harware";
            gpb_harware.Size = new Size(382, 321);
            gpb_harware.TabIndex = 0;
            gpb_harware.TabStop = false;
            gpb_harware.Text = "Hardware";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 171);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Disco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 122);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Memoria Ram";
            // 
            // lbl_procesador
            // 
            lbl_procesador.AutoSize = true;
            lbl_procesador.Location = new Point(40, 76);
            lbl_procesador.Name = "lbl_procesador";
            lbl_procesador.Size = new Size(66, 15);
            lbl_procesador.TabIndex = 3;
            lbl_procesador.Text = "Procesador";
            // 
            // num_disco
            // 
            num_disco.Location = new Point(173, 163);
            num_disco.Name = "num_disco";
            num_disco.Size = new Size(162, 23);
            num_disco.TabIndex = 2;
            // 
            // num_memoriaRam
            // 
            num_memoriaRam.Location = new Point(173, 114);
            num_memoriaRam.Name = "num_memoriaRam";
            num_memoriaRam.Size = new Size(162, 23);
            num_memoriaRam.TabIndex = 1;
            // 
            // cmb_procesadores
            // 
            cmb_procesadores.FormattingEnabled = true;
            cmb_procesadores.Location = new Point(172, 68);
            cmb_procesadores.Name = "cmb_procesadores";
            cmb_procesadores.Size = new Size(163, 23);
            cmb_procesadores.TabIndex = 0;
            // 
            // gpb_sitemasOperativos
            // 
            gpb_sitemasOperativos.Controls.Add(rdb_macOs);
            gpb_sitemasOperativos.Controls.Add(rdb_linux);
            gpb_sitemasOperativos.Controls.Add(rdb_windows);
            gpb_sitemasOperativos.Location = new Point(463, 44);
            gpb_sitemasOperativos.Name = "gpb_sitemasOperativos";
            gpb_sitemasOperativos.Size = new Size(227, 118);
            gpb_sitemasOperativos.TabIndex = 0;
            gpb_sitemasOperativos.TabStop = false;
            gpb_sitemasOperativos.Text = "Sistema Operativo";
            // 
            // rdb_macOs
            // 
            rdb_macOs.AutoSize = true;
            rdb_macOs.Location = new Point(35, 82);
            rdb_macOs.Name = "rdb_macOs";
            rdb_macOs.Size = new Size(62, 19);
            rdb_macOs.TabIndex = 2;
            rdb_macOs.TabStop = true;
            rdb_macOs.Text = "MacOs";
            rdb_macOs.UseVisualStyleBackColor = true;
            // 
            // rdb_linux
            // 
            rdb_linux.AutoSize = true;
            rdb_linux.Location = new Point(35, 57);
            rdb_linux.Name = "rdb_linux";
            rdb_linux.Size = new Size(54, 19);
            rdb_linux.TabIndex = 1;
            rdb_linux.TabStop = true;
            rdb_linux.Text = "Linux";
            rdb_linux.UseVisualStyleBackColor = true;
            // 
            // rdb_windows
            // 
            rdb_windows.AutoSize = true;
            rdb_windows.Location = new Point(35, 32);
            rdb_windows.Name = "rdb_windows";
            rdb_windows.Size = new Size(74, 19);
            rdb_windows.TabIndex = 0;
            rdb_windows.TabStop = true;
            rdb_windows.Text = "Windows";
            rdb_windows.UseVisualStyleBackColor = true;
            // 
            // gpb_programas
            // 
            gpb_programas.Controls.Add(chk_avast);
            gpb_programas.Controls.Add(chK_dropbox);
            gpb_programas.Controls.Add(chk_winrar);
            gpb_programas.Controls.Add(chk_adobeReader);
            gpb_programas.Controls.Add(chk_office);
            gpb_programas.Location = new Point(463, 183);
            gpb_programas.Name = "gpb_programas";
            gpb_programas.Size = new Size(227, 173);
            gpb_programas.TabIndex = 0;
            gpb_programas.TabStop = false;
            gpb_programas.Text = "Programas";
            // 
            // chk_avast
            // 
            chk_avast.AutoSize = true;
            chk_avast.Location = new Point(35, 132);
            chk_avast.Name = "chk_avast";
            chk_avast.Size = new Size(55, 19);
            chk_avast.TabIndex = 4;
            chk_avast.Text = "Avast";
            chk_avast.UseVisualStyleBackColor = true;
            // 
            // chK_dropbox
            // 
            chK_dropbox.AutoSize = true;
            chK_dropbox.Location = new Point(35, 107);
            chK_dropbox.Name = "chK_dropbox";
            chK_dropbox.Size = new Size(72, 19);
            chK_dropbox.TabIndex = 3;
            chK_dropbox.Text = "Dropbox";
            chK_dropbox.UseVisualStyleBackColor = true;
            // 
            // chk_winrar
            // 
            chk_winrar.AutoSize = true;
            chk_winrar.Location = new Point(35, 82);
            chk_winrar.Name = "chk_winrar";
            chk_winrar.Size = new Size(61, 19);
            chk_winrar.TabIndex = 2;
            chk_winrar.Text = "Winrar";
            chk_winrar.UseVisualStyleBackColor = true;
            // 
            // chk_adobeReader
            // 
            chk_adobeReader.AutoSize = true;
            chk_adobeReader.Location = new Point(35, 57);
            chk_adobeReader.Name = "chk_adobeReader";
            chk_adobeReader.Size = new Size(100, 19);
            chk_adobeReader.TabIndex = 1;
            chk_adobeReader.Text = "Adobe Reader";
            chk_adobeReader.UseVisualStyleBackColor = true;
            // 
            // chk_office
            // 
            chk_office.AutoSize = true;
            chk_office.Location = new Point(35, 32);
            chk_office.Name = "chk_office";
            chk_office.Size = new Size(58, 19);
            chk_office.TabIndex = 0;
            chk_office.Text = "Office";
            chk_office.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(463, 383);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(84, 41);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(602, 383);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(88, 41);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAltaComputadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 450);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_programas);
            Controls.Add(gpb_sitemasOperativos);
            Controls.Add(gpb_harware);
            Name = "FormAltaComputadora";
            Text = "FormAltaComputadora";
            Load += FormAltaComputadora_Load;
            gpb_harware.ResumeLayout(false);
            gpb_harware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_disco).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_memoriaRam).EndInit();
            gpb_sitemasOperativos.ResumeLayout(false);
            gpb_sitemasOperativos.PerformLayout();
            gpb_programas.ResumeLayout(false);
            gpb_programas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_harware;
        private Label label3;
        private Label label2;
        private Label lbl_procesador;
        private NumericUpDown num_disco;
        private NumericUpDown num_memoriaRam;
        private ComboBox cmb_procesadores;
        private GroupBox gpb_sitemasOperativos;
        private RadioButton rdb_macOs;
        private RadioButton rdb_linux;
        private RadioButton rdb_windows;
        private GroupBox gpb_programas;
        private Button btn_cancelar;
        private Button btn_agregar;
        private CheckBox chk_avast;
        private CheckBox chK_dropbox;
        private CheckBox chk_winrar;
        private CheckBox chk_adobeReader;
        private CheckBox chk_office;
    }
}