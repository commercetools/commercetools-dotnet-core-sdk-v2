namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewSetKeyAction : IReviewSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public ReviewSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
