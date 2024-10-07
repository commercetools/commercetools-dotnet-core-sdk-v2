using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.Channel))]
    public partial interface IChannel : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        IList<IChannelRoleEnum> Roles { get; set; }

        IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IAddress Address { get; set; }

        IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        ICustomFields Custom { get; set; }

        IGeoJson GeoLocation { get; set; }

    }
}
