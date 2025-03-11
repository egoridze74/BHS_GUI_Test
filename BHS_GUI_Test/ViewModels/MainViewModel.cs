using Avalonia.Media;
using BHS_GUI_TEST.Models;
using ReactiveUI;
using System.Reactive;

namespace BHS_GUI_TEST.ViewModels;

public class MainViewModel : ViewModelBase
{
    private Shape currentShape;
    private readonly RectangleModel rectangle;
    private readonly CircleModel circle;
    private bool isRectangle;

    public MainViewModel()
    {
        rectangle = new RectangleModel
        {
            Width = 100,
            Height = 100,
            Rotation = 0,
            Color = Brushes.LightBlue.Color,
            Text = "Rectangle",
            TextColor = Brushes.Black.Color
        };

        circle = new CircleModel
        {
            Horizontal = 1.0,
            Vertical = 1.0,
            Color = Brushes.LightGreen.Color,
            Text = "Circle",
            TextColor = Brushes.Black.Color,
            Rotation = 0
        };

        currentShape = rectangle;
        isRectangle = true;
        SwitchShapeCommand = ReactiveCommand.Create(SwitchShape);
    }

    public bool IsRectangle
    {
        get => isRectangle;
        set
        {
            this.RaiseAndSetIfChanged(ref isRectangle, value);
            CurrentShape = isRectangle ? (Shape)rectangle : circle;
        }
    }

    public Shape CurrentShape
    {
        get => currentShape;
        set => this.RaiseAndSetIfChanged(ref currentShape, value);
    }

    public RectangleModel Rectangle => rectangle;
    public CircleModel Circle => circle;

    public ReactiveCommand<Unit, Unit> SwitchShapeCommand { get; }

    private void SwitchShape()
    {
        CurrentShape = IsRectangle ? rectangle : circle;
    }
}
