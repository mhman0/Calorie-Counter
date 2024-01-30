
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calorie_Counter.Properties.ViewModel;

[QueryProperty("Text", "Text")]

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string? text;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");// if I add .. and a / would take you to an exact location.
        }
}
