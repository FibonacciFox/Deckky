using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Deckky.Controls;

public class UxButton : Button
{
    protected override Type StyleKeyOverride => typeof(Button);
    
    public UxButton()
    {
        
    }
}