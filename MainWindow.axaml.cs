using Avalonia.Controls;
using Avalonia.Input;

namespace Deckky;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        KeyDown+= OnKeyDown;
    }

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.LeftCtrl)
        {
            NavBar.PreviousItem();
        }
        
        if (e.Key == Key.RightCtrl)
        {
            NavBar.NextItem();
        }
    }
}