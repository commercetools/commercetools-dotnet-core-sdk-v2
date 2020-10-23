using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Reviews;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Channels
{
    public interface IChannel : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        List<string> Roles { get; set;}
        
        List<ChannelRoleEnum> RolesAsEnum { get; }
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        IAddress Address { get; set;}
        
        IReviewRatingStatistics ReviewRatingStatistics { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IGeoJson GeoLocation { get; set;}
    }
}
