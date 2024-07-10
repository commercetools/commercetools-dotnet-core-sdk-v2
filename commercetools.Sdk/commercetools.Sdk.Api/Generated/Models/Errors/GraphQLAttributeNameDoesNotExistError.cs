using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLAttributeNameDoesNotExistError : IGraphQLAttributeNameDoesNotExistError
    {
        public string Code { get; set; }

        public string InvalidAttributeName { get; set; }
        public GraphQLAttributeNameDoesNotExistError()
        {
            this.Code = "AttributeNameDoesNotExist";
        }
    }
}
