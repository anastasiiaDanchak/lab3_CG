using System.Drawing;
using System.Windows.Forms;
using System;
using System.IO;
using System.Linq;

namespace lab3_CG
{
    public partial class Form1 : Form
    {
        float length;
        Bitmap image;
        int board = 20;
        int iteration;
        PointF Center = new PointF();

        float alpha = (float)(Math.Atan(0));
        float beta = (float)(85 * Math.PI / 180);


        private int maxIterations;
        private double MinX;
        private double MaxX;
        private double MinY;
        private double MaxY;
        private Color FractalColor = Color.Black;
        private Color GradientColor = Color.Red;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(500, 500);
            length = pictureBox1.Width - 50;
            image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(image).Clear(Color.White);
            pictureBox1.Image = image;
            countIterations_txt.Text = "5";
            X_txt.Text = "250";
            Y_txt.Text = "250";

            maxIterations_txt.Text = "1";
            min_X_txt.Text = "-2,0";
            max_X_txt.Text = "1,5";
            min_Y_txt.Text = "-2,0";
            max_Y_txt.Text = "2,0";

      
          
        }

        private void btn_drawFractal_Click(object sender, EventArgs e)
        {
            if ((countIterations_txt.Text == "") || (X_txt.Text == "") || (Y_txt.Text == ""))
                MessageBox.Show("Please fill in all fields");
            else
            {
                Center.X = Convert.ToSingle(X_txt.Text);
                Center.Y = Convert.ToSingle(Y_txt.Text);
                if ((Center.X <= 20 || Center.X >= pictureBox1.Width - 20) || (Center.Y <= 20 || Center.Y >= pictureBox1.Height - 20))
                {
                    MessageBox.Show("You have entered incorrect coordinates. Coordinates can be in the range from 20 to 480 in X and Y.");
                }
                else
                {
                    Pen black_pen = new Pen(Color.Black, 1);
                    Pen white_pen = new Pen(Color.White, 1);

                    Graphics.FromImage(image).Clear(Color.White);
                    pictureBox1.Image = image;
                    iteration = Convert.ToInt32(countIterations_txt.Text);
                    PointF firstPoint = SearchFirstPoint(Center, board, beta, ref length, pictureBox1);
                    Build(length, black_pen, white_pen, iteration, firstPoint, alpha);

                    pictureBox1.Image = image;
                    label5.Text = "Fractal Cesaro line, step " + iteration;
                }
            }
        }

        public void Build(float length, Pen black_pen, Pen white_pen, int iteration, PointF firstPoint, float alpha)
        {
            if (iteration == 0)
                return;

            float fakeLength = SearchDistance(length, beta);
            PointF[] Cesaro = new PointF[5];
            PointF[] white = new PointF[2];

            Cesaro[0] = firstPoint;
            Cesaro[1] = SearchNewPoint(Cesaro[0], fakeLength, alpha);
            white[0] = Cesaro[1];
            Cesaro[2] = SearchNewPoint(Cesaro[1], fakeLength, (float)(alpha - beta));
            Cesaro[3] = SearchNewPoint(Cesaro[2], fakeLength, (float)(alpha + beta));
            white[1] = Cesaro[3];
            Cesaro[4] = SearchNewPoint(Cesaro[3], fakeLength, alpha);

            Graphics.FromImage(image).DrawLines(black_pen, Cesaro);
            Graphics.FromImage(image).DrawLines(white_pen, white);
            iteration--;

            Build(fakeLength, black_pen, white_pen, iteration, Cesaro[0], alpha);
            Build(fakeLength, black_pen, white_pen, iteration, Cesaro[1], (alpha - beta));
            Build(fakeLength, black_pen, white_pen, iteration, Cesaro[2], (alpha + beta));
            Build(fakeLength, black_pen, white_pen, iteration, Cesaro[3], alpha);
        }

        public PointF SearchFirstPoint(PointF center, int board, float beta, ref float length, PictureBox pictureBox)
        {
            PointF fake_center = center;
            if (center.X >= pictureBox.Width / 2)
                fake_center.X = pictureBox.Width - center.X;
            if (center.Y >= pictureBox.Height / 2)
                fake_center.Y = pictureBox.Height - center.Y;

            length = 2 * (fake_center.X - board);
            float x = (float)(length / (2 * (1 + Math.Cos(beta))));
            float height = (float)(x * Math.Sin(beta));
            if (height > (fake_center.Y - 20))
            {
                height = (fake_center.Y - 20);
                x = (float)(height / Math.Sin(beta));
                length = (float)(2 * x * (1 + Math.Cos(beta)));
            }
            return new PointF(center.X - length / 2, center.Y);
        }

        public PointF SearchNewPoint(PointF p, float w, float alpha)
        {
            p.X = (float)(p.X + w * Math.Cos(alpha));
            p.Y = (float)(p.Y + w * Math.Sin(alpha));
            return p;
        }

        public float SearchDistance(float length, float beta)
        {
            return (float)(length / (2 * (1 + Math.Cos(beta))));
        }

        private void btn_nextIteration_Click(object sender, EventArgs e)
        {
            if ((countIterations_txt.Text == "") || (X_txt.Text == "") || (Y_txt.Text == ""))
                MessageBox.Show("Please fill in all fields");
            else
            {
                Graphics.FromImage(image).Clear(Color.White);
                pictureBox1.Image = image;

                Pen black_pen = new Pen(Color.Black, 1);
                Pen white_pen = new Pen(Color.White, 1);

                countIterations_txt.Text = Convert.ToString(++iteration);
                PointF first_point = SearchFirstPoint(Center, board, beta, ref length, pictureBox1);
                Build(length, black_pen, white_pen, iteration, first_point, alpha);

                pictureBox1.Image = image;
                label5.Text = "Fractal Cesaro line, step " + iteration;
            }
        }

        private void btn_previousIteration_Click(object sender, EventArgs e)
        {
                if ((countIterations_txt.Text == "") || (X_txt.Text == "") || (Y_txt.Text == ""))
                    MessageBox.Show("Please fill in all fields");
                else if (iteration > 1) 
                {
                    Graphics.FromImage(image).Clear(Color.White);
                    pictureBox1.Image = image;

                    Pen black_pen = new Pen(Color.Black, 1);
                    Pen white_pen = new Pen(Color.White, 1);

                    countIterations_txt.Text = Convert.ToString(--iteration); 
                    PointF first_point = SearchFirstPoint(Center, board, beta, ref length, pictureBox1);
                    Build(length, black_pen, white_pen, iteration, first_point, alpha);

                    pictureBox1.Image = image;
                    label5.Text = "Fractal Cesaro line, step " + iteration;
                }
                else
                {
                    MessageBox.Show("Iterations count cannot be less than 1");
                } 

        }


        private double MapToRange(int value, int fromLow, int fromHigh, double toLow, double toHigh)
        {
            return toLow + (toHigh - toLow) * ((double)value - fromLow) / (fromHigh - fromLow);
        }

        private void createFractal_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(maxIterations_txt.Text, out maxIterations))
            {
                MessageBox.Show("Invalid input for Max Iterations.");
                return;
            }

            if (!double.TryParse(min_X_txt.Text, out MinX))
            {
                MessageBox.Show("Invalid input for Min X.");
                return;
            }

            if (!double.TryParse(max_X_txt.Text, out MaxX))
            {
                MessageBox.Show("Invalid input for Max X.");
                return;
            }

            if (!double.TryParse(min_Y_txt.Text, out MinY))
            {
                MessageBox.Show("Invalid input for Min Y.");
                return;
            }

            if (!double.TryParse(max_Y_txt.Text, out MaxY))
            {
                MessageBox.Show("Invalid input for Max Y.");
                return;
            }

            Bitmap bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            for (int pixelY = 0; pixelY < pictureBox2.Height; pixelY++)
            {
                double im = MapToRange(pixelY, 0, pictureBox2.Height, MinY, MaxY);

                for (int pixelX = 0; pixelX < pictureBox2.Width; pixelX++)
                {
                    double re = MapToRange(pixelX, 0, pictureBox2.Width, MinX, MaxX);

                    int iteration = BuildAlgebraicFractal(re, im);

                    Color color = CalculateColor(iteration, maxIterations);
                    bitmap.SetPixel(pixelX, pixelY, color);
                }
            }

            pictureBox2.Image = bitmap;
        }

        private int BuildAlgebraicFractal(double re, double im)
        {
            double x = 0;
            double y = 0;
            int iteration = 0;

            while (x * x + y * y <= 4 && iteration < maxIterations && x <= MaxX && y <= MaxY)
            {
                double xTemp = x * Math.Cos(x) - y * Math.Sin(y) + re;
                y = x * Math.Sin(y) + y * Math.Cos(x) + im;
                x = xTemp;
                iteration++;
            }

            return iteration;
        }

        private Color CalculateColor(int iterations, int maxIterations)
        {
            if (iterations == maxIterations)
            {
                return FractalColor; 
            }
            else
            {
                double progress = (double)iterations / maxIterations;
                int red = (int)(FractalColor.R + (GradientColor.R - FractalColor.R) * progress);
                int green = (int)(FractalColor.G + (GradientColor.G - FractalColor.G) * progress);
                int blue = (int)(FractalColor.B + (GradientColor.B - FractalColor.B) * progress);
                return Color.FromArgb(red, green, blue); 
            }
        }

        private void ColorPicker_btn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                GradientColor = colorDialog.Color;
            }
        }
        private void SaveFractalImage(Bitmap bitmap)
        {
            try
            {
                string directoryPath = @"D:\Computer graphics\lab3_CG\Fractal Gallery"; 

                
                string fileName = "fractal_image_" + Guid.NewGuid().ToString("N") + ".png";
                string filePath = Path.Combine(directoryPath, fileName);

                bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Fractal image saved successfully.");

                AddImageToGalleryListView(directoryPath, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving fractal image: " + ex.Message);
            }
        }

        private void btn_saveFractal_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFractalImage((Bitmap)pictureBox1.Image);
            }
            else
            {
                MessageBox.Show("No fractal image to save.");
            }
        }

        private void btn_saveFractal2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                SaveFractalImage((Bitmap)pictureBox2.Image);
            }
            else
            {
                MessageBox.Show("No fractal image to save.");
            }
        }


        private void AddImageToGalleryListView(string directoryPath, string fileName)
        {
            bool isExisting = false;
            foreach (ListViewItem item in listViewGallery.Items)
            {
                if (item.Text == fileName)
                {
                    isExisting = true;
                    break;
                }
            }

            if (!isExisting)
            {
                
                ListViewItem item = new ListViewItem();
                item.ImageKey = fileName; 
                item.Text = fileName; 

                listViewGallery.Items.Add(item);

                ImageList largeImageList = listViewGallery.LargeImageList;
                if (largeImageList == null)
                {
                    largeImageList = new ImageList();
                    largeImageList.ImageSize = new Size(200, 200);
                    listViewGallery.LargeImageList = largeImageList;
                }

                largeImageList.Images.Add(fileName, Image.FromFile(Path.Combine(directoryPath, fileName))); 

                item.ImageKey = fileName;
            }
        }

    }
}
