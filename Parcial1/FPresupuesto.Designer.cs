namespace Parcial1
{
    partial class FPresupuesto
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
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 16;
            this.lbResultados.Location = new System.Drawing.Point(8, 21);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(486, 308);
            this.lbResultados.TabIndex = 0;
            // 
            // FPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 350);
            this.Controls.Add(this.lbResultados);
            this.Name = "FPresupuesto";
            this.Text = "FPresupuesto";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbResultados;
    }
}