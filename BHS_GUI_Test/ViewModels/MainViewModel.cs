using CommunityToolkit.Mvvm.ComponentModel;

namespace BHS_GUI_Test.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
