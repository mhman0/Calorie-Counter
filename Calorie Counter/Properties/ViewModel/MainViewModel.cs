using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Calorie_Counter.Properties.ViewModel;

//Implimenting MVVM
//// Define a class named MainViewModel that implements the INotifyPropertyChanged interface.
//public class MainViewModel : INotifyPropertyChanged
//{
//    // Declare a private field to store the text value.
//    string text;

//    // Define a public property named Text that gets and sets the value of the text field.
//    public string Text
//    {
//        get => text; // Getter returns the current value of the text field.
//        set
//        {
//            text = value; // Setter sets the value of the text field to the provided value.

//            // Invoke the OnPropertyChanged method to notify subscribers about the property change.
//            OnPropertyChanged(nameof(Text));
//        }
//    }

//    // Declare an event of type PropertyChangedEventHandler, which is raised when a property value changes.
//    public event PropertyChangedEventHandler PropertyChanged;

//    // Define a method named OnPropertyChanged that takes the name of the changed property.
//    void OnPropertyChanged(string name) =>
//        // Invoke the PropertyChanged event, passing this instance and PropertyChangedEventArgs with the property name.
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//}

public partial class MainViewModel : ObservableObject // 
{
    [ObservableProperty]
    string text;
}