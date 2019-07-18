using System.Windows.Input;
using XConferenceApp.Models;

namespace XConferenceApp.ViewModels
{
    public class ContactViewModel : ViewModelBase
    {
        public ContactInfoModel ContactInfo { get; set; } = new ContactInfoModel();
        public string ContactInfoSentMessage { get; set; }

        public ICommand SendContactInfoCommand { get; set; }

        public ContactViewModel()
        {
            SendContactInfoCommand = new Command(SendContactInfo, CanSendCommandInfo, ContactInfo);
        }

        private bool CanSendCommandInfo()
        {
            return !string.IsNullOrWhiteSpace(ContactInfo.Name)
                && !string.IsNullOrWhiteSpace(ContactInfo.Email)
                && !string.IsNullOrWhiteSpace(ContactInfo.Text);
        }

        private void SendContactInfo()
        {
            ContactInfoSentMessage = "Informace úspěšně odeslány";
        }
    }
}