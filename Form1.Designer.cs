namespace lab3_CG
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Fractal_Cesaro_line_tab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_drawFractal = new System.Windows.Forms.Button();
            this.btn_previousIteration = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nextIteration = new System.Windows.Forms.Button();
            this.Y_txt = new System.Windows.Forms.TextBox();
            this.X_txt = new System.Windows.Forms.TextBox();
            this.countIterations_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Algebraic_fractal_tab = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.createFractal_btn = new System.Windows.Forms.Button();
            this.ColorPicker_btn = new System.Windows.Forms.Button();
            this.maxIterations_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.min_Y_txt = new System.Windows.Forms.TextBox();
            this.min_X_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.max_Y_txt = new System.Windows.Forms.TextBox();
            this.max_X_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fractal_gallery = new System.Windows.Forms.TabPage();
            this.btn_saveFractal = new System.Windows.Forms.Button();
            this.btn_saveFractal2 = new System.Windows.Forms.Button();
            this.listViewGallery = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.Fractal_Cesaro_line_tab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Algebraic_fractal_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Fractal_gallery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Fractal_Cesaro_line_tab);
            this.tabControl1.Controls.Add(this.Algebraic_fractal_tab);
            this.tabControl1.Controls.Add(this.Fractal_gallery);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 605);
            this.tabControl1.TabIndex = 0;
            // 
            // Fractal_Cesaro_line_tab
            // 
            this.Fractal_Cesaro_line_tab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Fractal_Cesaro_line_tab.Controls.Add(this.panel2);
            this.Fractal_Cesaro_line_tab.Controls.Add(this.panel1);
            this.Fractal_Cesaro_line_tab.Location = new System.Drawing.Point(4, 35);
            this.Fractal_Cesaro_line_tab.Name = "Fractal_Cesaro_line_tab";
            this.Fractal_Cesaro_line_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Fractal_Cesaro_line_tab.Size = new System.Drawing.Size(1072, 566);
            this.Fractal_Cesaro_line_tab.TabIndex = 0;
            this.Fractal_Cesaro_line_tab.Text = "Fractal Cesaro line";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(502, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 553);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 526);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_saveFractal);
            this.panel1.Controls.Add(this.btn_drawFractal);
            this.panel1.Controls.Add(this.btn_previousIteration);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_nextIteration);
            this.panel1.Controls.Add(this.Y_txt);
            this.panel1.Controls.Add(this.X_txt);
            this.panel1.Controls.Add(this.countIterations_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 553);
            this.panel1.TabIndex = 15;
            // 
            // btn_drawFractal
            // 
            this.btn_drawFractal.Location = new System.Drawing.Point(70, 305);
            this.btn_drawFractal.Name = "btn_drawFractal";
            this.btn_drawFractal.Size = new System.Drawing.Size(169, 72);
            this.btn_drawFractal.TabIndex = 10;
            this.btn_drawFractal.Text = "Draw a fractal";
            this.btn_drawFractal.UseVisualStyleBackColor = true;
            this.btn_drawFractal.Click += new System.EventHandler(this.btn_drawFractal_Click);
            // 
            // btn_previousIteration
            // 
            this.btn_previousIteration.Location = new System.Drawing.Point(21, 383);
            this.btn_previousIteration.Name = "btn_previousIteration";
            this.btn_previousIteration.Size = new System.Drawing.Size(147, 77);
            this.btn_previousIteration.TabIndex = 11;
            this.btn_previousIteration.Text = "Previous iteration";
            this.btn_previousIteration.UseVisualStyleBackColor = true;
            this.btn_previousIteration.Click += new System.EventHandler(this.btn_previousIteration_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fractal Cesaro line, step";
            // 
            // btn_nextIteration
            // 
            this.btn_nextIteration.Location = new System.Drawing.Point(183, 383);
            this.btn_nextIteration.Name = "btn_nextIteration";
            this.btn_nextIteration.Size = new System.Drawing.Size(147, 77);
            this.btn_nextIteration.TabIndex = 12;
            this.btn_nextIteration.Text = "Next iteration";
            this.btn_nextIteration.UseVisualStyleBackColor = true;
            this.btn_nextIteration.Click += new System.EventHandler(this.btn_nextIteration_Click);
            // 
            // Y_txt
            // 
            this.Y_txt.Location = new System.Drawing.Point(70, 246);
            this.Y_txt.Name = "Y_txt";
            this.Y_txt.Size = new System.Drawing.Size(168, 34);
            this.Y_txt.TabIndex = 9;
            // 
            // X_txt
            // 
            this.X_txt.Location = new System.Drawing.Point(70, 164);
            this.X_txt.Name = "X_txt";
            this.X_txt.Size = new System.Drawing.Size(168, 34);
            this.X_txt.TabIndex = 8;
            // 
            // countIterations_txt
            // 
            this.countIterations_txt.Location = new System.Drawing.Point(230, 19);
            this.countIterations_txt.Name = "countIterations_txt";
            this.countIterations_txt.Size = new System.Drawing.Size(119, 34);
            this.countIterations_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Generating center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of iterations";
            // 
            // Algebraic_fractal_tab
            // 
            this.Algebraic_fractal_tab.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Algebraic_fractal_tab.Controls.Add(this.btn_saveFractal2);
            this.Algebraic_fractal_tab.Controls.Add(this.pictureBox2);
            this.Algebraic_fractal_tab.Controls.Add(this.createFractal_btn);
            this.Algebraic_fractal_tab.Controls.Add(this.ColorPicker_btn);
            this.Algebraic_fractal_tab.Controls.Add(this.maxIterations_txt);
            this.Algebraic_fractal_tab.Controls.Add(this.label11);
            this.Algebraic_fractal_tab.Controls.Add(this.label12);
            this.Algebraic_fractal_tab.Controls.Add(this.min_Y_txt);
            this.Algebraic_fractal_tab.Controls.Add(this.min_X_txt);
            this.Algebraic_fractal_tab.Controls.Add(this.label9);
            this.Algebraic_fractal_tab.Controls.Add(this.label10);
            this.Algebraic_fractal_tab.Controls.Add(this.max_Y_txt);
            this.Algebraic_fractal_tab.Controls.Add(this.max_X_txt);
            this.Algebraic_fractal_tab.Controls.Add(this.label8);
            this.Algebraic_fractal_tab.Controls.Add(this.label7);
            this.Algebraic_fractal_tab.Controls.Add(this.label6);
            this.Algebraic_fractal_tab.Location = new System.Drawing.Point(4, 35);
            this.Algebraic_fractal_tab.Name = "Algebraic_fractal_tab";
            this.Algebraic_fractal_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Algebraic_fractal_tab.Size = new System.Drawing.Size(1072, 566);
            this.Algebraic_fractal_tab.TabIndex = 1;
            this.Algebraic_fractal_tab.Text = "Algebraic fractal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(495, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(547, 513);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // createFractal_btn
            // 
            this.createFractal_btn.Location = new System.Drawing.Point(201, 411);
            this.createFractal_btn.Name = "createFractal_btn";
            this.createFractal_btn.Size = new System.Drawing.Size(161, 60);
            this.createFractal_btn.TabIndex = 22;
            this.createFractal_btn.Text = "Draw a fractal";
            this.createFractal_btn.UseVisualStyleBackColor = true;
            this.createFractal_btn.Click += new System.EventHandler(this.createFractal_btn_Click);
            // 
            // ColorPicker_btn
            // 
            this.ColorPicker_btn.Location = new System.Drawing.Point(25, 411);
            this.ColorPicker_btn.Name = "ColorPicker_btn";
            this.ColorPicker_btn.Size = new System.Drawing.Size(158, 60);
            this.ColorPicker_btn.TabIndex = 21;
            this.ColorPicker_btn.Text = "Change color";
            this.ColorPicker_btn.UseVisualStyleBackColor = true;
            this.ColorPicker_btn.Click += new System.EventHandler(this.ColorPicker_btn_Click);
            // 
            // maxIterations_txt
            // 
            this.maxIterations_txt.Location = new System.Drawing.Point(25, 340);
            this.maxIterations_txt.Name = "maxIterations_txt";
            this.maxIterations_txt.Size = new System.Drawing.Size(228, 34);
            this.maxIterations_txt.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 216);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "X";
            // 
            // min_Y_txt
            // 
            this.min_Y_txt.Location = new System.Drawing.Point(297, 213);
            this.min_Y_txt.Margin = new System.Windows.Forms.Padding(5);
            this.min_Y_txt.Name = "min_Y_txt";
            this.min_Y_txt.Size = new System.Drawing.Size(160, 34);
            this.min_Y_txt.TabIndex = 17;
            // 
            // min_X_txt
            // 
            this.min_X_txt.Location = new System.Drawing.Point(54, 211);
            this.min_X_txt.Margin = new System.Windows.Forms.Padding(5);
            this.min_X_txt.Name = "min_X_txt";
            this.min_X_txt.Size = new System.Drawing.Size(160, 34);
            this.min_X_txt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "X";
            // 
            // max_Y_txt
            // 
            this.max_Y_txt.Location = new System.Drawing.Point(297, 80);
            this.max_Y_txt.Margin = new System.Windows.Forms.Padding(5);
            this.max_Y_txt.Name = "max_Y_txt";
            this.max_Y_txt.Size = new System.Drawing.Size(160, 34);
            this.max_Y_txt.TabIndex = 13;
            // 
            // max_X_txt
            // 
            this.max_X_txt.Location = new System.Drawing.Point(54, 78);
            this.max_X_txt.Margin = new System.Windows.Forms.Padding(5);
            this.max_X_txt.Name = "max_X_txt";
            this.max_X_txt.Size = new System.Drawing.Size(160, 34);
            this.max_X_txt.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(389, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Enter the maximum number of iterations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Minimum values";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maximum values";
            // 
            // Fractal_gallery
            // 
            this.Fractal_gallery.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Fractal_gallery.Controls.Add(this.listViewGallery);
            this.Fractal_gallery.Location = new System.Drawing.Point(4, 35);
            this.Fractal_gallery.Name = "Fractal_gallery";
            this.Fractal_gallery.Size = new System.Drawing.Size(1072, 566);
            this.Fractal_gallery.TabIndex = 2;
            this.Fractal_gallery.Text = "Fractal gallery";
            // 
            // btn_saveFractal
            // 
            this.btn_saveFractal.Location = new System.Drawing.Point(336, 383);
            this.btn_saveFractal.Name = "btn_saveFractal";
            this.btn_saveFractal.Size = new System.Drawing.Size(141, 77);
            this.btn_saveFractal.TabIndex = 13;
            this.btn_saveFractal.Text = "Save fractal";
            this.btn_saveFractal.UseVisualStyleBackColor = true;
            this.btn_saveFractal.Click += new System.EventHandler(this.btn_saveFractal_Click);
            // 
            // btn_saveFractal2
            // 
            this.btn_saveFractal2.Location = new System.Drawing.Point(129, 481);
            this.btn_saveFractal2.Name = "btn_saveFractal2";
            this.btn_saveFractal2.Size = new System.Drawing.Size(161, 55);
            this.btn_saveFractal2.TabIndex = 24;
            this.btn_saveFractal2.Text = "Save fractal";
            this.btn_saveFractal2.UseVisualStyleBackColor = true;
            this.btn_saveFractal2.Click += new System.EventHandler(this.btn_saveFractal2_Click);
            // 
            // listViewGallery
            // 
            this.listViewGallery.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listViewGallery.HideSelection = false;
            this.listViewGallery.Location = new System.Drawing.Point(0, 0);
            this.listViewGallery.Name = "listViewGallery";
            this.listViewGallery.Size = new System.Drawing.Size(1072, 566);
            this.listViewGallery.TabIndex = 0;
            this.listViewGallery.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 615);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Fractal_Cesaro_line_tab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Algebraic_fractal_tab.ResumeLayout(false);
            this.Algebraic_fractal_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Fractal_gallery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Fractal_Cesaro_line_tab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_drawFractal;
        private System.Windows.Forms.Button btn_previousIteration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_nextIteration;
        private System.Windows.Forms.TextBox Y_txt;
        private System.Windows.Forms.TextBox X_txt;
        private System.Windows.Forms.TextBox countIterations_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Algebraic_fractal_tab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button createFractal_btn;
        private System.Windows.Forms.Button ColorPicker_btn;
        private System.Windows.Forms.TextBox maxIterations_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox min_Y_txt;
        private System.Windows.Forms.TextBox min_X_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox max_Y_txt;
        private System.Windows.Forms.TextBox max_X_txt;
        private System.Windows.Forms.TabPage Fractal_gallery;
        private System.Windows.Forms.Button btn_saveFractal;
        private System.Windows.Forms.Button btn_saveFractal2;
        private System.Windows.Forms.ListView listViewGallery;
    }
}

