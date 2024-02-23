using System;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class ResourceDeletionError : IResourceDeletionError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public Object Resource { get; set; }
        public ResourceDeletionError()
        {
            this.Code = "ResourceDeletion";
        }
    }
}
