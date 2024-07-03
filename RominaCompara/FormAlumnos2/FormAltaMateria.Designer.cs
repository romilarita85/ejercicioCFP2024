namespace FormAlumnos2
{
    partial class FormAltaMateria
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
            btn_aceptar = new Button();
            txt_nombre = new TextBox();
            lbl_nombre = new Label();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(219, 159);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(110, 26);
            btn_aceptar.TabIndex = 0;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(194, 67);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(135, 23);
            txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(86, 75);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(86, 159);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(103, 26);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 234);
            Controls.Add(btn_cancelar);
            Controls.Add(lbl_nombre);
            Controls.Add(txt_nombre);
            Controls.Add(btn_aceptar);
            Name = "FormAltaMateria";
            Text = "Alta materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_aceptar;
        private TextBox txt_nombre;
        private Label lbl_nombre;
        private Button btn_cancelar;
    }
}