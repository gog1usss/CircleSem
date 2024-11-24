using System.Drawing;
using System;

public class CEmblem
{
    private Graphics graphics;
    private int x, y, radius;
    private Pen pen;

    public CEmblem(Graphics g, int centerX, int centerY, int initialRadius)
    {
        graphics = g;
        x = centerX;
        y = centerY;
        radius = initialRadius;
        pen = new Pen(Color.Black, 2);
    }

    public void Show()
    {
        graphics.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
        graphics.DrawEllipse(pen, x - radius / 2, y - radius / 2, radius, radius);

        int triangleHeight = (int)(radius * 0.9); // Высота треугольника почти равна радиусу круга

        Point[] triangle = new Point[]
        {
            new Point(x, y + triangleHeight),        // Нижняя вершина треугольника
            new Point(x - triangleHeight, y - triangleHeight / 2), // Левая верхняя точка
            new Point(x + triangleHeight, y - triangleHeight / 2)  // Правая верхняя точка
        };
        graphics.DrawPolygon(pen, triangle);
        graphics.DrawLine(pen, x - radius, y, x + radius, y);
    }

    public void Hide()
    {
        Pen erasePen = new Pen(Color.White, 2);
        graphics.DrawEllipse(erasePen, x - radius, y - radius, radius * 2, radius * 2);
        graphics.DrawEllipse(erasePen, x - radius / 2, y - radius / 2, radius, radius);

        int triangleHeight = (int)(radius * 0.9);

        Point[] triangle = new Point[]
        {
            new Point(x, y + triangleHeight),
            new Point(x - triangleHeight, y - triangleHeight / 2),
            new Point(x + triangleHeight, y - triangleHeight / 2)
        };
        graphics.DrawPolygon(erasePen, triangle);
        graphics.DrawLine(erasePen, x - radius, y, x + radius, y);
    }

    public void Move(int dx, int dy)
    {
        Hide();
        x += dx;
        y += dy;
        Show();
    }

    public void Expand(int increment)
    {
        Hide();
        radius += increment;
        Show();
    }

    public void Collapse(int decrement)
    {
        Hide();
        radius = Math.Max(10, radius - decrement);
        Show();
    }
}
