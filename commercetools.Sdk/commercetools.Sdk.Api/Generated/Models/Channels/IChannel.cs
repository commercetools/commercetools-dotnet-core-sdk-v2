using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.Channel))]
    public partial interface IChannel : IBaseResource
    {
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
