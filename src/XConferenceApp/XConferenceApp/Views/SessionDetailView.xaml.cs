using Xamarin.Forms;
using XConferenceApp.ViewModels;

namespace XConferenceApp.Views
{
    [QueryProperty(nameof(SessionId), nameof(SessionId))]
    public partial class SessionDetailView
    {
        private readonly SessionDetailViewModel sessionDetailViewModel;

        public string SessionId
        {
            set
            {
                if (value != null && int.TryParse(value, out var sessionId))
                {
                    sessionDetailViewModel.LoadData(sessionId);
                }
            }
        }

        public SessionDetailView()
        {
            InitializeComponent();

            sessionDetailViewModel = new SessionDetailViewModel();
            BindingContext = sessionDetailViewModel;
        }
    }
}