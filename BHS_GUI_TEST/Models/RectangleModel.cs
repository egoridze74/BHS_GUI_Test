using System.ComponentModel;

namespace BHS_GUI_TEST.Models;

public class RectangleModel : Shape, INotifyPropertyChanged
{
    private double width;
    private double height;

    public double Width
    {
        get => width;
        set
        {
            if (width != value)
            {
                width = value;
                OnChanged(nameof(Width));
            }
        }
    }

    public double Height
    {
        get => height;
        set
        {
            if (height != value)
            {
                height = value;
                OnChanged(nameof(Height));
            }
        }
    }
}
