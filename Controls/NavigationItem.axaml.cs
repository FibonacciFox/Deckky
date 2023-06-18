using Avalonia;
using Avalonia.Controls;

namespace Deckky.Controls;

public partial class NavigationItem : UserControl
{
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<NavigationItem, string>(nameof(Title));
    
    /// <summary>
    /// Счетчик чего либо на кнопке
    /// </summary>
    public static readonly StyledProperty<int> CounterProperty =
        AvaloniaProperty.Register<NavigationItem, int>(nameof(Counter));
    
    /// <summary>
    /// Отображать счетчик
    /// </summary>
    public static readonly StyledProperty<bool> IsVisibleCounterProperty =
        AvaloniaProperty.Register<NavigationItem, bool>(nameof(IsVisibleCounter));
    
    /// <summary>
    /// Заголовок NavigationItem
    /// </summary>
    public string Title
    {
        get => ItemTitle.Text;
        set => ItemTitle.Text = value;
    }
    
    /// <summary>
    /// Счетчик чего либо на кнопке
    /// </summary>
    public int Counter
    {
        get => int.Parse(ItemCounter.Text);
        set => ItemCounter.Text = value.ToString();
    }
    
    /// <summary>
    /// Отображать счетчик
    /// </summary>
    public bool IsVisibleCounter
    {
        get => ItemCounter.IsVisible;
        set => ItemCounter.IsVisible = value;
    }
    
    public NavigationItem()
    {
        InitializeComponent();
    }
    
}