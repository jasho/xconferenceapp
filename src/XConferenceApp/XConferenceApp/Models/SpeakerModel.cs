using PropertyChanged;
using XConferenceApp.Models.Interfaces;

namespace XConferenceApp.Models
{
    public class SpeakerModel : ModelBase<int>, IOrderable
    {
        public int Order { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        [DependsOn(nameof(FirstName), nameof(LastName))]
        public string FullName
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }
        }

        public string DescriptionShort { get; set; }
        public string DescriptionLong { get; set; }
        public string PhotoUrl { get; set; }
    }
}