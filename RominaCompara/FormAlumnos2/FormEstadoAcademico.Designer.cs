namespace FormAlumnos2
{
    partial class FormEstadoAcademico
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
            lst_estadoAcademico = new ListBox();
            SuspendLayout();
            // 
            // lst_estadoAcademico
            // 
            lst_estadoAcademico.FormattingEnabled = true;
            lst_estadoAcademico.ItemHeight = 15;
            lst_estadoAcademico.Location = new Point(100, 47);
            lst_estadoAcademico.Name = "lst_estadoAcademico";
            lst_estadoAcademico.Size = new Size(354, 364);
            lst_estadoAcademico.TabIndex = 0;

            // 
            // FormEstadoAcademico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            Controls.Add(lst_estadoAcademico);
            Name = "FormEstadoAcademico";
            Text = "Estado Academico";
            Load += FormEstadoAcademico_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_estadoAcademico;
    }
}