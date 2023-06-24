using Avalonia;
using Avalonia.Controls;

namespace Deckky.Controls;

public partial class NavigationBarItem : UserControl
{
    /// <summary>
    /// Заголовок NavigationBarItem
    /// </summary>
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<NavigationBarItem, string>(nameof(Title));
    
    /// <summary>
    /// Счетчик чего либо на NavigationBarItem
    /// </summary>
    public static readonly StyledProperty<int> CounterProperty =
        AvaloniaProperty.Register<NavigationBarItem, int>(nameof(Counter));
    
    /// <summary>
    /// Отображать счетчик
    /// </summary>
    public static readonly StyledProperty<bool> IsVisibleCounterProperty =
        AvaloniaProperty.Register<NavigationBarItem, bool>(nameof(IsVisibleCounter));
    
    /// <summary>
    /// Заголовок NavigationBarItem
    /// </summary>
    public static readonly StyledProperty<bool> SelectedProperty =
        AvaloniaProperty.Register<NavigationBarItem, bool>(nameof(Selected));
    
    /// <summary>
    /// Заголовок NavigationBarItem
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
    public bool Selected
    {
        get => GetValue(SelectedProperty);
        set
        {
            if (value) 
                Classes.Add("Selected");
            else
                Classes.Remove("Selected");
            SetValue(SelectedProperty, value);
        }
    }

    /// <summary>
    /// Отображать счетчик
    /// </summary>
    public bool IsVisibleCounter
    {
        get => ItemCounter.IsVisible;
        set => ItemCounter.IsVisible = value;
    }

    public NavigationBarItem()
    {
        InitializeComponent();
        Selected = false;
    }
    
}