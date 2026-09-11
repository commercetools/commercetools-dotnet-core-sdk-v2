namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MissingDependencyError : IMissingDependencyError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public MissingDependencyError()
        {
            this.Code = "MissingDependency";
        }
    }
}
