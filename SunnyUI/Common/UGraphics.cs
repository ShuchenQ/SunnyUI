﻿/******************************************************************************
 * SunnyUI 开源控件库、工具类库、扩展类库、多页面开发框架。
 * CopyRight (C) 2012-2021 ShenYongHua(沈永华).
 * QQ群：56829229 QQ：17612584 EMail：SunnyUI@QQ.Com
 *
 * Blog:   https://www.cnblogs.com/yhuse
 * Gitee:  https://gitee.com/yhuse/SunnyUI
 * GitHub: https://github.com/yhuse/SunnyUI
 *
 * SunnyUI.dll can be used for free under the GPL-3.0 license.
 * If you use this code, please keep this note.
 * 如果您使用此代码，请保留此说明。
 ******************************************************************************
 * 文件名称: UGraphics.cs
 * 文件说明: GDI扩展类
 * 当前版本: V3.0
 * 创建日期: 2020-08-20
 *
 * 2021-08-20: V3.0.6 整理了一些GDI绘图的常用方法扩展 
******************************************************************************/

using Sunny.UI.Static;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Sunny.UI
{
    public static class GraphicsEx
    {
        public static void DrawString(this Graphics g, string text, Font font, Color color, RectangleF rect, StringFormat format)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(text, font, br, rect, format);
            }
        }

        public static void DrawString(this Graphics g, string text, Font font, Color color, RectangleF rect)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(text, font, br, rect);
            }
        }

        public static void DrawString(this Graphics g, string text, Font font, Color color, Rectangle rect, StringFormat format)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(text, font, br, rect, format);
            }
        }

        public static void DrawString(this Graphics g, string text, Font font, Color color, Rectangle rect)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(text, font, br, rect);
            }
        }

        public static void DrawString(this Graphics g, string text, Font font, Color color, float x, float y)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(text, font, br, x, y);
            }
        }

        public static void DrawString(this Graphics g, string text, Font font, Color color, Point pt)
        => g.DrawString(text, font, color, pt.X, pt.Y);

        public static void DrawString(this Graphics g, string text, Font font, Color color, PointF pt)
        => g.DrawString(text, font, color, pt.X, pt.Y);


        public static void DrawString(this Graphics g, string text, Font font, Color color, float x, float y, StringFormat format)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(text, font, br, x, y, format);
            }
        }

        public static void DrawString(this Graphics g, string text, Font font, Color color, PointF pt, StringFormat format)
        => g.DrawString(text, font, color, pt.X, pt.Y, format);

        public static void DrawString(this Graphics g, string text, Font font, Color color, Point pt, StringFormat format)
        => g.DrawString(text, font, color, pt.X, pt.Y, format);


        public static void DrawLines(this Graphics g, Color color, Point[] points, bool smooth = false, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawLines(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawLines(this Graphics g, Color color, PointF[] points, bool smooth = false, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawLines(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawCurve(this Graphics g, Color color, Point[] points, bool smooth = false, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawCurve(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawCurve(this Graphics g, Color color, PointF[] points, bool smooth = false, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawCurve(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawLine(this Graphics g, Color color, int x1, int y1, int x2, int y2, bool smooth = false, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawLine(pen, x1, y1, x2, y2);
                g.Smooth(false);
            }
        }

        public static void DrawLine(this Graphics g, Color color, Point pt1, Point pt2, bool smooth = false, float penWidth = 1)
        => g.DrawLine(color, pt1.X, pt1.Y, pt2.X, pt2.Y, smooth, penWidth);

        public static void DrawLine(this Graphics g, Color color, float x1, float y1, float x2, float y2, bool smooth = false, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawLine(pen, x1, y1, x2, y2);
                g.Smooth(false);
            }
        }

        public static void DrawLine(this Graphics g, Color color, PointF pt1, PointF pt2, bool smooth = false, float penWidth = 1)
        => g.DrawLine(color, pt1.X, pt1.Y, pt2.X, pt2.Y, smooth, penWidth);

        public static void DrawArc(this Graphics g, Color color, int x, int y, int width, int height, int startAngle, int sweepAngle, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
                g.Smooth(false);
            }
        }

        public static void DrawArc(this Graphics g, Color color, float x, float y, float width, float height, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawArc(pen, x, y, width, height, startAngle, sweepAngle);
                g.Smooth(false);
            }
        }

        public static void DrawArc(this Graphics g, Color color, Rectangle rect, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
         => g.DrawArc(color, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle, smooth, penWidth);


        public static void DrawArc(this Graphics g, Color color, RectangleF rect, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
         => g.DrawArc(color, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle, smooth, penWidth);


        public static void DrawBezier(this Graphics g, Color color, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawBezier(pen, x1, y1, x2, y2, x3, y3, x4, y4);
                g.Smooth(false);
            }
        }

        public static void DrawBezier(this Graphics g, Color color, PointF pt1, PointF pt2, PointF pt3, PointF pt4, bool smooth = true, float penWidth = 1)
            => g.DrawBezier(color, pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y, pt4.X, pt4.Y, smooth, penWidth);

        public static void DrawBezier(this Graphics g, Color color, Point pt1, Point pt2, Point pt3, Point pt4, bool smooth = true, float penWidth = 1)
          => g.DrawBezier(color, pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y, pt4.X, pt4.Y, smooth, penWidth);

        public static void DrawBeziers(this Graphics g, Color color, PointF[] points, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawBeziers(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawBeziers(this Graphics g, Color color, Point[] points, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawBeziers(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawClosedCurve(this Graphics g, Color color, Point[] points, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawClosedCurve(pen, points);
                g.Smooth(false);
            }
        }

        public static void DrawClosedCurve(this Graphics g, Color color, Point[] points, float tension, FillMode fillmode, bool smooth = true, float penWidth = 1)
        {
            using (Pen pen = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawClosedCurve(pen, points, tension, fillmode);
                g.Smooth(false);
            }
        }

        public static void FillClosedCurve(this Graphics g, Color color, Point[] points, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillClosedCurve(sb, points);
                g.Smooth(false);
            }
        }

        public static void FillClosedCurve(this Graphics g, Color color, Point[] points, FillMode fillmode, float tension, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillClosedCurve(sb, points, fillmode, tension);
                g.Smooth(false);
            }
        }

        public static void FillPath(this Graphics g, Color color, GraphicsPath path, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillPath(sb, path);
                g.Smooth(false);
            }
        }

        public static void DrawPath(this Graphics g, Color color, GraphicsPath path, bool smooth = true, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawPath(pn, path);
                g.Smooth(false);
            }
        }

        public static void FillPolygon(this Graphics g, Color color, PointF[] points, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillPolygon(sb, points);
                g.Smooth(false);
            }
        }

        public static void FillPolygon(this Graphics g, Color color, PointF[] points, FillMode fillMode, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillPolygon(sb, points, fillMode);
                g.Smooth(false);
            }
        }

        public static void FillPolygon(this Graphics g, Color color, Point[] points, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillPolygon(sb, points);
                g.Smooth(false);
            }
        }

        public static void FillPolygon(this Graphics g, Color color, Point[] points, FillMode fillMode, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillPolygon(sb, points, fillMode);
                g.Smooth(false);
            }
        }

        public static void DrawPolygon(this Graphics g, Color color, PointF[] points, bool smooth = true, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawPolygon(pn, points);
                g.Smooth(false);
            }
        }

        public static void DrawPolygon(this Graphics g, Color color, Point[] points, bool smooth = true, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawPolygon(pn, points);
                g.Smooth(false);
            }
        }

        public static void FillEllipse(this Graphics g, Color color, Rectangle rect, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillEllipse(sb, rect);
                g.Smooth(false);
            }
        }

        public static void DrawEllipse(this Graphics g, Color color, Rectangle rect, bool smooth = true, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawEllipse(pn, rect);
                g.Smooth(false);
            }
        }

        public static void FillEllipse(this Graphics g, Color color, RectangleF rect, bool smooth = true)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillEllipse(sb, rect);
                g.Smooth(false);
            }
        }

        public static void DrawEllipse(this Graphics g, Color color, RectangleF rect, bool smooth = true, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawEllipse(pn, rect);
                g.Smooth(false);
            }
        }

        public static void FillEllipse(this Graphics g, Color color, int left, int top, int width, int height, bool smooth = true)
         => g.FillEllipse(color, new Rectangle(left, top, width, height), smooth);

        public static void DrawEllipse(this Graphics g, Color color, int left, int top, int width, int height, bool smooth = true, float penWidth = 1)
         => g.DrawEllipse(color, new Rectangle(left, top, width, height), smooth, penWidth);


        public static void FillEllipse(this Graphics g, Color color, float left, float top, float width, float height, bool smooth = true)
         => g.FillEllipse(color, new RectangleF(left, top, width, height), smooth);


        public static void DrawEllipse(this Graphics g, Color color, float left, float top, float width, float height, bool smooth = true, float penWidth = 1)
        => g.DrawEllipse(color, new RectangleF(left, top, width, height), smooth, penWidth);

        public static void FillRectangle(this Graphics g, Color color, Rectangle rect, bool smooth = false)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillRectangle(sb, rect);
                g.Smooth(false);
            }
        }

        public static void DrawRectangle(this Graphics g, Color color, Rectangle rect, bool smooth = false, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawRectangle(pn, rect);
                g.Smooth(false);
            }
        }

        public static void FillRectangle(this Graphics g, Color color, RectangleF rect, bool smooth = false)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillRectangle(sb, rect);
                g.Smooth(false);
            }
        }

        public static void DrawRectangle(this Graphics g, Color color, RectangleF rect, bool smooth = false, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawRectangle(pn, rect.X, rect.Y, rect.Width, rect.Height);
                g.Smooth(false);
            }
        }

        public static void FillRectangle(this Graphics g, Color color, int left, int top, int width, int height, bool smooth = false)
        => g.FillRectangle(color, new Rectangle(left, top, width, height), smooth);

        public static void DrawRectangle(this Graphics g, Color color, int left, int top, int width, int height, bool smooth = false, float penWidth = 1)
        => g.DrawRectangle(color, new Rectangle(left, top, width, height), smooth, penWidth);


        public static void FillRectangle(this Graphics g, Color color, float left, float top, float width, float height, bool smooth = false)
        => g.FillRectangle(color, new RectangleF(left, top, width, height), smooth);


        public static void DrawRectangle(this Graphics g, Color color, float left, float top, float width, float height, bool smooth = false, float penWidth = 1)
        => g.DrawRectangle(color, new RectangleF(left, top, width, height), smooth, penWidth);


        public static void FillRectangles(this Graphics g, Color color, Rectangle[] rects, bool smooth = false)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillRectangles(sb, rects);
                g.Smooth(false);
            }
        }

        public static void FillRectangles(this Graphics g, Color color, RectangleF[] rects, bool smooth = false)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillRectangles(sb, rects);
                g.Smooth(false);
            }
        }

        public static void FillRegion(this Graphics g, Color color, Region region, bool smooth = false)
        {
            using (SolidBrush sb = color.Brush())
            {
                g.Smooth(smooth);
                g.FillRegion(sb, region);
                g.Smooth(false);
            }
        }


        public static void DrawRectangles(this Graphics g, Color color, Rectangle[] rects, bool smooth = false, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawRectangles(pn, rects);
                g.Smooth(false);
            }
        }

        public static void DrawRectangles(this Graphics g, Color color, RectangleF[] rects, bool smooth = false, float penWidth = 1)
        {
            using (Pen pn = color.Pen(penWidth))
            {
                g.Smooth(smooth);
                g.DrawRectangles(pn, rects);
                g.Smooth(false);
            }
        }

        public static void DrawRoundRectangle(this Graphics g, Pen pen, Rectangle rect, int cornerRadius, bool smooth = true)
        {
            g.Smooth(smooth);
            if (cornerRadius > 0)
            {
                using (GraphicsPath path = rect.CreateRoundedRectanglePath(cornerRadius))
                {
                    g.DrawPath(pen, path);
                }
            }
            else
            {
                g.DrawRectangle(pen, rect);
            }

            g.Smooth(false);
        }

        public static void FillRoundRectangle(this Graphics g, Brush brush, Rectangle rect, int cornerRadius, bool smooth = true)
        {
            g.Smooth(smooth);
            if (cornerRadius > 0)
            {
                using (GraphicsPath path = rect.CreateRoundedRectanglePath(cornerRadius))
                {
                    g.FillPath(brush, path);
                }
            }
            else
            {
                g.FillRectangle(brush, rect);
            }

            g.Smooth(false);
        }

        public static void DrawRoundRectangle(this Graphics g, Pen pen, int left, int top, int width, int height, int cornerRadius, bool smooth = true)
        {
            g.DrawRoundRectangle(pen, new Rectangle(left, top, width, height), cornerRadius, smooth);
        }

        public static void FillRoundRectangle(this Graphics g, Brush brush, int left, int top, int width, int height, int cornerRadius, bool smooth = true)
        {
            g.FillRoundRectangle(brush, new Rectangle(left, top, width, height), cornerRadius, smooth);
        }

        public static void DrawRoundRectangle(this Graphics g, Color color, Rectangle rect, int cornerRadius, bool smooth = true, float penWidth = 1)
        {
            if (cornerRadius > 0)
            {
                using (GraphicsPath path = rect.CreateRoundedRectanglePath(cornerRadius))
                {
                    g.DrawPath(color, path, smooth, penWidth);
                }
            }
            else
            {
                g.DrawRectangle(color, rect, smooth, penWidth);
            }
        }

        public static void FillRoundRectangle(this Graphics g, Color color, Rectangle rect, int cornerRadius, bool smooth = true)
        {
            if (cornerRadius > 0)
            {
                using (GraphicsPath path = rect.CreateRoundedRectanglePath(cornerRadius))
                {
                    g.FillPath(color, path, smooth);
                }
            }
            else
            {
                g.FillRectangle(color, rect, smooth);
            }
        }

        public static void DrawRoundRectangle(this Graphics g, Color color, int left, int top, int width, int height, int cornerRadius, bool smooth = true, float penWidth = 1)
        => g.DrawRoundRectangle(color, new Rectangle(left, top, width, height), cornerRadius, smooth, penWidth);

        public static void FillRoundRectangle(this Graphics g, Color color, int left, int top, int width, int height, int cornerRadius, bool smooth = true)
        => g.FillRoundRectangle(color, new Rectangle(left, top, width, height), cornerRadius, smooth);

        public static void DrawCross(this Graphics g, Color color, Point center, int crossSize = 3, float penWidth = 1)
        {
            g.DrawLine(color, center.X - crossSize, center.Y, center.X + crossSize, center.Y, false, penWidth);
            g.DrawLine(color, center.X, center.Y - crossSize, center.X, center.Y + crossSize, false, penWidth);
        }

        public static void DrawFan(this Graphics g, Color color, Point center, float d1, float d2, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        {
            if (d1.Equals(0))
            {
                g.DrawPie(color, center.X - d2, center.Y - d2, d2 * 2, d2 * 2, startAngle, sweepAngle, smooth, penWidth);
            }
            else
            {
                GraphicsPath path = g.CreateFanPath(center, d1, d2, startAngle, sweepAngle);
                g.DrawPath(color, path, smooth, penWidth);
                path.Dispose();
            }
        }

        public static void DrawFan(this Graphics g, Color color, PointF center, float d1, float d2, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        {
            if (d1.Equals(0))
            {
                g.DrawPie(color, center.X - d2, center.Y - d2, d2 * 2, d2 * 2, startAngle, sweepAngle, smooth, penWidth);
            }
            else
            {
                GraphicsPath path = g.CreateFanPath(center, d1, d2, startAngle, sweepAngle);
                g.DrawPath(color, path, smooth, penWidth);
                path.Dispose();
            }
        }

        public static void FillFan(this Graphics g, Color color, Point center, float d1, float d2, float startAngle, float sweepAngle, bool smooth = true)
        {
            if (d1.Equals(0))
            {
                g.FillPie(color, center.X - d2, center.Y - d2, d2 * 2, d2 * 2, startAngle, sweepAngle, smooth);
            }
            else
            {
                GraphicsPath path = g.CreateFanPath(center, d1, d2, startAngle, sweepAngle);
                g.FillPath(color, path, smooth);
                path.Dispose();
            }
        }

        public static void FillFan(this Graphics g, Color color, PointF center, float d1, float d2, float startAngle, float sweepAngle, bool smooth = true)
        {
            if (d1.Equals(0))
            {
                g.FillPie(color, center.X - d2, center.Y - d2, d2 * 2, d2 * 2, startAngle, sweepAngle, smooth);
            }
            else
            {
                GraphicsPath path = g.CreateFanPath(center, d1, d2, startAngle, sweepAngle);
                g.FillPath(color, path, smooth);
                path.Dispose();
            }
        }

        public static void FillPie(this Graphics g, Color color, int x, int y, int width, int height, float startAngle, float sweepAngle, bool smooth = true)
        {
            g.Smooth(smooth);
            using (Brush br = color.Brush())
            {
                g.FillPie(br, x, y, width, height, startAngle, sweepAngle);
            }

            g.Smooth(false);
        }

        public static void FillPie(this Graphics g, Color color, Rectangle rect, float startAngle, float sweepAngle, bool smooth = true)
        => g.FillPie(color, rect.Left, rect.Top, rect.Width, rect.Height, startAngle, sweepAngle, smooth);

        public static void FillPie(this Graphics g, Color color, float x, float y, float width, float height, float startAngle, float sweepAngle, bool smooth = true)
        {
            g.Smooth(smooth);
            using (Brush br = color.Brush())
            {
                g.FillPie(br, x, y, width, height, startAngle, sweepAngle);
            }

            g.Smooth(false);
        }

        public static void FillPie(this Graphics g, Color color, RectangleF rect, float startAngle, float sweepAngle, bool smooth = true)
        => g.FillPie(color, rect.Left, rect.Top, rect.Width, rect.Height, startAngle, sweepAngle, smooth);

        public static void DrawPoint(this Graphics g, Color color, int x, int y, float size)
        => g.FillEllipse(color, x - size / 2.0f, y - size / 2.0f, size, size);

        public static void DrawPoint(this Graphics g, Color color, float x, float y, float size)
        => g.FillEllipse(color, x - size / 2.0f, y - size / 2.0f, size, size);

        public static void DrawPoint(this Graphics g, Color color, Point point, float size)
        => g.DrawPoint(color, point.X, point.Y, size);

        public static void DrawPoint(this Graphics g, Color color, PointF point, float size)
        => g.DrawPoint(color, point.X, point.Y, size);

        public static void DrawPie(this Graphics g, Color color, Rectangle rect, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        => g.DrawPie(color, rect.Left, rect.Top, rect.Width, rect.Height, startAngle, sweepAngle, smooth, penWidth);

        public static void DrawPie(this Graphics g, Color color, float x, float y, float width, float height, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        {
            g.Smooth(smooth);
            using (Pen pen = color.Pen(penWidth))
            {
                g.DrawPie(pen, x, y, width, height, startAngle, sweepAngle);
            }

            g.Smooth(false);
        }

        public static void DrawPie(this Graphics g, Color color, RectangleF rect, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        => g.DrawPie(color, rect.Left, rect.Top, rect.Width, rect.Height, startAngle, sweepAngle, smooth, penWidth);

        public static void DrawPie(this Graphics g, Color color, int x, int y, int width, int height, float startAngle, float sweepAngle, bool smooth = true, float penWidth = 1)
        {
            g.Smooth(smooth);
            using (Pen pen = color.Pen(penWidth))
            {
                g.DrawPie(pen, x, y, width, height, startAngle, sweepAngle);
            }

            g.Smooth(false);
        }

        /// <summary>
        /// 九宫切图背景填充，#，http://st233.com/blog.php?id=24
        /// 例如按钮是图片分成九个区域 然后只需要将四角填充到目标区域 其余的拉伸就可以了
        /// </summary>
        /// <param name="g"></param>
        /// <param name="img"></param>
        /// <param name="rect"></param>
        /// <param name="angleSize"></param>
        public static void DrawImageWithNineCut(this Graphics g, Image img, Rectangle rect, int angleSize = 5)
        {
            //填充四个角
            g.DrawImage(img, new Rectangle(rect.X, rect.Y, angleSize, angleSize),
                new Rectangle(0, 0, angleSize, angleSize), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(rect.Right - angleSize, rect.Y, angleSize, angleSize),
                new Rectangle(img.Width - angleSize, 0, angleSize, angleSize), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(rect.X, rect.Bottom - angleSize, angleSize, angleSize),
                new Rectangle(0, img.Height - angleSize, angleSize, angleSize), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(rect.Right - angleSize, rect.Bottom - angleSize, angleSize, angleSize),
                new Rectangle(img.Width - angleSize, img.Height - angleSize, angleSize, angleSize), GraphicsUnit.Pixel);
            //四边
            g.DrawImage(img, new Rectangle(rect.X, rect.Y + angleSize, angleSize, rect.Height - angleSize * 2),
                new Rectangle(0, angleSize, angleSize, img.Height - angleSize * 2), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(rect.X + angleSize, rect.Y, rect.Width - angleSize * 2, angleSize),
                new Rectangle(angleSize, 0, img.Width - angleSize * 2, angleSize), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(rect.Right - angleSize, rect.Y + angleSize, angleSize, rect.Height - angleSize * 2),
                new Rectangle(img.Width - angleSize, angleSize, angleSize, img.Height - angleSize * 2), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(rect.X + angleSize, rect.Bottom - angleSize, rect.Width - angleSize * 2, angleSize),
                new Rectangle(angleSize, img.Height - angleSize, img.Width - angleSize * 2, angleSize), GraphicsUnit.Pixel);
            //中间
            g.DrawImage(img,
                new Rectangle(rect.X + angleSize, rect.Y + angleSize, rect.Width - angleSize * 2, rect.Height - angleSize * 2),
                new Rectangle(angleSize, angleSize, img.Width - angleSize * 2, img.Height - angleSize * 2), GraphicsUnit.Pixel);
        }

        public static void DrawImageWithNineCut(this Graphics g, Image img, int destWidth, int destHeight, int cutLeft, int cutRight, int cutTop, int cutBottom, int iZoom = 1)
        {
            iZoom = Math.Max(1, iZoom);

            //填充四个角
            g.DrawImage(img, new Rectangle(0, 0, cutLeft * iZoom, cutTop * iZoom),
                new Rectangle(0, 0, cutLeft, cutTop), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(destWidth - cutRight * iZoom, 0, cutRight * iZoom, cutTop * iZoom),
                new Rectangle(img.Width - cutRight, 0, cutRight, cutTop), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(0, destHeight - cutBottom * iZoom, cutLeft * iZoom, cutBottom * iZoom),
                new Rectangle(0, img.Height - cutBottom, cutLeft, cutBottom), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(destWidth - cutRight * iZoom, destHeight - cutBottom * iZoom, cutRight * iZoom, cutBottom * iZoom),
                new Rectangle(img.Width - cutRight, img.Height - cutBottom, cutRight, cutBottom), GraphicsUnit.Pixel);

            //四边
            g.DrawImage(img, new Rectangle(cutLeft * iZoom, 0, destWidth - (cutLeft + cutRight) * iZoom, cutTop * iZoom),
                new Rectangle(cutLeft, 0, img.Width - cutLeft - cutRight, cutTop), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(0, cutTop * iZoom, cutLeft * iZoom, destHeight - (cutTop + cutBottom) * iZoom),
                new Rectangle(0, cutTop, cutLeft, img.Height - cutTop - cutBottom), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(destWidth - cutRight * iZoom, cutTop * iZoom, cutRight * iZoom, destHeight - (cutTop + cutBottom) * iZoom),
                new Rectangle(img.Width - cutRight, cutTop, cutRight, img.Height - cutTop - cutBottom), GraphicsUnit.Pixel);
            g.DrawImage(img, new Rectangle(cutLeft * iZoom, destHeight - cutBottom * iZoom, destWidth - (cutLeft + cutRight) * iZoom, cutBottom * iZoom),
                new Rectangle(cutLeft, img.Height - cutBottom, img.Width - cutLeft - cutRight, cutBottom), GraphicsUnit.Pixel);

            //中间
            g.DrawImage(img, new Rectangle(cutLeft * iZoom, cutTop * iZoom, destWidth - (cutLeft + cutRight) * iZoom, destHeight - (cutTop + cutBottom) * iZoom),
               new Rectangle(cutLeft, cutTop, img.Width - cutLeft - cutRight, img.Height - cutTop - cutBottom), GraphicsUnit.Pixel);
        }

        public static void DrawString(this Graphics g, string str, Font font, Color color, Size size, Padding padding, ContentAlignment align)
        {
            SizeF sf = g.MeasureString(str, font);
            using (Brush br = color.Brush())
            {
                switch (align)
                {
                    case ContentAlignment.MiddleCenter:
                        g.DrawString(str, font, br, padding.Left + (size.Width - sf.Width - padding.Left - padding.Right) / 2.0f,
                            padding.Top + (size.Height - sf.Height - padding.Top - padding.Bottom) / 2.0f);
                        break;

                    case ContentAlignment.TopLeft:
                        g.DrawString(str, font, br, padding.Left, padding.Top);
                        break;

                    case ContentAlignment.TopCenter:
                        g.DrawString(str, font, br, padding.Left + (size.Width - sf.Width - padding.Left - padding.Right) / 2.0f, padding.Top);
                        break;

                    case ContentAlignment.TopRight:
                        g.DrawString(str, font, br, size.Width - sf.Width - padding.Right, padding.Top);
                        break;

                    case ContentAlignment.MiddleLeft:
                        g.DrawString(str, font, br, padding.Left, padding.Top + (size.Height - sf.Height - padding.Top - padding.Bottom) / 2.0f);
                        break;

                    case ContentAlignment.MiddleRight:
                        g.DrawString(str, font, br, size.Width - sf.Width - padding.Right, padding.Top + (size.Height - sf.Height - padding.Top - padding.Bottom) / 2.0f);
                        break;

                    case ContentAlignment.BottomLeft:
                        g.DrawString(str, font, br, padding.Left, size.Height - sf.Height - padding.Bottom);
                        break;

                    case ContentAlignment.BottomCenter:
                        g.DrawString(str, font, br, padding.Left + (size.Width - sf.Width - padding.Left - padding.Right) / 2.0f, size.Height - sf.Height - padding.Bottom);
                        break;

                    case ContentAlignment.BottomRight:
                        g.DrawString(str, font, br, size.Width - sf.Width - padding.Right, size.Height - sf.Height - padding.Bottom);
                        break;
                }
            }
        }

        public static void DrawString(this Graphics g, string s, Font font, Color color, RectangleF rect, StringFormat format, float angle)
        {
            using (Brush br = color.Brush())
            {
                g.DrawStringRotateAtCenter(s, font, color, rect.Center(), (int)angle);
                //g.DrawString(s, font, br, layoutRectangle, format, angle);
            }
        }

        /// <summary>
        /// 以文字中心点为原点，旋转文字
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="text">文字</param>
        /// <param name="font">字体</param>
        /// <param name="color">颜色</param>
        /// <param name="centerPoint">文字中心点</param>
        /// <param name="angle">角度</param>
        public static void DrawStringRotateAtCenter(this Graphics g, string text, Font font, Color color, PointF centerPoint, float angle)
        {
            using (Brush br = color.Brush())
            {
                g.DrawStringRotateAtCenter(text, font, br, centerPoint, angle);
            }
        }

        /// <summary>
        /// 以文字中心点为原点，旋转文字
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="text">文字</param>
        /// <param name="font">字体</param>
        /// <param name="brush">笔刷</param>
        /// <param name="centerPoint">文字中心点</param>
        /// <param name="angle">角度</param>
        public static void DrawStringRotateAtCenter(this Graphics g, string text, Font font, Brush brush, PointF centerPoint, float angle)
        {
            SizeF sf = g.MeasureString(text, font);
            float x1 = centerPoint.X - sf.Width / 2.0f;
            float y1 = centerPoint.Y - sf.Height / 2.0f;

            // 把画板的原点(默认是左上角)定位移到文字中心
            g.TranslateTransform(x1 + sf.Width / 2, y1 + sf.Height / 2);
            // 旋转画板
            g.RotateTransform(angle);
            // 回退画板x,y轴移动过的距离
            g.TranslateTransform(-(x1 + sf.Width / 2), -(y1 + sf.Height / 2));
            g.DrawString(text, font, brush, x1, y1);

            //恢复
            g.TranslateTransform(x1 + sf.Width / 2, y1 + sf.Height / 2);
            g.RotateTransform(-angle);
            g.TranslateTransform(-(x1 + sf.Width / 2), -(y1 + sf.Height / 2));
        }

        /// <summary>
        /// 以旋转点为原点，旋转文字
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="text">文本</param>
        /// <param name="font">字体</param>
        /// <param name="brush">填充</param>
        /// <param name="rotatePoint">旋转点</param>
        /// <param name="format">布局方式</param>
        /// <param name="angle">角度</param>
        public static void DrawString(this Graphics g, string text, Font font, Brush brush, PointF rotatePoint, StringFormat format, float angle)
        {
            // Save the matrix
            Matrix mtxSave = g.Transform;

            Matrix mtxRotate = g.Transform;
            mtxRotate.RotateAt(angle, rotatePoint);
            g.Transform = mtxRotate;

            g.DrawString(text, font, brush, rotatePoint, format);

            // Reset the matrix
            g.Transform = mtxSave;
        }

        public static void DrawString(this Graphics g, string s, Font font, Color color, PointF rotatePoint, StringFormat format, float angle)
        {
            using (Brush br = color.Brush())
            {
                g.DrawString(s, font, br, rotatePoint, format, angle);
            }
        }

        /// <summary>
        /// 绘制根据矩形旋转文本
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="text">文本</param>
        /// <param name="font">字体</param>
        /// <param name="brush">填充</param>
        /// <param name="rect">局部矩形</param>
        /// <param name="format">布局方式</param>
        /// <param name="angle">角度</param>
        public static void DrawString(this Graphics g, string text, Font font, Brush brush, RectangleF rect, StringFormat format, float angle)
        {
            g.DrawStringRotateAtCenter(text, font, brush, rect.Center(), angle);
        }

        public static void DrawTwoPoints(this Graphics g, Color color, PointF pf1, PointF pf2, Rectangle rect, bool smooth = true, float penWidth = 1)
        {
            using Pen pen = color.Pen(penWidth);
            DrawTwoPoints(g, pen, pf1, pf2, rect, smooth);
        }

        public static void DrawTwoPoints(this Graphics g, Pen pen, PointF pf1, PointF pf2, Rectangle rect, bool smooth = true)
        {
            bool haveLargePixel = Math.Abs(pf1.X - pf2.X) >= rect.Width * 100 || Math.Abs(pf1.Y - pf2.Y) >= rect.Height * 100;

            //两点都在区域内
            if (pf1.InRect(rect) && pf2.InRect(rect))
            {
                g.Smooth(smooth);
                g.DrawLine(pen, pf1, pf2);
                g.Smooth(false);
                return;
            }

            //无大坐标像素
            if (!haveLargePixel)
            {
                g.Smooth(smooth);
                g.DrawLine(pen, pf1, pf2);
                g.Smooth(false);
                return;
            }

            //垂直线
            if (pf1.X.Equals(pf2.X))
            {
                if (pf1.X <= rect.Left) return;
                if (pf1.X >= rect.Right) return;
                if (pf1.Y <= rect.Top && pf2.Y <= rect.Top) return;
                if (pf1.Y >= rect.Bottom && pf2.Y >= rect.Bottom) return;

                g.Smooth(smooth);
                float yy1 = Math.Min(pf1.Y, pf2.Y);
                float yy2 = Math.Max(pf1.Y, pf2.Y);
                if (yy1 <= rect.Top)
                {
                    if (yy2 <= rect.Bottom) g.DrawLine(pen, pf1.X, rect.Top, pf1.X, yy2);
                    else g.DrawLine(pen, pf1.X, rect.Top, pf1.X, rect.Bottom);
                }
                else
                {
                    if (yy2 <= rect.Bottom) g.DrawLine(pen, pf1.X, yy1, pf1.X, yy2);
                    else g.DrawLine(pen, pf1.X, yy1, pf1.X, rect.Bottom);
                }

                g.Smooth(false);
                return;
            }

            //水平线
            if (pf1.Y.Equals(pf2.Y))
            {
                if (pf1.Y <= rect.Top) return;
                if (pf1.Y >= rect.Bottom) return;
                if (pf1.X <= rect.Left && pf2.X <= rect.Left) return;
                if (pf1.X >= rect.Right && pf2.X >= rect.Right) return;

                g.Smooth(smooth);
                float xx1 = Math.Min(pf1.X, pf2.X);
                float xx2 = Math.Max(pf1.X, pf2.X);
                if (xx1 <= rect.Left)
                {
                    if (xx2 <= rect.Right) g.DrawLine(pen, rect.Left, pf1.Y, xx2, pf1.Y);
                    else g.DrawLine(pen, rect.Left, pf1.Y, rect.Right, pf1.Y);
                }
                else
                {
                    if (xx2 <= rect.Right) g.DrawLine(pen, xx1, pf1.Y, xx2, pf1.Y);
                    else g.DrawLine(pen, xx1, pf1.Y, rect.Right, pf1.Y);
                }

                g.Smooth(false);
                return;
            }

            //判断两个区域是否相交
            RectangleF rect1 = pf1.CreateRectangleF(pf2);
            if (!rect1.IsOverlap(rect)) return;

            double x1 = Drawing.CalcX(pf1, pf2, rect.Top);
            double x2 = Drawing.CalcX(pf1, pf2, rect.Bottom);
            double y1 = Drawing.CalcY(pf1, pf2, rect.Left);
            double y2 = Drawing.CalcY(pf1, pf2, rect.Right);

            //判断线段是否和区域有交点
            bool isExist = x1.InRange(rect.Left, rect.Right) || x2.InRange(rect.Left, rect.Right) || y1.InRange(rect.Top, rect.Bottom) || y2.InRange(rect.Top, rect.Bottom);
            if (!isExist) return;

            List<PointF> TwoPoints = new List<PointF>();
            if (!pf1.InRect(rect) && !pf2.InRect(rect))
            {
                if (x1.InRange(rect.Left, rect.Right)) TwoPoints.Add(new PointF((float)x1, rect.Top));
                if (x2.InRange(rect.Left, rect.Right)) TwoPoints.Add(new PointF((float)x2, rect.Bottom));
                if (y1.InRange(rect.Top, rect.Bottom)) TwoPoints.Add(new PointF(rect.Left, (float)y1));
                if (y2.InRange(rect.Top, rect.Bottom)) TwoPoints.Add(new PointF(rect.Right, (float)y2));
            }
            else
            {
                PointF center = pf1.InRect(rect) ? pf1 : pf2;
                PointF border = pf2.InRect(rect) ? pf1 : pf2;
                TwoPoints.Add(center);
                if (border.X >= center.X)
                {
                    if (border.Y >= center.Y)
                    {
                        TwoPoints.Add(x2 <= rect.Right ? new PointF((float)x2, rect.Bottom) : new PointF(rect.Right, (float)y2));
                    }
                    else
                    {
                        TwoPoints.Add(x1 <= rect.Right ? new PointF((float)x1, rect.Top) : new PointF(rect.Right, (float)y2));
                    }
                }
                else
                {
                    if (border.Y >= center.Y)
                    {
                        TwoPoints.Add(x2 >= rect.Left ? new PointF((float)x2, rect.Bottom) : new PointF(rect.Left, (float)y1));
                    }
                    else
                    {
                        TwoPoints.Add(x1 >= rect.Left ? new PointF((float)x1, rect.Bottom) : new PointF(rect.Left, (float)y1));
                    }
                }
            }

            if (TwoPoints.Count == 2)
            {
                g.Smooth(smooth);
                g.DrawLine(pen, TwoPoints[0], TwoPoints[1]);
                g.Smooth(false);
            }
            else
            {
                Console.WriteLine(TwoPoints.Count);
            }

            TwoPoints.Clear();
        }

        /// <summary>
        /// 以center为中心，绘制箭头，正北0°，顺时针0°到359°
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="color">颜色</param>
        /// <param name="center">中心点</param>
        /// <param name="arrowSize">箭头尺寸</param>
        /// <param name="arrowDir">箭头方向</param>
        /// <param name="penWidth">笔宽</param>
        public static void DrawArrow(this Graphics g, Color color, PointF center, float arrowSize, float arrowDir, float penWidth = 1)
        {
            using Pen pen = color.Pen(penWidth);
            PointF pfStart = new PointF(Convert.ToSingle(center.X + arrowSize * Math.Sin(arrowDir.Rad()) / 2),
                Convert.ToSingle(center.Y - arrowSize * Math.Cos(arrowDir.Rad()) / 2));
            PointF pfEnd = new PointF(Convert.ToSingle(center.X - arrowSize * Math.Sin(arrowDir.Rad()) / 2),
                Convert.ToSingle(center.Y + arrowSize * Math.Cos(arrowDir.Rad()) / 2));

            double dAngle = arrowDir + 180 + 25;
            PointF pfArrow1 = new PointF(Convert.ToSingle(pfStart.X + arrowSize * Math.Sin(dAngle.Rad()) / 2),
                Convert.ToSingle(pfStart.Y - arrowSize * Math.Cos(dAngle.Rad()) / 2));

            dAngle = arrowDir + 180 - 25;
            PointF pfArrow2 = new PointF(Convert.ToSingle(pfStart.X + arrowSize * Math.Sin(dAngle.Rad()) / 2),
                Convert.ToSingle(pfStart.Y - arrowSize * Math.Cos(dAngle.Rad()) / 2));

            PointF[] pfPoints = { pfArrow1, pfStart, pfEnd, pfStart, pfArrow2 };
            g.DrawLines(pen, pfPoints);
        }
    }
}