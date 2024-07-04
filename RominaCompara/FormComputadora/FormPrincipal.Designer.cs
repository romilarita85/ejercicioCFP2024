namespace FormComputadora
{
    partial class FormPrincipal
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
            dgb_listaDeComputadoras = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgb_listaDeComputadoras).BeginInit();
            SuspendLayout();
            // 
            // dgb_listaDeComputadoras
            // 
            dgb_listaDeComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_listaDeComputadoras.Location = new Point(78, 41);
            dgb_listaDeComputadoras.Name = "dgb_listaDeComputadoras";
            dgb_listaDeComputadoras.Size = new Size(649, 312);
            dgb_listaDeComputadoras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(301, 380);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(205, 43);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgb_listaDeComputadoras);
            Name = "FormPrincipal";
            Text = "Lista de computadoras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgb_listaDeComputadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgb_listaDeComputadoras;
        private Button btn_agregar;
    }
}