using Umbraco.Core.Composing;
using Umbraco.Core.Services.Implement;

namespace InfoCaster.Umbraco.UrlTracker
{
    internal class RegisterUrlTrackerEvents : IComponent
    {
        public void Initialize()
        {
            ContentService.Publishing += ContentService_Publishing;
        }

        private void ContentService_Publishing(global::Umbraco.Core.Services.IContentService sender, global::Umbraco.Core.Events.ContentPublishingEventArgs e)
        {
            var x = 1;

        }

        public void Terminate()
        {
            throw new System.NotImplementedException();
        }
    }
}