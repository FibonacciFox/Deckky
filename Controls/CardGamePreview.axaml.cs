using Avalonia;
using Avalonia.Controls;

namespace Deckky.Controls;

public partial class CardGamePreview : UserControl
{
    /// <summary>
    /// Заголовок игры
    /// </summary>
    public static readonly StyledProperty<string> TitleProperty =
        AvaloniaProperty.Register<CardGamePreview, string>(nameof(Title));
    
    /// <summary>
    /// Имя торрент трекера
    /// </summary>
    //public static readonly StyledProperty<string> TorrentTrackerNameProperty =
       // AvaloniaProperty.Register<CardGamePreview, string>(nameof(TorrentTrackerName));
    
    /// <summary>
    /// Заголовок игры
    /// </summary>
    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    
    /// <summary>
    /// Имя торрент трекера
    /// </summary>
    //public string TorrentTrackerName
    //{
    //    get => GetValue(TorrentTrackerNameProperty);
    //    set => SetValue(TorrentTrackerNameProperty, value);
    //}
    
    public CardGamePreview()
    {
        InitializeComponent();
        Title = "Название игры";
        //TorrentTrackerName = "RuTracker1";
    }
    
    
    
}