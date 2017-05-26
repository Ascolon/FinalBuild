using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace FinalBuild
{
    public partial class vSpeed : Form
    {
        Graphics gr;
        double x = 0;
        double y = 700;
        double vx = 3;
        double vy = 3;
        double resist = 0.001;
        const double g = 9.8;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public vSpeed()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
           // MessageBox.Show( Screen.PrimaryScreen.Bounds.Height +" ");
        }
        /// <summary>
        /// Регион с методами программы
        /// </summary>
        #region
        void Draw()
        {
            gr.FillEllipse(Brushes.Black, (float)x, (float)y, 10, 10);
        }
        private void movie_Tick(object sender, EventArgs e)
        {
            Step(0.1);
            Draw();
        }
        void Step(double dt)
        {
            if (air.Checked)
            {
                vy += (g - Math.Sign(vy) * resist * Math.Pow(vy, 2)) * dt;
                vx = vx - Math.Sign(vx) * resist * Math.Pow(vx, 2) * dt;
            }
            else
            {
                vy += g * dt;
            }

            x += vx * dt;
            y += vy * dt;
            if (x < 0)
            {
                x = 0;
                vx = -vx;
            }
            if (x > this.ClientSize.Width - 10)
            {
                x = this.ClientSize.Width - 10;
                vx = -vx;
            }
            if (y < 0)
            {
                y = 0;
                vy = -vy;
            }
            if (y > this.ClientSize.Height - 10)
            {
                MakeScreen();
                y = this.ClientSize.Height - 10;
                vy = -vy;
            }
        }

        void Vector(int X,int Y, int speed)
        {
            double dx, dy, d, fi; //vTotal;
            dx = X - this.x;
            dy = Y - this.y;
            d = Math.Sqrt(dx * dx + dy * dy);
            fi = Math.Atan2(dy, dx);
            //vTotal = 10;
            vx = speed * Math.Cos(fi);
            vy = speed * Math.Sin(fi);
        }
        private void SelectVector(object sender, MouseEventArgs e)
        {
            if (movie.Enabled == false)
            {
                movie.Start();
            }
            else
            {
                gr.Clear(Color.White);
            }
            x = 0;
            y = 740;
            Vector(e.X, e.Y,(int)speedV.Value);
            Draw();
        }
        #endregion

        private void MianForm_MouseMove(object sender, MouseEventArgs e)
        {
            Angle.Text = SetDegre(e.X, e.Y);
        }

        string SetDegre(int x, int y)
        {
            double Y = 749 - y;
            double angle = Math.Atan2(Y, x) * (180 / Math.PI);
            return Math.Round(angle,2).ToString();
        }

        void SetInfo()
        {
            using (InfoContext db = new InfoContext())
            {
                // создаем два объекта User
                Info info = new Info
                {
                    TimeDrop = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString(),
                    Speed = (double)speedV.Value,
                    Height = 170,
                    Length = 450,
                    FlyTime = 45,
                    ScreenShot = MakeScreen()
                };
                db.Info.Add(info);
                db.SaveChanges();
            }
        }

        string MakeScreen()
        {
            movie.Stop();
            string path = null;
            Graphics graph = null;
            var bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            graph = Graphics.FromImage(bmp);graph.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            path = "ScreenShot/screenshot" + DateTime.Now.ToShortDateString().Replace(".", "-") + ".jpg";
            bmp.Save(path);
            return path;
        }
    }
}
