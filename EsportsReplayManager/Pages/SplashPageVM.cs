using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EsportsReplayManager.Pages;

public partial class SplashPageVM : ObservableObject
{
    [RelayCommand]
    async Task Skip()
    {
        await Shell.Current.GoToAsync(nameof(MainPage));
    }
}
