namespace commercetools.Api.Models.Errors
{
    public partial class InternalConstraintViolatedError : IInternalConstraintViolatedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public InternalConstraintViolatedError()
        {
            this.Code = "InternalConstraintViolated";
        }
    }
}
