using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;

namespace Deckky.Controls;

public partial class NavigationBar : UserControl
{

    /// <summary>
    /// Заголовок NavigationItem
    /// </summary>
    public static readonly StyledProperty<int> ActiveItemProperty =
        AvaloniaProperty.Register<NavigationItem, int>(nameof(ActiveItem));

    public int ActiveItem
    {
        get
        {
            return GetValue(ActiveItemProperty);
        }
        set
        {
            var lastActiveItem = GetValue(ActiveItemProperty);
            _navigationItems[lastActiveItem].Selected = false;
            SetValue(ActiveItemProperty, value);
            _navigationItems[value].Selected = true;
        }
    }

    public NavigationBar()
    {
        InitializeComponent();

        foreach (var Item in NavigationItems.Children)
        {
            _navigationItems.Add((NavigationItem)Item);
        }
        
    }

    public void PreviousItem()
    {
        ActiveItem -= 1;
    }
    
    public void NextItem()
    {
        ActiveItem += 1;
    }
    
    private List<NavigationItem> _navigationItems = new();
}