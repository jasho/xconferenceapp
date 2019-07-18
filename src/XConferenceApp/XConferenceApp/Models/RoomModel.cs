using System.Drawing;

namespace XConferenceApp.Models
{
    public class RoomModel : ModelBase<int>
    {
        public string Name { get; set; }
        public Color AccentColor { get; set; }
    }
}