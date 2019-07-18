using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using XConferenceApp.Models;
using XConferenceApp.Repositories;
using XConferenceApp.Resources;
using XConferenceApp.Views;

namespace XConferenceApp.ViewModels
{
    public class SpeakerDetailViewModel : ViewModelBase
    {
        private readonly SpeakerRepository speakerRepository;
        private readonly SessionRepository sessionRepository;

        public SpeakerModel Speaker { get; set; }
        public List<SessionModel> Sessions { get; set; }

        public ICommand GoToSessionDetailCommand { get; set; }

        public SpeakerDetailViewModel()
        {
            speakerRepository = new SpeakerRepository();
            sessionRepository = new SessionRepository();
            GoToSessionDetailCommand = new Command<int>(GoToSessionDetail, _ => true);
        }

        private void GoToSessionDetail(int sessionId)
        {
            Shell.Current.GoToAsync($"{RouteConfig.SessionDetailSingle}?{nameof(SessionDetailView.SessionId)}={sessionId}");
        }

        public void LoadData(int speakerId)
        {
            Speaker = speakerRepository.GetByKey(speakerId);

            Sessions = sessionRepository.GetBySpeakerId(speakerId);
        }
    }
}