using System.ComponentModel;

namespace Calorie_Counter.Properties.ViewModel;

//Implimenting MVVM
public class MainViewModel : INotifyPropertyChanged // going to give us this system command compnent model
{
    string text;
    public string Text
    {
        get => text; 
        set
        {
            text = value;
            OnPropertyChanged(nameof(Text));
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

