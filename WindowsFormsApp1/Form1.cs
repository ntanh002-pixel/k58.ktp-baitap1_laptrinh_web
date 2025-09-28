using System;
using System.Drawing;
using System.Windows.Forms;
using DolphinLib;

namespace WindowsFormsApp1   // nhớ trùng namespace project
{
    public partial class Form1 : Form
    {
        private Dolphin dolphin;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();  // ← VS tự sinh ra khi bạn add Form chuẩn
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
            this.Text = "Cá heo bám theo con trỏ";

            dolphin = new Dolphin(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            dolphin.Speed = 6f;

            timer = new Timer();
            timer.Interval = 16;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point screen = Cursor.Position;
            Point client = this.PointToClient(screen);
            client.X = Math.Max(0, Math.Min(client.X, this.ClientSize.Width));
            client.Y = Math.Max(0, Math.Min(client.Y, this.ClientSize.Height));

            dolphin.Update(new PointF(client.X, client.Y));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.Clear(Color.LightCyan);

            Point screen = Cursor.Position;
            Point client = this.PointToClient(screen);
            g.FillEllipse(Brushes.OrangeRed, client.X - 6, client.Y - 6, 12, 12);

            g.FillEllipse(Brushes.SteelBlue, dolphin.X - 40, dolphin.Y - 20, 80, 40);
            g.DrawEllipse(Pens.DodgerBlue, dolphin.X - 40, dolphin.Y - 20, 80, 40);
        }
    }
}
