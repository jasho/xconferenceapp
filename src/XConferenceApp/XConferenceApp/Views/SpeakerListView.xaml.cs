using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XConferenceApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakerListView : ContentPage
    {
        public SpeakerListView()
        {
            InitializeComponent();
        }
    }
}