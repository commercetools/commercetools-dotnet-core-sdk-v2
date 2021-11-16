using commercetools.Api.Models.Common;
using System;


namespace commercetools.Api.Models.Errors
{
    public partial class ExtensionBadResponseError : IExtensionBadResponseError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public ILocalizedString LocalizedMessage { get; set; }

        public Object ExtensionExtraInfo { get; set; }

        public IErrorByExtension ErrorByExtension { get; set; }
        public ExtensionBadResponseError()
        {
            this.Code = "ExtensionBadResponse";
        }
    }
}
