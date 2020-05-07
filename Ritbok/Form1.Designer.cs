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
            this.colorwhite = new System.Windows.Forms.RadioButton();
            this.colorblack = new System.Windows.Forms.RadioButton();
            this.colorblue = new System.Windows.Forms.RadioButton();
            this.colorbrown = new System.Windows.Forms.RadioButton();
            this.colorred = new System.Windows.Forms.RadioButton();
            this.colorgreen = new System.Windows.Forms.RadioButton();
            this.pensize = new System.Windows.Forms.TextBox();
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
            this.line.CheckedChanged += new System.EventHandler(this.line_CheckedChanged);
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
            this.long_box.CheckedChanged += new System.EventHandler(this.long_box_CheckedChanged);
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
            this.cube.CheckedChanged += new System.EventHandler(this.cube_CheckedChanged);
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
            this.triangel.CheckedChanged += new System.EventHandler(this.triangel_CheckedChanged);
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
            this.pen.CheckedChanged += new System.EventHandler(this.pen_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 331);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colorwhite
            // 
            this.colorwhite.AutoSize = true;
            this.colorwhite.Location = new System.Drawing.Point(12, 280);
            this.colorwhite.Name = "colorwhite";
            this.colorwhite.Size = new System.Drawing.Size(53, 17);
            this.colorwhite.TabIndex = 6;
            this.colorwhite.TabStop = true;
            this.colorwhite.Text = "White";
            this.colorwhite.UseVisualStyleBackColor = true;
            // 
            // colorblack
            // 
            this.colorblack.AutoSize = true;
            this.colorblack.Location = new System.Drawing.Point(104, 280);
            this.colorblack.Name = "colorblack";
            this.colorblack.Size = new System.Drawing.Size(52, 17);
            this.colorblack.TabIndex = 7;
            this.colorblack.TabStop = true;
            this.colorblack.Text = "Black";
            this.colorblack.UseVisualStyleBackColor = true;
            // 
            // colorblue
            // 
            this.colorblue.AutoSize = true;
            this.colorblue.Location = new System.Drawing.Point(195, 280);
            this.colorblue.Name = "colorblue";
            this.colorblue.Size = new System.Drawing.Size(46, 17);
            this.colorblue.TabIndex = 8;
            this.colorblue.TabStop = true;
            this.colorblue.Text = "Blue";
            this.colorblue.UseVisualStyleBackColor = true;
            // 
            // colorbrown
            // 
            this.colorbrown.AutoSize = true;
            this.colorbrown.Location = new System.Drawing.Point(13, 303);
            this.colorbrown.Name = "colorbrown";
            this.colorbrown.Size = new System.Drawing.Size(55, 17);
            this.colorbrown.TabIndex = 9;
            this.colorbrown.TabStop = true;
            this.colorbrown.Text = "Brown";
            this.colorbrown.UseVisualStyleBackColor = true;
            // 
            // colorred
            // 
            this.colorred.AutoSize = true;
            this.colorred.Location = new System.Drawing.Point(104, 303);
            this.colorred.Name = "colorred";
            this.colorred.Size = new System.Drawing.Size(45, 17);
            this.colorred.TabIndex = 10;
            this.colorred.TabStop = true;
            this.colorred.Text = "Red";
            this.colorred.UseVisualStyleBackColor = true;
            // 
            // colorgreen
            // 
            this.colorgreen.AutoSize = true;
            this.colorgreen.Location = new System.Drawing.Point(195, 303);
            this.colorgreen.Name = "colorgreen";
            this.colorgreen.Size = new System.Drawing.Size(54, 17);
            this.colorgreen.TabIndex = 11;
            this.colorgreen.TabStop = true;
            this.colorgreen.Text = "Green";
            this.colorgreen.UseVisualStyleBackColor = true;
            // 
            // pensize
            // 
            this.pensize.Location = new System.Drawing.Point(189, 12);
            this.pensize.Name = "pensize";
            this.pensize.Size = new System.Drawing.Size(100, 20);
            this.pensize.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 355);
            this.Controls.Add(this.pensize);
            this.Controls.Add(this.colorgreen);
            this.Controls.Add(this.colorred);
            this.Controls.Add(this.colorbrown);
            this.Controls.Add(this.colorblue);
            this.Controls.Add(this.colorblack);
            this.Controls.Add(this.colorwhite);
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
        private System.Windows.Forms.RadioButton colorwhite;
        private System.Windows.Forms.RadioButton colorblack;
        private System.Windows.Forms.RadioButton colorblue;
        private System.Windows.Forms.RadioButton colorbrown;
        private System.Windows.Forms.RadioButton colorred;
        private System.Windows.Forms.RadioButton colorgreen;
        private System.Windows.Forms.TextBox pensize;
    }
}

