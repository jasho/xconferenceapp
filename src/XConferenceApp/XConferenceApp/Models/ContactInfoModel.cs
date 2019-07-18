namespace XConferenceApp.Models
{
    public class ContactInfoModel : ModelBase<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
    }
}