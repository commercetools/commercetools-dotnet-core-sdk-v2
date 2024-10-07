using System;

namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class ResourceUpdateError : IResourceUpdateError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public Object Resource { get; set; }
        public ResourceUpdateError()
        {
            this.Code = "ResourceUpdate";
        }
    }
}
