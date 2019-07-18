using XConferenceApp.Models;

namespace XConferenceApp.DesignLocators
{
    public static class ModelLocator
    {
        private static ContactInfoModel contactInfoModel;
        private static CountryModel countryModel;
        private static RoomModel roomModel;
        private static SessionModel sessionModel;
        private static SpeakerModel speakerModel;

        public static ContactInfoModel ContactInfoModel => contactInfoModel ?? (contactInfoModel = new ContactInfoModel());
        public static CountryModel CountryModel => countryModel ?? (countryModel = new CountryModel());
        public static RoomModel RoomModel => roomModel ?? (roomModel = new RoomModel());
        public static SessionModel SessionModel => sessionModel ?? (sessionModel = new SessionModel());
        public static SpeakerModel SpeakerModel => speakerModel ?? (speakerModel = new SpeakerModel());
    }
}