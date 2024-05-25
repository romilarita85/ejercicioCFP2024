namespace Formulario_Auto
{
    partial class FormAuto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_marca = new TextBox();
            txt_combustible = new TextBox();
            lbl_marca = new Label();
            lbl_combustible = new Label();
            lbl_color = new Label();
            btn_crear = new Button();
            cmb_colores = new ComboBox();
            lst_misAutos = new ListBox();
            btn_mostrar = new Button();
            btn_limpiar = new Button();
            SuspendLayout();
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(46, 69);
            txt_marca.Margin = new Padding(5, 3, 5, 3);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(233, 22);
            txt_marca.TabIndex = 0;
            // 
            // txt_combustible
            // 
            txt_combustible.Location = new Point(46, 126);
            txt_combustible.Margin = new Padding(5, 3, 5, 3);
            txt_combustible.Name = "txt_combustible";
            txt_combustible.Size = new Size(233, 22);
            txt_combustible.TabIndex = 1;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_marca.Location = new Point(53, 50);
            lbl_marca.Margin = new Padding(5, 0, 5, 0);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(43, 14);
            lbl_marca.TabIndex = 3;
            lbl_marca.Text = "Marca";
            // 
            // lbl_combustible
            // 
            lbl_combustible.AutoSize = true;
            lbl_combustible.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_combustible.Location = new Point(53, 107);
            lbl_combustible.Margin = new Padding(5, 0, 5, 0);
            lbl_combustible.Name = "lbl_combustible";
            lbl_combustible.Size = new Size(137, 14);
            lbl_combustible.TabIndex = 4;
            lbl_combustible.Text = "Cant. de combustible";
            lbl_combustible.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_color.Location = new Point(53, 160);
            lbl_color.Margin = new Padding(5, 0, 5, 0);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(39, 14);
            lbl_color.TabIndex = 5;
            lbl_color.Text = "Color";
            // 
            // btn_crear
            // 
            btn_crear.BackColor = Color.White;
            btn_crear.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_crear.Location = new Point(94, 239);
            btn_crear.Margin = new Padding(5, 3, 5, 3);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(138, 28);
            btn_crear.TabIndex = 6;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = false;
            btn_crear.Click += btn_crear_Click;
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(46, 179);
            cmb_colores.Margin = new Padding(5, 3, 5, 3);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(233, 24);
            cmb_colores.TabIndex = 7;
            // 
            // lst_misAutos
            // 
            lst_misAutos.FormattingEnabled = true;
            lst_misAutos.Location = new Point(346, 70);
            lst_misAutos.Margin = new Padding(5, 3, 5, 3);
            lst_misAutos.Name = "lst_misAutos";
            lst_misAutos.Size = new Size(706, 292);
            lst_misAutos.TabIndex = 8;
            // 
            // btn_mostrar
            // 
            btn_mostrar.BackColor = Color.FromArgb(255, 128, 128);
            btn_mostrar.BackgroundImageLayout = ImageLayout.None;
            btn_mostrar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mostrar.ForeColor = SystemColors.ActiveCaptionText;
            btn_mostrar.Location = new Point(522, 395);
            btn_mostrar.Margin = new Padding(5, 3, 5, 3);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(138, 28);
            btn_mostrar.TabIndex = 9;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = false;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Lime;
            btn_limpiar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(720, 395);
            btn_limpiar.Margin = new Padding(5, 3, 5, 3);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(138, 28);
            btn_limpiar.TabIndex = 10;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1094, 461);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_mostrar);
            Controls.Add(lst_misAutos);
            Controls.Add(cmb_colores);
            Controls.Add(btn_crear);
            Controls.Add(lbl_color);
            Controls.Add(lbl_combustible);
            Controls.Add(lbl_marca);
            Controls.Add(txt_combustible);
            Controls.Add(txt_marca);
            Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "FormAuto";
            Text = "Mis autos";
            Load += FormAuto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_marca;
        private TextBox txt_combustible;
        private Label lbl_marca;
        private Label lbl_combustible;
        private Label lbl_color;
        private Button btn_crear;
        private ComboBox cmb_colores;
        private ListBox lst_misAutos;
        private Button btn_mostrar;
        private Button btn_limpiar;
    }
}
