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
            dgv_listaDeComputadoras = new DataGridView();
            btn_agregar = new Button();
            btn_modificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeComputadoras).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaDeComputadoras
            // 
            dgv_listaDeComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaDeComputadoras.Location = new Point(78, 41);
            dgv_listaDeComputadoras.Name = "dgv_listaDeComputadoras";
            dgv_listaDeComputadoras.Size = new Size(649, 312);
            dgv_listaDeComputadoras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(168, 378);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(173, 43);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(472, 378);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(173, 43);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_listaDeComputadoras);
            Name = "FormPrincipal";
            Text = "Lista de computadoras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeComputadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaDeComputadoras;
        private Button btn_agregar;
        private Button btn_modificar;
    }
}