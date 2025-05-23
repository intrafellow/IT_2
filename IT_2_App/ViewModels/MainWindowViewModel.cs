using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IT_2_App.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private int _clickCount;

    [RelayCommand]
    private void Click()
    {
        ClickCount++;
    }
}
