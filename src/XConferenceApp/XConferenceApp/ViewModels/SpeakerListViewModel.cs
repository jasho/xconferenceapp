using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using XConferenceApp.Models;
using XConferenceApp.Repositories;
using XConferenceApp.Resources;

namespace XConferenceApp.ViewModels
{
    public class SpeakerListViewModel : ViewModelBase
    {
        public List<SpeakerModel> Speakers { get; set; }
        public ICommand GoToDetailCommand { get; set; }

        public SpeakerListViewModel()
        {
            GoToDetailCommand = new Command<int>(GoToDetail, _ => true);

            var speakerRepository = new SpeakerRepository();
            Speakers = speakerRepository.GetAll();
        }

        private void GoToDetail(int speakerId)
        {
            Shell.Current.GoToAsync($"{RouteConfig.SpeakerDetailSingle}?SpeakerId={speakerId.ToString()}");
        }
    }
}