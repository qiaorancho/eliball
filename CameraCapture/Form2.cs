using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CameraCapture
{
    public partial class Form2 : Form
    { 
       public PictureBox imageControl = new PictureBox();
       public PictureBox hitLocation = new PictureBox();
       public Bitmap image;
       public Bitmap image1 = new Bitmap("C:\\Users\\Andrew\\Downloads\\ducks\\Red1_Duck.png");
       public Bitmap image2 = new Bitmap("C:\\Users\\Andrew\\Downloads\\ducks\\Red2_Duck.png");
       public Bitmap image3 = new Bitmap("C:\\Users\\Andrew\\Downloads\\ducks\\Red3_Duck.png");

       public Bitmap imageDead = new Bitmap("C:\\Users\\Andrew\\Downloads\\ducks\\RedFall_Duck.png");
       public Bitmap hitImage = new Bitmap("C:\\Users\\Andrew\\Downloads\\ducks\\hit.png");

        public Form2()
        {
            InitializeComponent();
            System.Console.WriteLine("Initializing form2");
        }


        private void Form2_Load_1(object sender, EventArgs e)
        {

            System.Console.WriteLine("Form 2 load");
            imageControl.Width = 67;
            imageControl.Height = 56;

            //

            imageControl.Image = (Image)image;
            //imageControl.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            imageControl.Location = new Point(100, 100);
            //imageControl.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            hitLocation.Width = 20;
            hitLocation.Height = 20;
            hitLocation.Image = (Image)hitImage;

            Controls.Add(imageControl);
            Controls.Add(hitLocation);
        }

    }
    }

