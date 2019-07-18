using System.Linq;
using Xamarin.Forms;
using XConferenceApp.Models;
using XConferenceApp.Repositories;
using XConferenceApp.Views;

namespace XConferenceApp.Controls
{
    public class SpeakerSearchHandler : SearchHandler
    {
        private readonly SpeakerRepository speakerRepository;

        public SpeakerSearchHandler()
        {
            speakerRepository = new SpeakerRepository();
            ItemsSource = speakerRepository.GetAll();
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = speakerRepository.GetAll();
            }
            else
            {
                ItemsSource = speakerRepository.GetAll()
                    .Where(speaker => speaker.FullName.ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            if (item is SpeakerModel speaker)
            {
                Shell.Current.GoToAsync($"speakers/detail?{nameof(SpeakerDetailView.SpeakerId)}={speaker.Id.ToString()}");
            }
        }
    }
}