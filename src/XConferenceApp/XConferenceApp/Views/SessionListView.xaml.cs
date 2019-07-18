using System;
using XConferenceApp.ViewModels;

namespace XConferenceApp.Views
{
    public partial class SessionListView
    {
        private readonly SessionListViewModel sessionListViewModel;

        public SessionListView()
        {
        }

        public SessionListView(DateTime date, int roomId)
        {
            InitializeComponent();

            sessionListViewModel = new SessionListViewModel();
            sessionListViewModel.LoadData(date, roomId);
            BindingContext = sessionListViewModel;
        }
    }
}