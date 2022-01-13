namespace commercetools.Api.Models.Errors
{
    public partial class AnonymousIdAlreadyInUseError : IAnonymousIdAlreadyInUseError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public AnonymousIdAlreadyInUseError()
        {
            this.Code = "AnonymousIdAlreadyInUse";
        }
    }
}
