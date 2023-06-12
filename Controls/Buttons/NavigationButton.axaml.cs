using Avalonia;
using Avalonia.Controls;

namespace Deckky.Controls.Buttons;

public partial class NavigationButton : UserControl
{

    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<NavigationButton, string>(nameof(Title));

    public string Title
    {
        get => ButtonTitle.Text;
        set => ButtonTitle.Text = value;
    }
    
    public NavigationButton()
    {
        InitializeComponent();
    }

}