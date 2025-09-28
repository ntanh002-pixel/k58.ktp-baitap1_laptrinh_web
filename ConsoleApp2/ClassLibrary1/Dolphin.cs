using System;
using System.Drawing;

namespace DolphinLib
{
    public class Dolphin
    {
        private float x, y, speed;

        public Dolphin(float startX, float startY)
        {
            x = startX; y = startY; speed = 5.0f;
        }

        public float X { get { return x; } set { x = value; } }
        public float Y { get { return y; } set { y = value; } }
        public float Speed { get { return speed; } set { speed = value; } }

        public void Update(PointF target)
        {
            float dx = target.X - x;
            float dy = target.Y - y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            if (dist > 0.5f)
            {
                float vx = dx / dist;
                float vy = dy / dist;
                float move = Math.Min(speed, dist);
                x += vx * move;
                y += vy * move;
            }
        }
    }
}
