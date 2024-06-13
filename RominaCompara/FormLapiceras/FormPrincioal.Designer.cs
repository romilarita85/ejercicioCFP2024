namespace FormLapiceras
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
 

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_listadoLapiceras = new DataGridView();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_listadoLapiceras).BeginInit();

            // 
            // dgv_listadoLapiceras
            // 
            dgv_listadoLapiceras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_listadoLapiceras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listadoLapiceras.Location = new Point(41, 38);
            dgv_listadoLapiceras.Name = "dgv_listadoLapiceras";
            dgv_listadoLapiceras.Size = new Size(708, 326);
            dgv_listadoLapiceras.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.LemonChiffon;
            btn_agregar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(350, 388);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(145, 39);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
 

        }

        #endregion

        private DataGridView dgv_listadoLapiceras;
        private Button btn_agregar;
    }
}
