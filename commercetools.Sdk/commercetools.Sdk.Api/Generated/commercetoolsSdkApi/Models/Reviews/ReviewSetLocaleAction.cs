

namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewSetLocaleAction : IReviewSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public ReviewSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
