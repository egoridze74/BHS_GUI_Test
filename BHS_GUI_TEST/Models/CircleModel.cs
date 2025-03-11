using System.ComponentModel;

namespace BHS_GUI_TEST.Models;

public class CircleModel : Shape, INotifyPropertyChanged
{
    private double horizontal;
    private double vertical;

    public double Horizontal
    {
        get => horizontal;
        set
        {
            if (horizontal != value)
            {
                horizontal = value;
                OnChanged(nameof(Horizontal));
            }
        }
    }

    public double Vertical
    {
        get => vertical;
        set
        {
            if (vertical != value)
            {
                vertical = value;
                OnChanged(nameof(Vertical));
            }
        }
    }
}
