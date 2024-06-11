namespace FormRegistrate
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
            dgb_ingresante = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgb_ingresante).BeginInit();
            SuspendLayout();
            // 
            // dgb_ingresante
            // 
            dgb_ingresante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_ingresante.Location = new Point(54, 35);
            dgb_ingresante.Name = "dgb_ingresante";
            dgb_ingresante.Size = new Size(689, 288);
            dgb_ingresante.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(336, 342);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(128, 32);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(btn_agregar);
            Controls.Add(dgb_ingresante);
            Name = "FormAlta";
            Text = "Listado de ingresantes";
            ((System.ComponentModel.ISupportInitialize)dgb_ingresante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgb_ingresante;
        private Button btn_agregar;
    }
}