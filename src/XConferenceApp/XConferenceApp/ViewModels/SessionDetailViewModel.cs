using System.Windows.Input;
using Xamarin.Forms;
using XConferenceApp.Models;
using XConferenceApp.Repositories;
using XConferenceApp.Resources;
using XConferenceApp.Views;

namespace XConferenceApp.ViewModels
{
    public class SessionDetailViewModel : ViewModelBase
    {
        private readonly SpeakerRepository speakerRepository;
        private readonly SessionRepository sessionRepository;
        private readonly RoomRepository roomRepository;

        public SessionModel Session { get; set; }
        public SpeakerModel Speaker { get; set; }
        public RoomModel Room { get; set; }

        public ICommand GoToSpeakerDetailCommand { get; set; }

        public SessionDetailViewModel()
        {
            speakerRepository = new SpeakerRepository();
            sessionRepository = new SessionRepository();
            roomRepository = new RoomRepository();

            GoToSpeakerDetailCommand = new Command<int>(GoToSpeakerDetail, _ => true);
        }

        private async void GoToSpeakerDetail(int speakerId)
        {
            //await Shell.Current.GoToAsync($"{RouteConfig.SpeakerDetailSingle}?{nameof(SpeakerDetailView.SpeakerId)}={speakerId}");
            await Shell.Current.GoToAsync($"{RouteConfig.SpeakerDetailHierarchy}?{nameof(SpeakerDetailView.SpeakerId)}={speakerId}");
        }

        public void LoadData(int sessionId)
        {
            Session = sessionRepository.GetByKey(sessionId);
            if (Session?.Speaker != null)
            {
                Speaker = speakerRepository.GetByKey(Session.Speaker.Id);
            }
            if (Session?.Room != null)
            {
                Room = roomRepository.GetByKey(Session.Room.Id);
            }
        }
    }
}