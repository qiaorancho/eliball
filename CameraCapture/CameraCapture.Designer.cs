namespace CameraCapture
{
    partial class CameraCapture
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
            ReleaseData();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.showValues = new System.Windows.Forms.Button();
            this.plusHueMax = new System.Windows.Forms.Button();
            this.minusHueMax = new System.Windows.Forms.Button();

            this.plusHueMin = new System.Windows.Forms.Button();
            this.minusHueMin = new System.Windows.Forms.Button();


            this.plusValMax = new System.Windows.Forms.Button();
            this.minusValMax = new System.Windows.Forms.Button();

            this.plusValMin = new System.Windows.Forms.Button();
            this.minusValMin = new System.Windows.Forms.Button();


            this.plusSatMax = new System.Windows.Forms.Button();
            this.minusSatMax = new System.Windows.Forms.Button();

            this.plusSatMin = new System.Windows.Forms.Button();
            this.minusSatMin = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
           // this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
           // this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.grayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.smoothedGrayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.cannyImageBox = new Emgu.CV.UI.ImageBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
           // this.splitContainer3.Panel1.SuspendLayout();
            //this.splitContainer3.Panel2.SuspendLayout();
            //this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
           // this.splitContainer4.Panel1.SuspendLayout();
            //this.splitContainer4.Panel2.SuspendLayout();
            //this.splitContainer4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
         //   this.splitContainer1.Panel1.Controls.Add(this.flipVerticalButton);
           // this.splitContainer1.Panel1.Controls.Add(this.flipHorizontalButton);
            //this.splitContainer1.Panel1.Controls.Add(this.captureButton);

            this.splitContainer1.Panel1.Controls.Add(this.showValues);
            this.splitContainer1.Panel1.Controls.Add(this.plusHueMax);
            this.splitContainer1.Panel1.Controls.Add(this.plusHueMin);
            this.splitContainer1.Panel1.Controls.Add(this.minusHueMax);
            this.splitContainer1.Panel1.Controls.Add(this.minusHueMin);

            this.splitContainer1.Panel1.Controls.Add(this.plusSatMax);
            this.splitContainer1.Panel1.Controls.Add(this.plusSatMin);
            this.splitContainer1.Panel1.Controls.Add(this.minusSatMax);
            this.splitContainer1.Panel1.Controls.Add(this.minusSatMin);

            this.splitContainer1.Panel1.Controls.Add(this.plusValMax);
            this.splitContainer1.Panel1.Controls.Add(this.plusValMin);
            this.splitContainer1.Panel1.Controls.Add(this.minusValMax);
            this.splitContainer1.Panel1.Controls.Add(this.minusValMin);




            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(950, 832);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 0;
            // 





            this.showValues.Location = new System.Drawing.Point(860, 12);
            this.showValues.Name = "show";
            this.showValues.Size = new System.Drawing.Size(30, 23);
            this.showValues.TabIndex = 15;
            this.showValues.Text = "show";
            this.showValues.UseVisualStyleBackColor = true;
            this.showValues.Click += new System.EventHandler(this.showVals);

            this.minusSatMin.Location = new System.Drawing.Point(794, 12);
            this.minusSatMin.Name = "minusSatMin";
            this.minusSatMin.Size = new System.Drawing.Size(60, 23);
            this.minusSatMin.TabIndex = 14;
            this.minusSatMin.Text = "-S_Min";
            this.minusSatMin.UseVisualStyleBackColor = true;
            this.minusSatMin.Click += new System.EventHandler(this.minusSatMinClick);


            this.plusSatMin.Location = new System.Drawing.Point(722, 12);
            this.plusSatMin.Name = "plusSatMin";
            this.plusSatMin.Size = new System.Drawing.Size(60, 23);
            this.plusSatMin.TabIndex = 13;
            this.plusSatMin.Text = "+S_Min";
            this.plusSatMin.UseVisualStyleBackColor = true;
            this.plusSatMin.Click += new System.EventHandler(this.plusSatMinClick);

            // flipVerticalButton
            // 
            this.minusSatMax.Location = new System.Drawing.Point(660, 12);
            this.minusSatMax.Name = "minusValMax";
            this.minusSatMax.Size = new System.Drawing.Size(60, 23);
            this.minusSatMax.TabIndex = 12;
            this.minusSatMax.Text = "-S_Max";
            this.minusSatMax.UseVisualStyleBackColor = true;
            this.minusSatMax.Click += new System.EventHandler(this.minusSatMaxClick);

            // flipVerticalButton
            // 
            this.plusSatMax.Location = new System.Drawing.Point(588, 12);
            this.plusSatMax.Name = "plusSatMax";
            this.plusSatMax.Size = new System.Drawing.Size(60, 23);
            this.plusSatMax.TabIndex = 11;
            this.plusSatMax.Text = "+S_Max";
            this.plusSatMax.UseVisualStyleBackColor = true;
            this.plusSatMax.Click += new System.EventHandler(this.plusSatMaxClick);



            this.minusValMin.Location = new System.Drawing.Point(516, 12);
            this.minusValMin.Name = "minusHueMin";
            this.minusValMin.Size = new System.Drawing.Size(60, 23);
            this.minusValMin.TabIndex = 10;
            this.minusValMin.Text = "-V_Min";
            this.minusValMin.UseVisualStyleBackColor = true;
            this.minusValMin.Click += new System.EventHandler(this.minusValMinClick);


            this.plusValMin.Location = new System.Drawing.Point(444, 12);
            this.plusValMin.Name = "plusValMin";
            this.plusValMin.Size = new System.Drawing.Size(60, 23);
            this.plusValMin.TabIndex = 9;
            this.plusValMin.Text = "+V_Min";
            this.plusValMin.UseVisualStyleBackColor = true;
            this.plusValMin.Click += new System.EventHandler(this.plusValMinClick);

            // flipVerticalButton
            // 
            this.minusValMax.Location = new System.Drawing.Point(372, 12);
            this.minusValMax.Name = "minusValMax";
            this.minusValMax.Size = new System.Drawing.Size(60, 23);
            this.minusValMax.TabIndex = 8;
            this.minusValMax.Text = "-V_Max";
            this.minusValMax.UseVisualStyleBackColor = true;
            this.minusValMax.Click += new System.EventHandler(this.minusValMaxClick);

            // flipVerticalButton
            // 
            this.plusValMax.Location = new System.Drawing.Point(300, 12);
            this.plusValMax.Name = "plusValMax";
            this.plusValMax.Size = new System.Drawing.Size(60, 23);
            this.plusValMax.TabIndex = 7;
            this.plusValMax.Text = "+V_Max";
            this.plusValMax.UseVisualStyleBackColor = true;
            this.plusValMax.Click += new System.EventHandler(this.plusValMaxClick);

            this.minusHueMin.Location = new System.Drawing.Point(228, 12);
            this.minusHueMin.Name = "minusHueMin";
            this.minusHueMin.Size = new System.Drawing.Size(60, 23);
            this.minusHueMin.TabIndex = 6;
            this.minusHueMin.Text = "-H_Min";
            this.minusHueMin.UseVisualStyleBackColor = true;
            this.minusHueMin.Click += new System.EventHandler(this.minusHueMinClick);


            this.plusHueMin.Location = new System.Drawing.Point(156, 12);
            this.plusHueMin.Name = "minusHueMin";
            this.plusHueMin.Size = new System.Drawing.Size(60, 23);
            this.plusHueMin.TabIndex = 5;
            this.plusHueMin.Text = "+H_Min";
            this.plusHueMin.UseVisualStyleBackColor = true;
            this.plusHueMin.Click += new System.EventHandler(this.plusHueMinClick);

            // flipVerticalButton
            // 
            this.minusHueMax.Location = new System.Drawing.Point(84, 12);
            this.minusHueMax.Name = "minusHueMax";
            this.minusHueMax.Size = new System.Drawing.Size(60, 23);
            this.minusHueMax.TabIndex = 4;
            this.minusHueMax.Text = "-H_Max";
            this.minusHueMax.UseVisualStyleBackColor = true;
            this.minusHueMax.Click += new System.EventHandler(this.minusHueMaxClick);

            // flipVerticalButton
            // 
            this.plusHueMax.Location = new System.Drawing.Point(12, 12);
            this.plusHueMax.Name = "plusHueMax";
            this.plusHueMax.Size = new System.Drawing.Size(60, 23);
            this.plusHueMax.TabIndex = 3;
            this.plusHueMax.Text = "+H_Max";
            this.plusHueMax.UseVisualStyleBackColor = true;
            this.plusHueMax.Click += new System.EventHandler(this.plusHueMaxClick);

            /*

            // flipVerticalButton
            // 
            this.flipVerticalButton.Location = new System.Drawing.Point(305, 12);
            this.flipVerticalButton.Name = "flipVerticalButton";
            this.flipVerticalButton.Size = new System.Drawing.Size(102, 23);
            this.flipVerticalButton.TabIndex = 2;
            this.flipVerticalButton.Text = "+HueMax";
            this.flipVerticalButton.UseVisualStyleBackColor = true;
            this.flipVerticalButton.Click += new System.EventHandler(this.FlipVerticalButtonClick);
            // 
            // flipHorizontalButton
            // 
            this.flipHorizontalButton.Location = new System.Drawing.Point(162, 12);
            this.flipHorizontalButton.Name = "flipHorizontalButton";
            this.flipHorizontalButton.Size = new System.Drawing.Size(102, 23);
            this.flipHorizontalButton.TabIndex = 1;
            this.flipHorizontalButton.Text = "Flip Horizontal";
            this.flipHorizontalButton.UseVisualStyleBackColor = true;
            this.flipHorizontalButton.Click += new System.EventHandler(this.FlipHorizontalButtonClick);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(15, 12);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(102, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButtonClick);
            // 
             */
             
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
           // this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(900, 900);
            this.splitContainer2.SplitterDistance = 900;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
         
            // splitContainer3.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.captureImageBox);
           // this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            //this.splitContainer3.Panel2.Controls.Add(this.smoothedGrayscaleImageBox);
            //this.splitContainer3.Panel2.Controls.Add(this.panel3);
            //this.splitContainer3.Size = new System.Drawing.Size(900, 900);
            //this.splitContainer3.SplitterDistance = 378;
            //this.splitContainer3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 33);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Captured Image:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 36);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Smoothed Grayscale:";
            // 
            // splitContainer4
            // 
           // this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            //this.splitContainer4.Name = "splitContainer4";
            //this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
          //  this.splitContainer4.Panel1.Controls.Add(this.grayscaleImageBox);
            //this.splitContainer4.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer4.Panel2
            // 
           // this.splitContainer4.Panel2.Controls.Add(this.cannyImageBox);
          //  this.splitContainer4.Panel2.Controls.Add(this.panel4);
           // this.splitContainer4.Size = new System.Drawing.Size(427, 784);
            //this.splitContainer4.SplitterDistance = 378;
            //this.splitContainer4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 33);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grayscale Image:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 35);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Canny Edges:";
            // 
            // captureImageBox
            // 
            this.captureImageBox.Dock = System.Windows.Forms.DockStyle.None;
            this.captureImageBox.Image = null;
            this.captureImageBox.Location = new System.Drawing.Point(0, 33);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(900, 900);
            this.captureImageBox.TabIndex = 1;
            // 
            // grayscaleImageBox
            // 
            this.grayscaleImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayscaleImageBox.Image = null;
            this.grayscaleImageBox.Location = new System.Drawing.Point(0, 33);
            this.grayscaleImageBox.Name = "grayscaleImageBox";
            this.grayscaleImageBox.Size = new System.Drawing.Size(1, 1);
            this.grayscaleImageBox.TabIndex = 1;
            // 
            // smoothedGrayscaleImageBox
            // 
            this.smoothedGrayscaleImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smoothedGrayscaleImageBox.Image = null;
            this.smoothedGrayscaleImageBox.Location = new System.Drawing.Point(0, 36);
            this.smoothedGrayscaleImageBox.Name = "smoothedGrayscaleImageBox";
            this.smoothedGrayscaleImageBox.Size = new System.Drawing.Size(1, 1);
            this.smoothedGrayscaleImageBox.TabIndex = 1;
            // 
            // cannyImageBox
            // 
            this.cannyImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cannyImageBox.Image = null;
            this.cannyImageBox.Location = new System.Drawing.Point(0, 35);
            this.cannyImageBox.Name = "cannyImageBox";
            this.cannyImageBox.Size = new System.Drawing.Size(1, 1);
            this.cannyImageBox.TabIndex = 1;
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 832);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CameraCapture";
            this.Text = "Camera Capture";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
         //   this.splitContainer3.Panel1.ResumeLayout(false);
          //  this.splitContainer3.Panel2.ResumeLayout(false);
           // this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
           // this.splitContainer4.Panel1.ResumeLayout(false);
            //this.splitContainer4.Panel2.ResumeLayout(false);
            //his.splitContainer4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
       // private System.Windows.Forms.Button flipHorizontalButton;
        private System.Windows.Forms.Button flipVerticalButton;

        private System.Windows.Forms.Button plusHueMax;
        private System.Windows.Forms.Button minusHueMax;
        private System.Windows.Forms.Button plusHueMin;
        private System.Windows.Forms.Button minusHueMin;


        private System.Windows.Forms.Button plusSatMax;
        private System.Windows.Forms.Button minusSatMax;
        private System.Windows.Forms.Button plusSatMin;
        private System.Windows.Forms.Button minusSatMin;


        private System.Windows.Forms.Button plusValMax;
        private System.Windows.Forms.Button minusValMax;
        private System.Windows.Forms.Button plusValMin;
        private System.Windows.Forms.Button minusValMin;

        private System.Windows.Forms.Button showValues;



        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox captureImageBox;
        private Emgu.CV.UI.ImageBox grayscaleImageBox;
        private Emgu.CV.UI.ImageBox smoothedGrayscaleImageBox;
        private Emgu.CV.UI.ImageBox cannyImageBox;
    }
}

