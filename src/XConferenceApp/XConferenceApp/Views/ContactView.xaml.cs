using XConferenceApp.ViewModels;

namespace XConferenceApp.Views
{
    public partial class ContactView
    {
        private readonly ContactViewModel contactViewModel;

        public ContactView()
        {
            InitializeComponent();
            contactViewModel = new ContactViewModel();
            BindingContext = contactViewModel;
        }
    }
}