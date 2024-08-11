namespace Form_Computadora
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
            dgv_listaComputadoras = new DataGridView();
            btn_agregar = new Button();
            btn_modificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listaComputadoras).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaComputadoras
            // 
            dgv_listaComputadoras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaComputadoras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaComputadoras.Location = new Point(33, 46);
            dgv_listaComputadoras.Name = "dgv_listaComputadoras";
            dgv_listaComputadoras.Size = new Size(727, 321);
            dgv_listaComputadoras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(210, 417);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(119, 47);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(433, 417);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(119, 47);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_listaComputadoras);
            Name = "FormPrincipal";
            Text = "Computadoras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaComputadoras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaComputadoras;
        private Button btn_agregar;
        private Button btn_modificar;
    }
}