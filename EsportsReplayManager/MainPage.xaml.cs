using EsportsReplayManager.Modules.FileSystem;

namespace EsportsReplayManager
{
    public partial class MainPage : ContentPage
    {
        private readonly IFileSystemService _fileSystemService;
        int count = 0;

        public MainPage(IFileSystemService fileSystemService)
        {
            InitializeComponent();
            _fileSystemService = fileSystemService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count += 20;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void OnGetReplaysButtonClicked(object sender, EventArgs e)
        {
            _fileSystemService.GetReplaysFromDisk();
        }
    }
}