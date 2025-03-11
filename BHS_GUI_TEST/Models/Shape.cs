using System.ComponentModel;
using Avalonia.Media;

namespace BHS_GUI_TEST.Models;

public abstract class Shape : INotifyPropertyChanged
{
    private SolidColorBrush color;
    private string text;
    private SolidColorBrush textColor;
    double rotation;

    public SolidColorBrush Brush
    {
        get => color;
        set
        {
            if (color == null || color != value)
            {
                color = value;
                OnChanged(nameof(Color));
                OnChanged(nameof(Brush));
            }
        }
    }

    public Color Color
    {
        get => color.Color;
        set
        {
            if (color == null || color.Color != value)
            {
                color = new SolidColorBrush(value);
                OnChanged(nameof(Color));
                OnChanged(nameof(Brush));
            }
        }
    }

    public string Text
    {
        get => text;
        set
        {
            if (text != value)
            {
                text = value;
                OnChanged(nameof(Text));
            }
        }
    }

    public SolidColorBrush TextColorBrush
    {
        get => textColor;
        set
        {
            if (textColor == null || textColor != value)
            {
                textColor = value;
                OnChanged(nameof(TextColor));
                OnChanged(nameof(TextColorBrush));
            }
        }
    }

    public Color TextColor
    {
        get => textColor.Color;
        set
        {
            if (textColor == null || textColor.Color != value)
            {
                textColor = new SolidColorBrush(value);
                OnChanged(nameof(TextColor));
                OnChanged(nameof(TextColorBrush));
            }
        }
    }

    public double Rotation
    {
        get => rotation;
        set
        {
            if (rotation != value)
            {
                rotation = value;
                OnChanged(nameof(Rotation));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
