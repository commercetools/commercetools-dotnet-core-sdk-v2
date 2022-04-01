using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IChannelRoleEnum> Roles { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IAddress Address { get; set; }

        IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        ICustomFields Custom { get; set; }

        IGeoJson GeoLocation { get; set; }
    }
}
