
namespace pixel_paint
{
    partial class Form1
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
            this.crearPixel = new System.Windows.Forms.Button();
            this.marco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.marco)).BeginInit();
            this.SuspendLayout();
            // 
            // crearPixel
            // 
            this.crearPixel.Location = new System.Drawing.Point(55, 129);
            this.crearPixel.Name = "crearPixel";
            this.crearPixel.Size = new System.Drawing.Size(146, 32);
            this.crearPixel.TabIndex = 0;
            this.crearPixel.Text = "Crear pixel random";
            this.crearPixel.UseVisualStyleBackColor = true;
            this.crearPixel.Click += new System.EventHandler(this.crearPixel_Click);
            // 
            // marco
            // 
            this.marco.Location = new System.Drawing.Point(243, 46);
            this.marco.Name = "marco";
            this.marco.Size = new System.Drawing.Size(400, 300);
            this.marco.TabIndex = 1;
            this.marco.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marco);
            this.Controls.Add(this.crearPixel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.marco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearPixel;
        private System.Windows.Forms.PictureBox marco;
    }
}

