namespace FormLapicera
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
            dgv_listaDeLapiceras = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeLapiceras).BeginInit();
            SuspendLayout();
            // 
            // dgv_listaDeLapiceras
            // 
            dgv_listaDeLapiceras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listaDeLapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaDeLapiceras.Location = new Point(59, 48);
            dgv_listaDeLapiceras.Name = "dgv_listaDeLapiceras";
            dgv_listaDeLapiceras.Size = new Size(636, 298);
            dgv_listaDeLapiceras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(335, 369);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(85, 34);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_listaDeLapiceras);
            Name = "FormPrincipal";
            Text = "Lista de lapiceras";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaDeLapiceras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_listaDeLapiceras;
        private Button btn_agregar;
    }
}
