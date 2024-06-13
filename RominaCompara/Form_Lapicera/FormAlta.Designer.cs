﻿namespace Form_Lapicera
{
    partial class FormAlta
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
            gpv_datosLapicera = new GroupBox();
            num_nivelDeTinta = new NumericUpDown();
            txt_marca = new TextBox();
            num_precio = new NumericUpDown();
            cmb_color = new ComboBox();
            lbl_nivelDeTinta = new Label();
            lbl_marca = new Label();
            lbl_precio = new Label();
            lbl_color = new Label();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            gpv_datosLapicera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_nivelDeTinta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            SuspendLayout();
            // 
            // gpv_datosLapicera
            // 
            gpv_datosLapicera.Controls.Add(num_nivelDeTinta);
            gpv_datosLapicera.Controls.Add(txt_marca);
            gpv_datosLapicera.Controls.Add(num_precio);
            gpv_datosLapicera.Controls.Add(cmb_color);
            gpv_datosLapicera.Controls.Add(lbl_nivelDeTinta);
            gpv_datosLapicera.Controls.Add(lbl_marca);
            gpv_datosLapicera.Controls.Add(lbl_precio);
            gpv_datosLapicera.Controls.Add(lbl_color);
            gpv_datosLapicera.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpv_datosLapicera.Location = new Point(43, 34);
            gpv_datosLapicera.Name = "gpv_datosLapicera";
            gpv_datosLapicera.Size = new Size(405, 269);
            gpv_datosLapicera.TabIndex = 0;
            gpv_datosLapicera.TabStop = false;
            gpv_datosLapicera.Text = "Datos de lapicera";
            // 
            // num_nivelDeTinta
            // 
            num_nivelDeTinta.Location = new Point(183, 199);
            num_nivelDeTinta.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_nivelDeTinta.Name = "num_nivelDeTinta";
            num_nivelDeTinta.Size = new Size(154, 23);
            num_nivelDeTinta.TabIndex = 7;
            num_nivelDeTinta.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(183, 149);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(154, 23);
            txt_marca.TabIndex = 6;
            // 
            // num_precio
            // 
            num_precio.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Location = new Point(182, 101);
            num_precio.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            num_precio.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(155, 23);
            num_precio.TabIndex = 5;
            num_precio.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // cmb_color
            // 
            cmb_color.FormattingEnabled = true;
            cmb_color.Location = new Point(182, 53);
            cmb_color.Name = "cmb_color";
            cmb_color.Size = new Size(155, 24);
            cmb_color.TabIndex = 4;
            // 
            // lbl_nivelDeTinta
            // 
            lbl_nivelDeTinta.AutoSize = true;
            lbl_nivelDeTinta.Font = new Font("Verdana", 9.75F);
            lbl_nivelDeTinta.Location = new Point(73, 207);
            lbl_nivelDeTinta.Name = "lbl_nivelDeTinta";
            lbl_nivelDeTinta.Size = new Size(95, 16);
            lbl_nivelDeTinta.TabIndex = 3;
            lbl_nivelDeTinta.Text = "Nivel de tinta";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Verdana", 9.75F);
            lbl_marca.Location = new Point(73, 157);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(47, 16);
            lbl_marca.TabIndex = 2;
            lbl_marca.Text = "Marca";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Verdana", 9.75F);
            lbl_precio.Location = new Point(73, 109);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(47, 16);
            lbl_precio.TabIndex = 1;
            lbl_precio.Text = "Precio";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Font = new Font("Verdana", 9.75F);
            lbl_color.Location = new Point(73, 61);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(40, 16);
            lbl_color.TabIndex = 0;
            lbl_color.Text = "Color";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(85, 333);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(89, 32);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(311, 333);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(89, 32);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;

            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 396);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpv_datosLapicera);
            Name = "FormAlta";
            Text = "Alta lapicera";
            Load += FormAlta_Load;
            gpv_datosLapicera.ResumeLayout(false);
            gpv_datosLapicera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_nivelDeTinta).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_precio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpv_datosLapicera;
        private NumericUpDown num_nivelDeTinta;
        private TextBox txt_marca;
        private NumericUpDown num_precio;
        private ComboBox cmb_color;
        private Label lbl_nivelDeTinta;
        private Label lbl_marca;
        private Label lbl_precio;
        private Label lbl_color;
        private Button btn_cancelar;
        private Button btn_aceptar;
    }
}