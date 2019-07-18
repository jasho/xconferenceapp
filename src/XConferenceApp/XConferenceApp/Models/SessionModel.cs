using System;

namespace XConferenceApp.Models
{
    public class SessionModel : ModelBase<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public SpeakerModel Speaker { get; set; }
        public RoomModel Room { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}