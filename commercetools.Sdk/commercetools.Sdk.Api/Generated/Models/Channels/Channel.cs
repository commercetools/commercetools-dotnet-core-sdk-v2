using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class Channel : IChannel
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public IList<IChannelRoleEnum> Roles { get; set; }
        public IEnumerable<IChannelRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }


        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IAddress Address { get; set; }

        public IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        public ICustomFields Custom { get; set; }

        public IGeoJson GeoLocation { get; set; }
    }
}
