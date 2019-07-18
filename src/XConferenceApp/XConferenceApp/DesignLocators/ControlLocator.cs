using Xamarin.Forms;

namespace XConferenceApp.DesignLocators
{
    public static class ControlLocator
    {
        private static FlyoutItem flyoutItem;

        public static FlyoutItem FlyoutItem = flyoutItem ?? (flyoutItem = new FlyoutItem());
    }
}