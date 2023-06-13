using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;

namespace Deckky.Controls.Buttons;

public partial class NavigationButton : Button, IStyleable
{
    Type IStyleable.StyleKey => typeof(Button);
    
    /// <summary>
    /// Заголовок кнопки
    /// </summary>
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<NavigationButton, string>(nameof(Title));
    
    /// <summary>
    /// Счетчик чего либо на кнопке
    /// </summary>
    public static readonly StyledProperty<string> CounterProperty =
        AvaloniaProperty.Register<NavigationButton, string>(nameof(Counter));
    
    /// <summary>
    /// Отображать счетчик
    /// </summary>
    public static readonly StyledProperty<bool> IsVisibleCounterProperty =
        AvaloniaProperty.Register<NavigationButton, bool>(nameof(IsVisibleCounter));
    
    
    /// <summary>
    /// Заголовок кнопки
    /// </summary>
    public string Title
    {
        get => ButtonTitle.Text;
        set => ButtonTitle.Text = value;
    }
    
    /// <summary>
    /// Счетчик чего либо на кнопке
    /// </summary>
    public string Counter
    {
        get => ButtonCounter.Text;
        set => ButtonCounter.Text = value;
    }
    /// <summary>
    /// Отображать счетчик
    /// </summary>
    public bool IsVisibleCounter
    {
        get => ButtonCounter.IsVisible;
        set => ButtonCounter.IsVisible = value;
    }
    
    public NavigationButton()
    {
        InitializeComponent();
    }

}