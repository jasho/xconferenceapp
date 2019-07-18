using XConferenceApp.ViewModels;

namespace XConferenceApp.DesignLocators
{
    public static class ViewModelLocator
    {
        private static ContactViewModel contactViewModel;
        private static SessionDetailViewModel sessionDetailViewModel;
        private static SessionListViewModel sessionListViewModel;
        private static SpeakerDetailViewModel speakerDetailViewModel;
        private static SpeakerListViewModel speakerListViewModel;

        public static ContactViewModel ContactViewModel => contactViewModel ?? (contactViewModel = new ContactViewModel());

        public static SessionDetailViewModel SessionDetailViewModel => sessionDetailViewModel ?? (sessionDetailViewModel = new SessionDetailViewModel());
        public static SessionListViewModel SessionListViewModel => sessionListViewModel ?? (sessionListViewModel = new SessionListViewModel());

        public static SpeakerDetailViewModel SpeakerDetailViewModel => speakerDetailViewModel ?? (speakerDetailViewModel = new SpeakerDetailViewModel());
        public static SpeakerListViewModel SpeakerListViewModel => speakerListViewModel ?? (speakerListViewModel = new SpeakerListViewModel());
    }
}