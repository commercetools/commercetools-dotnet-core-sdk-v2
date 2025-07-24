using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Errors.GraphQLErrorObject))]
    [SubTypeDiscriminator("TooManyRequests", typeof(commercetools.Sdk.HistoryApi.Models.Errors.GraphQLTooManyRequestsError))]
    public partial interface IGraphQLErrorObject
    {
        string Code { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Errors.GraphQLTooManyRequestsError TooManyRequests(Action<commercetools.Sdk.HistoryApi.Models.Errors.GraphQLTooManyRequestsError> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Errors.GraphQLTooManyRequestsError();
            init?.Invoke(t);
            return t;
        }
    }
}
