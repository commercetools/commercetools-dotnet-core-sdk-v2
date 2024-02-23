namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class OverCapacityError : IOverCapacityError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public OverCapacityError()
        {
            this.Code = "OverCapacity";
        }
    }
}
