using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Deckky.Controls;

public partial class NavigationBar : UserControl
{
    public NavigationBar()
    {
        InitializeComponent();
        
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}