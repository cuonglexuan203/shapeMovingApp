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
        bool isVertical = false;
        bool isUpward = false;
        bool isHorizontal = true;
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
            if (isHorizontal)
            {
                if (this.point.X + size >= this.PnlMainDrawing.Width)
                {
                    isForward = false;
                }
                if (this.point.X <= 0)
                {
                    isForward = true;
                }
            }
            if (isVertical)
            {
                if (this.point.Y + size >= this.PnlMainDrawing.Height)
                {
                    isUpward = true;
                }
                if (this.point.Y <= 0)
                {
                    isUpward = false;
                }
            }
            this.PnlMainDrawing.Focus();
        }

        private void TimerShape_Tick(object sender, EventArgs e)
        {
            if (isHorizontal)
            {
                if (isForward)
                {
                    TimerShape_Forward(step);
                }
                else
                {
                    TimerShape_Backward(step);
                }
            }
            if (isVertical)
            {
                if (isUpward)
                {
                    TimerShape_Upward(step);
                }
                else
                {
                    TimerShape_DownWard(step);
                }
            }
            this.PnlMainDrawing.Refresh();

        }
        private void TimerShape_Upward(int offset)
        {
            point.Y -= offset;
        }
        private void TimerShape_DownWard(int offset)
        {
            point.Y += offset;
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
                        isVertical = true ;
                        isUpward = true;
                        isHorizontal = false;

                        this.point.Y -= 5;
                        break;
                    }
                case Keys.Down:
                    {
                        isVertical = true;
                        isUpward = false;
                        isHorizontal = false;
                        this.point.Y += 5;
                        break;
                    }
                case Keys.Left:
                    {
                        isVertical = false;
                        isForward = false;
                        isHorizontal = true;
                        this.point.X -= 5;
                        isForward = false;
                        break;
                    }
                case Keys.Right:
                    {
                        isVertical = false;
                        isForward = true;
                        isHorizontal = true;
                        this.point.X += 5;
                        isForward = true;
                        break;
                    }
                case Keys.L:
                    {
                        if(size >= 200)
                        {
                            break;
                        }
                        this.size  += 10;
                        break;
                    }
                case Keys.S:
                    {
                        if(size <= 10)
                        {
                            
                            break;
                        }
                        this.size -= 10;
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
