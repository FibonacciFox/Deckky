using Avalonia.Controls;
using Avalonia.Input;

namespace Deckky;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        KeyDown+= OnKeyDown;

        CarouselPage.Carousel.SelectedIndex = NavBar.ActiveItem;
    }

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.LeftCtrl)
        {
            NavBar.SelectPreviousItem();
            Title = $"Выбранный элемент: {NavBar.ActiveItem}";
            CarouselPage.Carousel.SelectedIndex = NavBar.ActiveItem;
        }
        
        if (e.Key == Key.RightCtrl)
        {
            NavBar.SelectNextItem();
            Title = $"Выбранный элемент: {NavBar.ActiveItem}";
            CarouselPage.Carousel.SelectedIndex = NavBar.ActiveItem;
        }
    }
}