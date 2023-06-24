using Avalonia.Controls;
using Avalonia.Input;

namespace Deckky;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        KeyDown+= OnKeyDown;

        CarouselPage.SelectedIndex = NavigationBar.ActiveItem;
    }

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.LeftCtrl)
        {
            NavigationBar.SelectPreviousItem();
            Title = $"Выбранный элемент: {NavigationBar.ActiveItem}";
            CarouselPage.SelectedIndex = NavigationBar.ActiveItem;
        }
        
        if (e.Key == Key.RightCtrl)
        {
            NavigationBar.SelectNextItem();
            Title = $"Выбранный элемент: {NavigationBar.ActiveItem}";
            CarouselPage.SelectedIndex = NavigationBar.ActiveItem;
        }
    }
}