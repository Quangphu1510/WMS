using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomProgressBar : Control
{
    private int _value = 0;
    private int _maximum = 100;
    private int _radius = 4;
    private bool _SetBad = false;
    private int _Bad = 25;

    public CustomProgressBar()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.ResizeRedraw, true);

        Size = new Size(200, 25);
    }

    [DefaultValue(0)]
    public int Value
    {
        get => _value;
        set
        {
            _value = Math.Max(0, Math.Min(value, _maximum));
            Invalidate();
        }
    }

    [DefaultValue(100)]
    public int Maximum
    {
        get => _maximum;
        set
        {
            _maximum = Math.Max(1, value);
            Invalidate();
        }
    }

    [DefaultValue(4)]
    public int CornerRadius
    {
        get => _radius;
        set
        {
            _radius = value;
            Invalidate();
        }
    }

    [DefaultValue(false)]
    public bool SetBad
    {
        get => _SetBad;
        set
        {
            _SetBad = value;
            Invalidate();
        }
    }
    
    [DefaultValue(25)]
    public int BadPercent
    {
        get => _Bad;
        set
        {
            _Bad = value;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectBg = ClientRectangle;
        Rectangle rectBar = ClientRectangle;

        float percent = (float)_value / _maximum;

        int minWidth = _radius * 2;
        rectBar.Width = Math.Max((int)(rectBg.Width * percent), minWidth);

        using (GraphicsPath bgPath = RoundedRect(rectBg, _radius))
        using (SolidBrush bgBrush = new SolidBrush(Color.FromArgb(230, 230, 230)))
        {
            e.Graphics.FillPath(bgBrush, bgPath);
        }

        Color barColor = GetColorByPercent(percent);

        using (GraphicsPath barPath = RoundedRect(rectBar, _radius))
        using (SolidBrush barBrush = new SolidBrush(barColor))
        {
            e.Graphics.FillPath(barBrush, barPath);
        }

        string text = $"{(int)(percent * 100)}%";
        TextRenderer.DrawText(
            e.Graphics,
            text,
            Font,
            rectBg,
            Color.Black,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
        );
    }

    private GraphicsPath RoundedRect(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int d = radius * 2;

        path.AddArc(rect.X, rect.Y, d, d, 180, 90);
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
        path.CloseFigure();

        return path;
    }

    private Color GetColorByPercent(float p)
    {
        if (_SetBad) return Color.Red;

        if (p == 0) return Color.Red;
        if (p < (float)_Bad/100) return Color.Orange;
        return Color.Green;
    }
}
