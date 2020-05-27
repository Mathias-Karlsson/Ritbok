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
            this.pensize = new System.Windows.Forms.TextBox();
            this.undoButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
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
            this.cube.Size = new System.Drawing.Size(51, 17);
            this.cube.TabIndex = 2;
            this.cube.TabStop = true;
            this.cube.Text = "Circle";
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // pensize
            // 
            this.pensize.Location = new System.Drawing.Point(189, 12);
            this.pensize.Name = "pensize";
            this.pensize.Size = new System.Drawing.Size(100, 20);
            this.pensize.TabIndex = 12;
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(243, 316);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(46, 27);
            this.undoButton.TabIndex = 13;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redButton
            // 
            this.redButton.Location = new System.Drawing.Point(0, 222);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 23);
            this.redButton.TabIndex = 14;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.Location = new System.Drawing.Point(0, 251);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(75, 23);
            this.blackButton.TabIndex = 15;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.Location = new System.Drawing.Point(0, 280);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(75, 23);
            this.blueButton.TabIndex = 16;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 355);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.pensize);
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
        private System.Windows.Forms.TextBox pensize;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button blueButton;
    }
}

