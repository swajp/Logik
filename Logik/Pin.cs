using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace Logik
{
    class Pin
    {
        private Region region;
        public PinState State { get; set; }
        public Region Region { get  => region; }

        public Pin()
        {
            State = PinState.Empty;
        }

        public void Draw(Graphics graphics, Pen pen, PointF pointF, int size)
        {
     
            Brush brush = new SolidBrush(GetColor());
            graphics.FillEllipse(brush, pointF.X, pointF.Y, size, size);
            graphics.DrawEllipse(pen, pointF.X, pointF.Y, size, size);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(pointF.X, pointF.Y, size, size);
            region = new Region(graphicsPath);

        }

        private Color GetColor()
        {
            switch (State)
            {
                case PinState.Color1:
                    return Color.Red;
                case PinState.Color2:
                    return Color.Blue;
                case PinState.Color3:
                    return Color.Green;
                case PinState.Color4:
                    return Color.Yellow;
                case PinState.Color5:
                    return Color.Orange;
                case PinState.Color6:
                    return Color.Purple;
                default:
                    return Color.White;

            }
        }

        public enum PinState
        {
            Empty,
            Color1,
            Color2,
            Color3,
            Color4,
            Color5,
            Color6
        }
    }
}
