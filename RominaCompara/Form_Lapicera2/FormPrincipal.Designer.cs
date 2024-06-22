namespace Form_Lapicera2
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
            dgv_listaLapiceras = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listaLapiceras).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaLapiceras
            // 
            dgv_listaLapiceras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaLapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaLapiceras.Location = new Point(60, 50);
            dgv_listaLapiceras.Name = "dgv_listaLapiceras";
            dgv_listaLapiceras.Size = new Size(617, 297);
            dgv_listaLapiceras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ActiveCaption;
            btn_agregar.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(305, 377);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(160, 41);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(739, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_listaLapiceras);
            Name = "FormPrincipal";
            Text = "Lista de lapiceras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaLapiceras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaLapiceras;
        private Button btn_agregar;
    }
}
