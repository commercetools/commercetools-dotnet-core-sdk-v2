using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLExtensionUpdateActionsFailedError : IGraphQLExtensionUpdateActionsFailedError
    {
        public string Code { get; set; }

        public ILocalizedString LocalizedMessage { get; set; }

        public Object ExtensionExtraInfo { get; set; }

        public IList<IExtensionError> ExtensionErrors { get; set; }

        public IEnumerable<IExtensionError> ExtensionErrorsEnumerable { set => ExtensionErrors = value.ToList(); }
        public GraphQLExtensionUpdateActionsFailedError()
        {
            this.Code = "ExtensionUpdateActionsFailed";
        }
    }
}
