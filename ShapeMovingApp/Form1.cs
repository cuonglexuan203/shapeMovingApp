using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeMovingApp
{
    public partial class Form1 : Form
    {
        SolidBrush brush;
        Color color = Color.Blue;
        Point point;
        int step = 5;
        int size = 50;
        bool isForward = true;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(color);
            point = new Point(100, 100);
            this.TimerShape.Interval = 200;
            this.TimerShape.Start();

        }

        private void PnlMainDrawing_Paint(object sender, PaintEventArgs e)
        {
            brush.Color = color;
            e.Graphics.FillEllipse(brush, point.X, point.Y, size, size);
            if (this.point.X + size >= this.PnlMainDrawing.Width)
            {
                isForward = false;
            }
            if(this.point.X <= 0)
            {
                isForward = true;
            }
            this.PnlMainDrawing.Focus();
        }

        private void TimerShape_Tick(object sender, EventArgs e)
        {
            if (isForward)
            {
                TimerShape_Forward(step);
            }
            else
            {
                TimerShape_Backward(step);
            }
            this.PnlMainDrawing.Refresh();

        }
        private void TimerShape_Forward(int offset)
        {
            point.X += offset;
        }
        private void TimerShape_Backward(int offset)
        {
            point.X -= offset;
        }

        private void PnlMainDrawing_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    {
                        this.point.Y -= 5;
                        break;
                    }
                case Keys.Down:
                    {
                        this.point.Y += 5;
                        break;
                    }
                case Keys.Left:
                    {
                        this.point.X -= 5;
                        isForward = false;
                        break;
                    }
                case Keys.Right:
                    {
                        this.point.X += 5;
                        isForward = true;
                        break;
                    }
                case Keys.L:
                    {
                        this.size = 100;
                        break;
                    }
                case Keys.S:
                    {
                        this.size = 50;
                        break;
                    }
                case Keys.C:
                    {
                        this.color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0,255));
                        break;
                    }
            }

            this.PnlMainDrawing.Refresh();
        }
    }
}
