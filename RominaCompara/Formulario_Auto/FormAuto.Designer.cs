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
            SuspendLayout();
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(66, 65);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(180, 23);
            txt_marca.TabIndex = 0;
            // 
            // txt_combustible
            // 
            txt_combustible.Location = new Point(66, 118);
            txt_combustible.Name = "txt_combustible";
            txt_combustible.Size = new Size(180, 23);
            txt_combustible.TabIndex = 1;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(66, 47);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 3;
            lbl_marca.Text = "Marca";
            // 
            // lbl_combustible
            // 
            lbl_combustible.AutoSize = true;
            lbl_combustible.Location = new Point(66, 100);
            lbl_combustible.Name = "lbl_combustible";
            lbl_combustible.Size = new Size(120, 15);
            lbl_combustible.TabIndex = 4;
            lbl_combustible.Text = "Cant. de combustible";
            lbl_combustible.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(66, 150);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(36, 15);
            lbl_color.TabIndex = 5;
            lbl_color.Text = "Color";
            // 
            // btn_crear
            // 
            btn_crear.Location = new Point(66, 232);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(96, 23);
            btn_crear.TabIndex = 6;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(66, 168);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(180, 23);
            cmb_colores.TabIndex = 7;
            // 
            // FormAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 439);
            Controls.Add(cmb_colores);
            Controls.Add(btn_crear);
            Controls.Add(lbl_color);
            Controls.Add(lbl_combustible);
            Controls.Add(lbl_marca);
            Controls.Add(txt_combustible);
            Controls.Add(txt_marca);
            Name = "FormAuto";
            Text = "Form1";
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
    }
}
