using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;

namespace Deckky.Controls;

public partial class NavigationBar : UserControl
{

    /// <summary>
    /// Заголовок NavigationBarItem
    /// </summary>
    public static readonly StyledProperty<int> ActiveItemProperty =
        AvaloniaProperty.Register<NavigationBarItem, int>(nameof(ActiveItem));
    
    /// <summary>
    /// Устанавливает или получает текущий индекс выбранного NavigationBarItem
    /// </summary>
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

            var newSelectedItemIndex = GetFilteredIndexItemValue(value);
           
            SetValue(ActiveItemProperty, newSelectedItemIndex);
            _navigationItems[newSelectedItemIndex].Selected = true;
        }
    }

    public NavigationBar()
    {
        InitializeComponent();

        foreach (var item in NavigationItems.Children)
        {
            _navigationItems.Add((NavigationBarItem)item);
        }
        
    }
    /// <summary>
    /// Выбрать предыдущий NavigationBarItem
    /// </summary>
    public void SelectPreviousItem()
    {
        --ActiveItem;
    }
    
    /// <summary>
    /// Выбрать следующий NavigationBarItem
    /// </summary>
    public void SelectNextItem()
    {
        ++ActiveItem;
    }

    /// <summary>
    /// Позволяет фильтровать индекс элемента навигации, чтобы не выходить из диапазона списка NavigationBarItem
    /// </summary>
    /// <param name="indexValue"></param>
    /// <returns></returns>
    private int GetFilteredIndexItemValue(int indexValue)
    {
        if (indexValue >= NavigationItems.Children.Count)
        {
            return 0;
        }
            
        if (indexValue <=-1)
        {
            return NavigationItems.Children.Count - 1;
        }

        return indexValue;
    }

    private List<NavigationBarItem> _navigationItems = new();
}