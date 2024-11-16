namespace MauiAppEightWeek.Views;

public partial class FlexPage : ContentPage
{
    public FlexPage()
    {
        InitializeComponent();
    }
    public void NewPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsolutePage());
    }
}