using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionBadResponseError : IExtensionBadResponseError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public ILocalizedString LocalizedMessage { get; set; }

        public Object ExtensionExtraInfo { get; set; }

        public List<IExtensionError> ExtensionErrors { get; set; }

        public string ExtensionBody { get; set; }

        public int? ExtensionStatusCode { get; set; }

        public string ExtensionId { get; set; }

        public string ExtensionKey { get; set; }
        public ExtensionBadResponseError()
        {
            this.Code = "ExtensionBadResponse";
        }
    }
}
