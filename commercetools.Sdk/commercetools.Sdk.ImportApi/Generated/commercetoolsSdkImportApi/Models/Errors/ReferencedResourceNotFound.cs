using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class ReferencedResourceNotFound : IReferencedResourceNotFound
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IReferenceType TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ReferencedResourceNotFound()
        {
            this.Code = "ReferencedResourceNotFound";
        }
    }
}
