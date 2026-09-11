namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class CircularDependencyError : ICircularDependencyError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public CircularDependencyError()
        {
            this.Code = "CircularDependency";
        }
    }
}
