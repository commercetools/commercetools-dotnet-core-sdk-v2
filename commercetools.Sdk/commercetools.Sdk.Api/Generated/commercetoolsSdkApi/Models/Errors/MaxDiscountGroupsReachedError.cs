namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MaxDiscountGroupsReachedError : IMaxDiscountGroupsReachedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MaxDiscountGroupsReachedError()
        {
            this.Code = "MaxDiscountGroupsReached";
        }
    }
}
