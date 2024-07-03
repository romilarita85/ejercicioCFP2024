namespace FormRegistrate_2
{
    partial class FormPrincipal
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
            dgv_listaIngresantes = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listaIngresantes).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaIngresantes
            // 
            dgv_listaIngresantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaIngresantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaIngresantes.Location = new Point(68, 63);
            dgv_listaIngresantes.Name = "dgv_listaIngresantes";
            dgv_listaIngresantes.Size = new Size(636, 266);
            dgv_listaIngresantes.TabIndex = 1;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(329, 357);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(104, 38);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 430);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_listaIngresantes);
            Name = "FormPrincipal";
            Text = "Lista de ingresantes";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaIngresantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaIngresantes;
        private Button btn_agregar;
    }
}
