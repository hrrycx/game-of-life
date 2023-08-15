using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace game_of_life { 

    public partial class Form1 : Form
    {
        public bool[,] grid = initgrid();

        Bitmap bitmap = new Bitmap(100, 100);
        static bool[,] initgrid()
        {

            bool[,] grid = new bool[100, 100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    grid[i, j] = false;
                }
            }
            return grid;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (rnd.Next(0, 10) == 0)
                    {
                        grid[i, j] = true;
                    }
                }
            }


            showgrid();
        }
        void showgrid()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (grid[i, j])
                    {

                        bitmap.SetPixel(i, j, Color.White);

                    }
                    else
                    {

                        bitmap.SetPixel(i, j, Color.Black);
                    }
                }
            }
            Bitmap bitmap2 = ResizeImage(bitmap, new Size(800, 800));
            display.Image = bitmap2;
        }
        public static Bitmap ResizeImage(Bitmap imgToResize, Size size)
        {
            Bitmap b = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            }
            return b;
        }
        void update()
        {
            bool[,] grid2 = new bool[100, 100];
            int count;
            for (int i = 0; i < 99; i++)
            {
                for (int j = 0; j < 99; j++)
                {
                    count = countnbors(i, j);

                    if (count < 2 || count > 3)
                    {
                        grid2[i, j] = false;
                    }
                    if (count == 2)
                    {
                        grid2[i, j] = grid[i, j];
                    }
                    if (count == 3)
                    {
                        grid2[i, j] = true;
                    }
                }
            }
            grid = grid2;
            showgrid();
        }
        int countnbors(int i, int j)
        {
            int count = 0;
            int count2 = 0;
            if (i == 12 && j == 10)
            {
                count = 0;
            }
            if (grid[i, j])
            {
                count = count - 1;
            }
            for (int m = -1; m <= 1; m++)
            {
                for (int n = -1; n <= 1; n++)
                {
                    count2 += 1;
                    if (getcell(i + m, j + n))
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
        bool getcell(int i, int j)
        {
            if (i < 0 || j < 0 || i > 99 || j > 99)
            {
                return false;
            }
            if (grid[i, j])
            {
                return true;
            }
            return false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Bitmap bitmaptemp = new Bitmap(800, 800);

            for (int i = 0; i < 800; i++)
            {
                for (int j = 0; j < 800; j++)
                {
                    bitmaptemp.SetPixel(i, j, Color.Black);
                }
            }
            display.Image = bitmaptemp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            update();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            grid = initgrid();
            showgrid();
        }

        private void speed_Click(object sender, EventArgs e)
        {
            if (timer1.Interval / 2 > 0)
            {
                timer1.Interval = timer1.Interval / 2;

            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) { return; }

            var coordinates = display.PointToClient(Cursor.Position);
            grid[(coordinates.X) / 8, (coordinates.Y) / 8] = !grid[(coordinates.X) / 8, (coordinates.Y) / 8];
            showgrid();
        }
        // DRAG 
    }
}