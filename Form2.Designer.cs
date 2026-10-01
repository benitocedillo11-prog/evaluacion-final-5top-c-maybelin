namespace evaluacion_final__5top_c_maybelin
{
    partial class Form2
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
            this.textvar1 = new System.Windows.Forms.TextBox();
            this.textVar2 = new System.Windows.Forms.TextBox();
            this.Btnproductos = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.Btnpotencia = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textvar1
            // 
            this.textvar1.Location = new System.Drawing.Point(367, 65);
            this.textvar1.Name = "textvar1";
            this.textvar1.Size = new System.Drawing.Size(100, 22);
            this.textvar1.TabIndex = 0;
            // 
            // textVar2
            // 
            this.textVar2.Location = new System.Drawing.Point(381, 127);
            this.textVar2.Name = "textVar2";
            this.textVar2.Size = new System.Drawing.Size(100, 22);
            this.textVar2.TabIndex = 1;
            // 
            // Btnproductos
            // 
            this.Btnproductos.Location = new System.Drawing.Point(381, 180);
            this.Btnproductos.Name = "Btnproductos";
            this.Btnproductos.Size = new System.Drawing.Size(75, 23);
            this.Btnproductos.TabIndex = 2;
            this.Btnproductos.Text = "produccion";
            this.Btnproductos.UseVisualStyleBackColor = true;
            this.Btnproductos.Click += new System.EventHandler(this.Btnproductos_Click);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(474, 218);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "suma";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // Btnpotencia
            // 
            this.Btnpotencia.Location = new System.Drawing.Point(560, 252);
            this.Btnpotencia.Name = "Btnpotencia";
            this.Btnpotencia.Size = new System.Drawing.Size(75, 23);
            this.Btnpotencia.TabIndex = 4;
            this.Btnpotencia.Text = "potencia";
            this.Btnpotencia.UseVisualStyleBackColor = true;
            this.Btnpotencia.Click += new System.EventHandler(this.Btnpotencia_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(646, 290);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 5;
            this.btnDivision.Text = "division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.Btnpotencia);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.Btnproductos);
            this.Controls.Add(this.textVar2);
            this.Controls.Add(this.textvar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textvar1;
        private System.Windows.Forms.TextBox textVar2;
        private System.Windows.Forms.Button Btnproductos;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button Btnpotencia;
        private System.Windows.Forms.Button btnDivision;
    }
}