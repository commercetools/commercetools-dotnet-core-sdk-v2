using System;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewSetCustomFieldAction : IReviewSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public ReviewSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
