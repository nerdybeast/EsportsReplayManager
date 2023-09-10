using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EsportsReplayManager.Modules.FileSystem;
using System.Collections.ObjectModel;

namespace EsportsReplayManager.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly IFileSystemService _fileSystemService;

    public MainPageViewModel(IFileSystemService fileSystemService)
    {
        _fileSystemService = fileSystemService;
        FullyQualifiedReplayFilePaths = new();
    }

    [ObservableProperty]
    ObservableCollection<string> fullyQualifiedReplayFilePaths;

    [RelayCommand]
    public async Task GetReplaysOnDisk()
    {
        var fullyQualifiedReplayFilePaths = await _fileSystemService.GetReplaysFromDisk();
        FullyQualifiedReplayFilePaths.Clear();
        fullyQualifiedReplayFilePaths.ForEach(FullyQualifiedReplayFilePaths.Add);
    }
}
