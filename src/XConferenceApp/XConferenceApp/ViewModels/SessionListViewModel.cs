using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using XConferenceApp.Models;
using XConferenceApp.Repositories;
using XConferenceApp.Resources;
using XConferenceApp.Views;

namespace XConferenceApp.ViewModels
{
    public class SessionListViewModel : ViewModelBase
    {
        private readonly RoomRepository roomRepository;
        private readonly SessionRepository sessionRepository;

        public RoomModel Room { get; set; }
        public List<SessionModel> Sessions { get; set; }

        public ICommand GoToDetailCommand { get; set; }

        public SessionListViewModel()
        {
            roomRepository = new RoomRepository();
            sessionRepository = new SessionRepository();
            GoToDetailCommand = new Command<int>(GoToDetail, _ => true);
        }

        public void LoadData(DateTime date, int roomId)
        {
            Room = roomRepository.GetByKey(roomId);
            Sessions = sessionRepository.GetByDateAndRoomId(date, roomId);
        }

        private void GoToDetail(int sessionId)
        {
            Shell.Current.GoToAsync($"{RouteConfig.SessionDetailSingle}?{nameof(SessionDetailView.SessionId)}={sessionId}");
        }
    }
}