namespace FormAlumnos
{
    partial class ForEstadoAcademico
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
            lst_estadoAcademico.Location = new Point(95, 54);
            lst_estadoAcademico.Name = "lst_estadoAcademico";
            lst_estadoAcademico.Size = new Size(334, 409);
            lst_estadoAcademico.TabIndex = 0;
            // 
            // ForEstadoAcademico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(527, 499);
            Controls.Add(lst_estadoAcademico);
            Name = "ForEstadoAcademico";
            Text = "Estado academico";
            Load += ForEstadoAcademico_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_estadoAcademico;
    }
}