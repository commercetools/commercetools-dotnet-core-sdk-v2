using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewSetCustomTypeAction : IReviewSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ReviewSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
