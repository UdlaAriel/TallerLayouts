namespace MauiAppEightWeek.Views;

public partial class AbsolutePage : ContentPage
{
    public AbsolutePage()
    {
        InitializeComponent();
    }
    public void NewPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridPage());
    }
}