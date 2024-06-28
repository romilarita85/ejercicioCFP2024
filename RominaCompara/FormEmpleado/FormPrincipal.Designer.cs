namespace FormEmpleado
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
            dgv_listaDeEmpleados = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaDeEmpleados
            // 
            dgv_listaDeEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaDeEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaDeEmpleados.Location = new Point(57, 48);
            dgv_listaDeEmpleados.Name = "dgv_listaDeEmpleados";
            dgv_listaDeEmpleados.Size = new Size(677, 306);
            dgv_listaDeEmpleados.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(343, 381);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(115, 43);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_listaDeEmpleados);
            Name = "FormPrincipal";
            Text = "Lista de empleados";
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaDeEmpleados;
        private Button btn_agregar;
    }
}
