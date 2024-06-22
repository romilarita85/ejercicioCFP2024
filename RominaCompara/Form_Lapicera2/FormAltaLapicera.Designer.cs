namespace Form_Lapicera2
{
    partial class FormAltaLapicera
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
            gpb_marcas = new GroupBox();
            rdb_rotring = new RadioButton();
            rdb_filgo = new RadioButton();
            rdb_parker = new RadioButton();
            rdb_faberCastell = new RadioButton();
            rdb_bic = new RadioButton();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            lbl_color = new Label();
            lbl_precio = new Label();
            num_precio = new NumericUpDown();
            cmb_colores = new ComboBox();
            gpb_marcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            SuspendLayout();
            // 
            // gpb_marcas
            // 
            gpb_marcas.CausesValidation = false;
            gpb_marcas.Controls.Add(rdb_rotring);
            gpb_marcas.Controls.Add(rdb_filgo);
            gpb_marcas.Controls.Add(rdb_parker);
            gpb_marcas.Controls.Add(rdb_faberCastell);
            gpb_marcas.Controls.Add(rdb_bic);
            gpb_marcas.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            gpb_marcas.Location = new Point(60, 174);
            gpb_marcas.Name = "gpb_marcas";
            gpb_marcas.Size = new Size(257, 183);
            gpb_marcas.TabIndex = 0;
            gpb_marcas.TabStop = false;
            gpb_marcas.Text = "Marca";
            // 
            // rdb_rotring
            // 
            rdb_rotring.AutoSize = true;
            rdb_rotring.Location = new Point(77, 135);
            rdb_rotring.Name = "rdb_rotring";
            rdb_rotring.Size = new Size(82, 22);
            rdb_rotring.TabIndex = 4;
            rdb_rotring.TabStop = true;
            rdb_rotring.Text = "Rotring";
            rdb_rotring.UseVisualStyleBackColor = true;
            // 
            // rdb_filgo
            // 
            rdb_filgo.AutoSize = true;
            rdb_filgo.Location = new Point(77, 110);
            rdb_filgo.Name = "rdb_filgo";
            rdb_filgo.Size = new Size(63, 22);
            rdb_filgo.TabIndex = 3;
            rdb_filgo.TabStop = true;
            rdb_filgo.Text = "Filgo";
            rdb_filgo.UseVisualStyleBackColor = true;
            // 
            // rdb_parker
            // 
            rdb_parker.AutoSize = true;
            rdb_parker.Location = new Point(77, 85);
            rdb_parker.Name = "rdb_parker";
            rdb_parker.Size = new Size(77, 22);
            rdb_parker.TabIndex = 2;
            rdb_parker.TabStop = true;
            rdb_parker.Text = "Parker";
            rdb_parker.UseVisualStyleBackColor = true;
            // 
            // rdb_faberCastell
            // 
            rdb_faberCastell.AutoSize = true;
            rdb_faberCastell.Location = new Point(77, 60);
            rdb_faberCastell.Name = "rdb_faberCastell";
            rdb_faberCastell.Size = new Size(125, 22);
            rdb_faberCastell.TabIndex = 1;
            rdb_faberCastell.TabStop = true;
            rdb_faberCastell.Text = "Faber Castell";
            rdb_faberCastell.UseVisualStyleBackColor = true;
            // 
            // rdb_bic
            // 
            rdb_bic.AutoSize = true;
            rdb_bic.Location = new Point(77, 35);
            rdb_bic.Name = "rdb_bic";
            rdb_bic.Size = new Size(49, 22);
            rdb_bic.TabIndex = 0;
            rdb_bic.TabStop = true;
            rdb_bic.Text = "Bic";
            rdb_bic.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.ButtonHighlight;
            btn_cancelar.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_cancelar.Location = new Point(37, 376);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(103, 38);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.Desktop;
            btn_agregar.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_agregar.ForeColor = SystemColors.ControlLightLight;
            btn_agregar.Location = new Point(236, 376);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(103, 38);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.CausesValidation = false;
            lbl_color.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            lbl_color.Location = new Point(63, 65);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(48, 18);
            lbl_color.TabIndex = 3;
            lbl_color.Text = "Color";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.CausesValidation = false;
            lbl_precio.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            lbl_precio.Location = new Point(63, 121);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(56, 18);
            lbl_precio.TabIndex = 4;
            lbl_precio.Text = "Precio";
            // 
            // num_precio
            // 
            num_precio.CausesValidation = false;
            num_precio.Font = new Font("Tahoma", 11.25F);
            num_precio.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Location = new Point(141, 116);
            num_precio.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            num_precio.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(177, 26);
            num_precio.TabIndex = 5;
            num_precio.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // cmb_colores
            // 
            cmb_colores.CausesValidation = false;
            cmb_colores.Font = new Font("Tahoma", 11.25F);
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(141, 57);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(177, 26);
            cmb_colores.TabIndex = 6;
            // 
            // FormAltaLapicera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(375, 456);
            Controls.Add(cmb_colores);
            Controls.Add(num_precio);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_color);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_marcas);
            Name = "FormAltaLapicera";
            Text = "Alta Lapicera";
            Load += FormAltaLapicera_Load;
            gpb_marcas.ResumeLayout(false);
            gpb_marcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_marcas;
        private Button btn_cancelar;
        private Button btn_agregar;
        private Label lbl_color;
        private Label lbl_precio;
        private NumericUpDown num_precio;
        private ComboBox cmb_colores;
        private RadioButton rdb_rotring;
        private RadioButton rdb_filgo;
        private RadioButton rdb_parker;
        private RadioButton rdb_faberCastell;
        private RadioButton rdb_bic;
    }
}