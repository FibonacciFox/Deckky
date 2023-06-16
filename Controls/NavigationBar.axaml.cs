using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Deckky.Controls.Buttons;

namespace Deckky.Controls;

public partial class NavigationBar : UserControl
{
    protected int _currentButtonSelected = 0;

    private List<NavigationButton> _navigationButtonList = new();
    
    public NavigationBar()
    {
        InitializeComponent();
        
        _navigationButtonList.Add(NavButton1);
        _navigationButtonList.Add(NavButton2);
        _navigationButtonList.Add(NavButton3);
        _navigationButtonList.Add(NavButton4);
        _navigationButtonList.Add(NavButton5);
        
        NavButton1.Classes.Add("Selected");
        
        this.KeyUp += OnKeyUp;
    }

    private void OnKeyUp(object? sender, KeyEventArgs e)
    {
        if (e.Key == Key.LeftCtrl)
        {
            _navigationButtonList[_currentButtonSelected].Classes.Remove("Selected");
            _currentButtonSelected -= 1;
            _navigationButtonList[_currentButtonSelected].Classes.Add("Selected");
        }
        
        if (e.Key == Key.RightCtrl)
        {
            _navigationButtonList[_currentButtonSelected].Classes.Remove("Selected");
            _currentButtonSelected += 1;
            _navigationButtonList[_currentButtonSelected].Classes.Add("Selected");
        }
    }
}