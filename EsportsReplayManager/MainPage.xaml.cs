using CommunityToolkit.Mvvm.ComponentModel;
using EsportsReplayManager.Modules.FileSystem;
using EsportsReplayManager.ViewModels;
using System.Collections.ObjectModel;

namespace EsportsReplayManager
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
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
    }
}