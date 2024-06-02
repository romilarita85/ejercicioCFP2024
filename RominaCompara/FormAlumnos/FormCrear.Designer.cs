namespace FormAlumnos
{
    partial class FormCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrear));
            lbl_legajo = new Label();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            txt_legajo = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            btn_aceptar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.BackColor = Color.Transparent;
            lbl_legajo.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_legajo.Location = new Point(44, 49);
            lbl_legajo.Margin = new Padding(4, 0, 4, 0);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(68, 18);
            lbl_legajo.TabIndex = 0;
            lbl_legajo.Text = "Legajo n°";
            lbl_legajo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.BackColor = Color.Transparent;
            lbl_nombre.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_nombre.Location = new Point(44, 90);
            lbl_nombre.Margin = new Padding(4, 0, 4, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(56, 18);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.BackColor = Color.Transparent;
            lbl_apellido.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbl_apellido.Location = new Point(41, 128);
            lbl_apellido.Margin = new Padding(4, 0, 4, 0);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(58, 18);
            lbl_apellido.TabIndex = 2;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_legajo
            // 
            txt_legajo.BackColor = Color.FloralWhite;
            txt_legajo.Location = new Point(121, 46);
            txt_legajo.Margin = new Padding(4, 3, 4, 3);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(163, 23);
            txt_legajo.TabIndex = 3;
            // 
            // txt_nombre
            // 
            txt_nombre.BackColor = Color.FloralWhite;
            txt_nombre.Location = new Point(121, 87);
            txt_nombre.Margin = new Padding(4, 3, 4, 3);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(163, 23);
            txt_nombre.TabIndex = 4;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FloralWhite;
            txt_apellido.Location = new Point(121, 125);
            txt_apellido.Margin = new Padding(4, 3, 4, 3);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(163, 23);
            txt_apellido.TabIndex = 5;
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = SystemColors.ActiveCaption;
            btn_aceptar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_aceptar.Location = new Point(44, 192);
            btn_aceptar.Margin = new Padding(4, 3, 4, 3);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(85, 38);
            btn_aceptar.TabIndex = 6;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.WindowText;
            btn_cancelar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = SystemColors.ControlLightLight;
            btn_cancelar.Location = new Point(199, 192);
            btn_cancelar.Margin = new Padding(4, 3, 4, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(85, 38);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(326, 261);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(txt_legajo);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_legajo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCrear";
            Text = "Alta alumnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_legajo;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private TextBox txt_legajo;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Button btn_aceptar;
        private Button btn_cancelar;
    }
}