using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace CameraCapture
{
   public partial class CameraCapture : Form
   {
      private Capture _capture;
      private Image<Bgr, Byte> _image;
      private Image<Gray, Byte> _collision;

      private bool _captureInProgress;
      private Rectangle _rect;
      private Point _centerPoint;
      private List<Size> _sizeArray;
      private List<Point> _pointArray;
      private List<CircleF> _collisionCircles;
      private Image<Gray, Byte> _dst;

      private bool _preCollision;
      private int _tick;


      private int _hueMax;
      private int _hueMin;
      private int _satMax;
      private int _satMin;
      private int _valMax;
      private int _valMin;

      private Point _collisionPoint;
      private Point _frameTopLeft;

      private Point _frameTopRight;

      private Point _frameBottomLeft;

      private Point _frameBottomRight;

      public CameraCapture()
      {
         InitializeComponent();

          _capture = new Capture();

          _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 854);
          _capture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 480);
          _preCollision = true;
          _tick = 10;

          _pointArray = new List<Point>();
          _sizeArray = new List<Size>();
          _collisionCircles = new List<CircleF>();

          /* original raquet
          _hueMax = 121;
          _hueMin=89;
          _valMax = 245;
          _valMin=81;
          _satMax = 243;
          _satMin = 148;
           */

      /*     
           _hueMax = 180;
          _hueMin=0;
          _valMax = 256;
          _valMin=0;
          _satMax = 256;
          _satMin = 0;
         */
          // hd raquet
          /*
          _hueMax = 134;
          _hueMin=100;
          _valMax = 256;
          _valMin=0;
          _satMax = 256;
          _satMin = 61;
          */

          //raquet with projector in dark room
          _hueMax = 134;
          _hueMin = 100;
          _valMax = 256;
          _valMin = 81;
          _satMax = 256;
          _satMin = 94;

          string found = "Starting camera capture";
          System.Console.WriteLine(found);

          Application.Idle += new EventHandler(ProcessFrame);

          var myForm = new Form1();
          myForm.Show();

      }

      public void calibrateCornerPoints()
      {
          Console.WriteLine("Starting Calibration");
          List<Rectangle> rects = new List<Rectangle>();
          int index = new int();
          using (MemStorage store = new MemStorage())
              for (Contour<Point> contours1 = _dst.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_NONE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, store); contours1 != null; contours1 = contours1.HNext)
              {
                  Rectangle newRect = CvInvoke.cvBoundingRect(contours1, 1);
                  if (newRect.Size.Height > 4 && newRect.Size.Width > 4)
                  {

                      rects.Add(newRect);

                      Console.WriteLine(newRect);
                  
                  }
              }

          Console.WriteLine("Done adding rects");
          List<Rectangle> biggestRects = new List<Rectangle>();

          Rectangle biggest = new Rectangle();
          Rectangle current = new Rectangle();
          while (biggestRects.Count < 4)
          {
              for (int i = 0; i < rects.Count; i++)
              {
                  current = rects[i];
                  if (biggest.Size.Height * biggest.Size.Width < current.Size.Height * current.Size.Width)
                  {
                      biggest = current;
                      index = i;
                  }
              }

              biggestRects.Add(biggest);

              Console.WriteLine(biggest);
              if (rects.Count-1 >= index)
              {
              rects.RemoveAt(index);
              }
              biggest = new Rectangle();

          }

          List<Rectangle> positions = new List<Rectangle>();
          while (positions.Count < 4)
          {
              for (int i = 0; i < biggestRects.Count; i++)
              {
                  current = biggestRects[i];

                  if (current.X * current.Y > biggest.X * biggest.Y)
                  {

                      biggest = current;
                      index = i;

                  }

              }

              positions.Add(biggest);

              Console.WriteLine(biggest);
              biggestRects.RemoveAt(index);
              biggest = new Rectangle();

          }
          Point br = new Point();
          br.X = positions[0].Location.X + positions[0].Size.Width;
          br.Y = positions[0].Location.Y + positions[0].Size.Height;
          _frameBottomRight = br;


          Point tr = new Point();
          tr.X = positions[1].Location.X + positions[0].Size.Width;
          tr.Y = positions[1].Location.Y;
          _frameTopRight = tr;

          Point bl = new Point();
          bl.X = positions[2].Location.X;
          bl.Y = positions[2].Location.Y + positions[2].Size.Height;
          _frameBottomLeft = bl;

          _frameTopLeft = positions[3].Location;

          Console.WriteLine("Calibration complete");
          Console.WriteLine("Bottom Right {0}. TopRight: {1}. BottomLeft {2}. TopLeft {3}", // <-- This is called a format string.
    _frameBottomRight,                        // <-- These are substitutions.
    _frameTopRight,
    _frameBottomLeft,
    _frameTopLeft);


      }

      private void ProcessFrame(object sender, EventArgs arg)
      {
          //Console.WriteLine("called process frame");
          updateFrame();
          //warpImage();
}

      private void captureButtonClick(object sender, EventArgs e)
      {
         #region if capture is not created, create it now
         if (_capture == null)
         {
            try
            {
                Console.WriteLine("about to create new capture");
               
             //  _capture.ImageGrabbed += ProcessFrame;
               Console.WriteLine("created new capture");

            }
            catch (NullReferenceException excpt)
            {
                Console.WriteLine(excpt.Message);

               MessageBox.Show(excpt.Message);
            }
         }
         #endregion

         if (_capture != null)
         {

             _image = _capture.QueryFrame();


             //  _image = _capture.RetrieveBgrFrame();

             Image<Gray, Byte> grayFrame = _image.Convert<Gray, Byte>();


          //   Image<Gray, Byte> img2 = grayFrame.Not();
            // Image<Gray, Byte> smallGrayFrame = img2.PyrDown();
             //Image<Gray, Byte> smoothedGrayFrame = smallGrayFrame.PyrUp();
             //Image<Gray, Byte> cannyFrame = smoothedGrayFrame.Canny(new Gray(100), new Gray(60));

             captureImageBox.Image = _image;
          //   grayscaleImageBox.Image = grayFrame;
            // smoothedGrayscaleImageBox.Image = smoothedGrayFrame;
             //cannyImageBox.Image = cannyFrame;
      
            _captureInProgress = !_captureInProgress;
         }
      }

      private void ReleaseData()
      {
         if (_capture != null)
            _capture.Dispose();
      }

      private void FlipHorizontalButtonClick(object sender, EventArgs e)
      {
         if (_capture != null) _capture.FlipHorizontal = !_capture.FlipHorizontal;
      }

      private void FlipVerticalButtonClick(object sender, EventArgs e)
      {
         if (_capture != null) _capture.FlipVertical = !_capture.FlipVertical;
      }

      private void updateFrame()
      {

          if (!_preCollision)
          {
              _tick--;
              if (_tick == 0)
              {
                  _preCollision = true;
                  _tick = 10;
              }
          }
          
          _image = _capture.QueryFrame().Flip(Emgu.CV.CvEnum.FLIP.HORIZONTAL);


          //	_image.Save(@"C:\Users\Andrew\Desktop\pics\MyPic.jpg");
        // Image<Bgr, byte> resizedImage = _image.Resize(160, 120, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);




          Image<Hsv, Byte> hsvimg = _image.Convert<Hsv, Byte>(); //hsv image
       

          Image<Gray, Byte>[] channels = hsvimg.Split(); 
          Image<Gray, Byte> imghue = channels[ 0 ];       // hue channel
          Image<Gray, Byte> imgsat = channels[ 1 ];       // saturation channel
          Image<Gray, Byte> imgval = channels[ 2 ];       // value channel
          Image<Gray, byte> huefilter = imghue.InRange(new Gray(_hueMin), new Gray(_hueMax));
          Image<Gray, byte> satfilter = imgsat.InRange(new Gray(_satMin), new Gray(_satMax));
          Image<Gray, byte> valfilter = imgval.InRange(new Gray(_valMin), new Gray(_valMax));
          Image<Gray, byte> filteredimg = huefilter.And(satfilter).And(valfilter);

          Image<Gray, Byte> src = filteredimg;
          _dst = new Image<Gray, Byte>(src.Width, src.Height);
          _dst = filteredimg;
          Image<Gray, Byte> dst2 = new Image<Gray, Byte>(src.Width, src.Height);
          StructuringElementEx element1 = new StructuringElementEx(2, 2, 1, 1, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_ELLIPSE);
          StructuringElementEx element2 = new StructuringElementEx(2, 2, 1, 1, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_ELLIPSE);

   //     CvInvoke.cvMorphologyEx(src, dst2, IntPtr.Zero, element1, Emgu.CV.CvEnum.CV_MORPH_OP.CV_MOP_OPEN, 1);

     //   CvInvoke.cvMorphologyEx(dst2, dst, IntPtr.Zero, element1, Emgu.CV.CvEnum.CV_MORPH_OP.CV_MOP_CLOSE, 1);


       //   PointF[] pts = PointCollection.GeneratePointCloud(modelEllipse, sampleCount);
          _rect.Location = new Point(0, 0);
          _rect.Size = new Size(6, 6);
          using (MemStorage store = new MemStorage())
              for (Contour<Point> contours1 = _dst.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_NONE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, store); contours1 != null; contours1 = contours1.HNext)
              {
                  Rectangle newRect = CvInvoke.cvBoundingRect(contours1, 1);
                  if (newRect.Size.Height * newRect.Size.Width > _rect.Size.Height * _rect.Size.Width)
                  {
                      _rect = newRect;



                  }
              }


          dst2 = _dst;

       //   calibrateCornerPoints();


          if (_rect.Height > 6 || _rect.Width>6 || _rect.Location.X !=0)
          {
              Point centerPoint = new Point();
              centerPoint.X = Convert.ToInt32(_rect.Location.X + _rect.Width / 2); //calculate mid point x
              centerPoint.Y = Convert.ToInt32(_rect.Location.Y + _rect.Height / 2); //calculate mid point y

             // System.Console.WriteLine(centerPoint);



              _centerPoint = centerPoint;
              _pointArray.Add(centerPoint);
              _sizeArray.Add(_rect.Size);
              dst2.Draw(_rect, new Gray(250.0), 1);

          }
          if (_pointArray.Count > 50)
          {
              
             // return;
              _pointArray = new List<Point>();
              _sizeArray = new List<Size>();
          }

        /*  if (_pointArray.Count > 1)
          {
              for (int i = 0; _pointArray.Count - 1 > i; i++)
              {
                  LineSegment2D line = new LineSegment2D(_pointArray[i], _pointArray[i + 1]);
                  if (_pointArray[i].X > _pointArray[i + 1].X)
                  {
                      //dst.Draw(line, new Gray(240.0), 1);
                  }
                  else
                  {
                      dst.Draw(line, new Gray(50.0), 1);
                  }
              }

          }*/
          //dst.ROI = _rect;

          //CvInvoke.cvMorphologyEx(dst, dst2, IntPtr.Zero, element2, Emgu.CV.CvEnum.CV_MORPH_OP.CV_MOP_CLOSE, 1);

        /*  if (_rect.Size.Height * _rect.Size.Width > 36 && _rect.Size.Height * _rect.Size.Width < 81)
          { //Call it a collision

              CircleF circ = new CircleF(centerPoint, 5);
              _collisionCircles.Add(circ);
           //   collisionDetected(dst);


              if (_collisionCircles.Count > 500) _collisionCircles = new List<CircleF>();

          }*/
          for (int i = 0; i < _collisionCircles.Count; i++)
          {
          //    dst.Draw(_collisionCircles[i], new Gray(50.0), 5);
          }

          for (int i = 0; i < _sizeArray.Count; i++)
          {
              Rectangle rect = new Rectangle(_pointArray[i], new Size(2, 2));
              dst2.Draw(rect, new Gray(100.0), 1);
          }



          Rectangle rect1 = new Rectangle(_frameTopLeft, new Size(4, 4));
          dst2.Draw(rect1, new Gray(130), 2);

         rect1 = new Rectangle(_frameTopRight, new Size(4, 4));
          dst2.Draw(rect1, new Gray(50), 2);

          rect1 = new Rectangle(_frameBottomLeft, new Size(4, 4));
          dst2.Draw(rect1, new Gray(90), 2);

           rect1 = new Rectangle(_frameBottomRight, new Size(4, 4));
          dst2.Draw(rect1, new Gray(170), 2);


         // Image<Gray, Byte> smoothedGrayFrame = dst2.PyrUp();
        //  Image<Gray, Byte> cannyFrame = dst.Canny(new Gray(100), new Gray(60));
          captureImageBox.Image = dst2;

          checkPoints(dst2);


      }


      private void checkPoints(Image<Gray, Byte> dst2)
      {
        
         // int arraySize = _pointArray.Length;

          if (_pointArray.Count > 2)
          {

              for (int i = 0; i < _pointArray.Count; i++)
              {


              }

              Point first = _pointArray[_pointArray.Count-3];
              
              Point second = _pointArray[_pointArray.Count-2];

              Point third = _pointArray[_pointArray.Count - 1];

        /*      Console.WriteLine("First {0}. Second: {1}. Third {2}.", // <-- This is called a format string.
        first,                        // <-- These are substitutions.
        second,
        third);
              */
              if (second.X > first.X && second.X > third.X && second.Y+50 > third.Y && second.Y - 50 < third.Y)
              {
                  _collisionPoint = second;

        //          System.Console.WriteLine("Collision at ");
          //        System.Console.WriteLine(_collisionPoint);

                  Point[] myArray =
                     {
                         _frameTopLeft,
                         _frameTopRight,
                         _frameBottomRight,
                         _frameBottomLeft
                     };

                  // Create a GraphicsPath object and add a polygon.
                  GraphicsPath myPath = new GraphicsPath();
                  myPath.AddPolygon(myArray);
                  Region region = new Region(myPath);
                  bool isInside = region.IsVisible(_collisionPoint);

                  Solver solver = new Solver();
                  DPoint l1 = new DPoint(_frameTopLeft.X, _frameTopLeft.Y);
                  DPoint l2 = new DPoint(_frameBottomLeft.X, _frameBottomLeft.Y);
                  DPoint r1 = new DPoint(_frameTopRight.X, _frameTopRight.Y);
                  DPoint r2 = new DPoint(_frameBottomRight.X, _frameBottomRight.Y);

                  DPoint origin = new DPoint(790, 564);
                  DPoint collisionPoint = new DPoint(_collisionPoint.X, _collisionPoint.Y);

                  DPoint _originPoint = solver.getOrigin(l1, l2, r1, r2, origin, collisionPoint);
              }

              if (_collisionPoint.X>0)
              {

                  Point indicator = _collisionPoint;
                  indicator.X = indicator.X - 10;
                  indicator.Y = indicator.Y - 10;

                  Rectangle rect = new Rectangle(indicator, new Size(20, 20));
                  dst2.Draw(rect, new Gray(230.0), 1);
              }


          }



      }


      private PointF computeIntersect(LineSegment2D a, LineSegment2D b)
      {

              int x1 = a.P1.X, y1 = a.P1.Y, x2 = a.P2.X, y2 = a.P2.Y;
    int x3 = b.P1.X, y3 = b.P1.Y, x4 = b.P2.X, y4 = b.P2.Y;
    float d = ((float)(x1-x2) * (y3-y4)) - ((y1-y2) * (x3-x4));
    if (d != 0)
    {
        PointF pt = new PointF();
        pt.X = ((x1 * y2 - y1 * x2) * (x3 - x4) - (x1 - x2) * (x3 * y4 - y3 * x4)) / d;
        pt.Y = ((x1 * y2 - y1 * x2) * (y3 - y4) - (y1 - y2) * (x3 * y4 - y3 * x4)) / d;
        return pt;
    }
    else
    {
        return new PointF(-1, -1);
    }

      }

      private void showVals(object sender, EventArgs e)
      {
       //   _image.Size();

          string values = 
              "HueMax:" + _hueMax.ToString() +
              "  HueMin:" + _hueMin.ToString() +
              "  ValMax:" + _valMax.ToString() +
              "  ValMin:" + _valMin.ToString() +
              "  SatMax:" + _satMax.ToString() +
              "  SatMin:" + _satMin.ToString() +
              "  Image size" + _image.Size +
              "  Bounding Rect" + _rect.Size + _rect.Location +
              "  Centerpoint"+ _centerPoint.X +","+ _centerPoint.Y;
          MessageBox.Show(values);
      }


      private void plusHueMaxClick(object sender, EventArgs e)
      {
          _hueMax += 1;
  
      }
      private void plusHueMinClick(object sender, EventArgs e)
      {
          _hueMin += 1;

      }
      private void minusHueMaxClick(object sender, EventArgs e)
      {
          _hueMax -= 1;
       
      }
      private void minusHueMinClick(object sender, EventArgs e)
      {
          _hueMin -= 1;
      }


      private void plusSatMaxClick(object sender, EventArgs e)
      {
          _satMax += 1;
        
      }
      private void plusSatMinClick(object sender, EventArgs e)
      {
          _satMin += 1;
          
      }
      private void minusSatMaxClick(object sender, EventArgs e)
      {
          _satMax -= 1;
         
      }
      private void minusSatMinClick(object sender, EventArgs e)
      {
          _satMin -= 1;
          
      }

      private void plusValMaxClick(object sender, EventArgs e)
      {
          _valMax += 1;
          
      }
      private void plusValMinClick(object sender, EventArgs e)
      {
          _valMin += 1;
      }
      private void minusValMaxClick(object sender, EventArgs e)
      {
          _valMax -= 1;
      }
      private void minusValMinClick(object sender, EventArgs e)
      {
          _valMin -= 1;
      }

      private void calibrateButtonClick(object sender, EventArgs e)
      {
          calibrateCornerPoints();
      }

   }
}
