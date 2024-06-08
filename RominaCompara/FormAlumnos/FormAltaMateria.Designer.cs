namespace FormAlumnos
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
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Firebrick;
            btn_cancelar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(64, 118);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(102, 38);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.PapayaWhip;
            btn_aceptar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_aceptar.Location = new Point(239, 118);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(102, 38);
            btn_aceptar.TabIndex = 1;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombre.Location = new Point(64, 57);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(70, 20);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(140, 58);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(201, 23);
            txt_nombre.TabIndex = 4;
            // 
            // FormAltaMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 213);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_nombre);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Name = "FormAltaMateria";
            Text = "Alta de materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancelar;
        private Button btn_aceptar;
        private Label lbl_nombre;
        private TextBox txt_nombre;
    }
}