using Xamarin.Forms;
using XConferenceApp.ViewModels;

namespace XConferenceApp.Views
{
    [QueryProperty(nameof(SpeakerId), nameof(SpeakerId))]
    public partial class SpeakerDetailView
    {
        private readonly SpeakerDetailViewModel speakerDetailViewModel;
        public string SpeakerId
        {
            set
            {
                if (int.TryParse(value, out var speakerId))
                {
                    speakerDetailViewModel.LoadData(speakerId);
                }
            }
        }

        public SpeakerDetailView()
        {
            InitializeComponent();
            speakerDetailViewModel = new SpeakerDetailViewModel();
            BindingContext = speakerDetailViewModel;
        }
    }
}