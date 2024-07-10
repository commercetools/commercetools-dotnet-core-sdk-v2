using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.Review))]
    public partial interface IReview : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        string UniquenessValue { get; set; }

        string Locale { get; set; }

        string AuthorName { get; set; }

        string Title { get; set; }

        string Text { get; set; }

        Object Target { get; set; }

        bool IncludedInStatistics { get; set; }

        int? Rating { get; set; }

        IStateReference State { get; set; }

        ICustomerReference Customer { get; set; }

        ICustomFields Custom { get; set; }

    }
}
