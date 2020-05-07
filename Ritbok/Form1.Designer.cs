namespace Ritbok
{
    partial class Form1
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
            this.line = new System.Windows.Forms.RadioButton();
            this.long_box = new System.Windows.Forms.RadioButton();
            this.cube = new System.Windows.Forms.RadioButton();
            this.triangel = new System.Windows.Forms.RadioButton();
            this.pen = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(12, 67);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(47, 17);
            this.line.TabIndex = 0;
            this.line.TabStop = true;
            this.line.Text = "Linje";
            this.line.UseVisualStyleBackColor = true;
            // 
            // long_box
            // 
            this.long_box.AutoSize = true;
            this.long_box.Location = new System.Drawing.Point(12, 90);
            this.long_box.Name = "long_box";
            this.long_box.Size = new System.Drawing.Size(74, 17);
            this.long_box.TabIndex = 1;
            this.long_box.TabStop = true;
            this.long_box.Text = "Rektangel";
            this.long_box.UseVisualStyleBackColor = true;
            // 
            // cube
            // 
            this.cube.AutoSize = true;
            this.cube.Location = new System.Drawing.Point(12, 113);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(62, 17);
            this.cube.TabIndex = 2;
            this.cube.TabStop = true;
            this.cube.Text = "Kvadrat";
            this.cube.UseVisualStyleBackColor = true;
            // 
            // triangel
            // 
            this.triangel.AutoSize = true;
            this.triangel.Location = new System.Drawing.Point(12, 136);
            this.triangel.Name = "triangel";
            this.triangel.Size = new System.Drawing.Size(63, 17);
            this.triangel.TabIndex = 3;
            this.triangel.TabStop = true;
            this.triangel.Text = "Triangel";
            this.triangel.UseVisualStyleBackColor = true;
            // 
            // pen
            // 
            this.pen.AutoSize = true;
            this.pen.Location = new System.Drawing.Point(12, 159);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(62, 17);
            this.pen.TabIndex = 4;
            this.pen.TabStop = true;
            this.pen.Text = "Pennan";
            this.pen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 331);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.triangel);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.long_box);
            this.Controls.Add(this.line);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton line;
        private System.Windows.Forms.RadioButton long_box;
        private System.Windows.Forms.RadioButton cube;
        private System.Windows.Forms.RadioButton triangel;
        private System.Windows.Forms.RadioButton pen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

