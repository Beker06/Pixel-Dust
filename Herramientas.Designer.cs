
namespace PixelDust
{
    partial class Herramientas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnRectangulo);
            this.panel1.Controls.Add(this.btnCirculo);
            this.panel1.Controls.Add(this.btnLlenar);
            this.panel1.Controls.Add(this.btnLapiz);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.Image = global::PixelDust.Properties.Resources.Line;
            this.btnLine.Location = new System.Drawing.Point(403, 7);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(60, 60);
            this.btnLine.TabIndex = 6;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRectangulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRectangulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRectangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangulo.ForeColor = System.Drawing.Color.White;
            this.btnRectangulo.Image = global::PixelDust.Properties.Resources.rectangle;
            this.btnRectangulo.Location = new System.Drawing.Point(337, 7);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(60, 60);
            this.btnRectangulo.TabIndex = 5;
            this.btnRectangulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCirculo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCirculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCirculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.ForeColor = System.Drawing.Color.White;
            this.btnCirculo.Image = global::PixelDust.Properties.Resources.Circle;
            this.btnCirculo.Location = new System.Drawing.Point(271, 7);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(60, 60);
            this.btnCirculo.TabIndex = 4;
            this.btnCirculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnLlenar
            // 
            this.btnLlenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLlenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlenar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLlenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLlenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLlenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlenar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenar.ForeColor = System.Drawing.Color.White;
            this.btnLlenar.Image = global::PixelDust.Properties.Resources.Fill1;
            this.btnLlenar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLlenar.Location = new System.Drawing.Point(73, 7);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(60, 60);
            this.btnLlenar.TabIndex = 3;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLlenar.UseVisualStyleBackColor = false;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLapiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapiz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLapiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLapiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLapiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapiz.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapiz.ForeColor = System.Drawing.Color.White;
            this.btnLapiz.Image = global::PixelDust.Properties.Resources.Pencil1;
            this.btnLapiz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLapiz.Location = new System.Drawing.Point(139, 7);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(60, 60);
            this.btnLapiz.TabIndex = 2;
            this.btnLapiz.Text = "Lapiz";
            this.btnLapiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::PixelDust.Properties.Resources.eraser;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(205, 7);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(60, 60);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = global::PixelDust.Properties.Resources.ColorPaletteGrande;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColor.Location = new System.Drawing.Point(7, 7);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(60, 60);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Herramientas";
            this.Size = new System.Drawing.Size(475, 78);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.Button btnBorrar;
    }
}
