using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.OrderField))]
    public partial interface IOrderField 
    {
        IReturnInfo AddReturnInfo { get; set;}
        
        IDeliveryParcel AddParcelToDelivery { get; set;}
        
        List<IDeliveryDraft> AddDeliveries { get; set;}
        
        IRemoveDeliveryDraft RemoveDelivery { get; set;}
        
        IRemoveParcelFromDeliveryDraft RemoveParcelFromDelivery { get; set;}
        
        IDeliveryAddressDraft SetDeliveryAddress { get; set;}
        
        IParcelMeasurementDraft SetParcelMeasurements { get; set;}
        
        IParcelTrackingData SetParcelTrackingData { get; set;}
        
        List<IParcelItems> SetParcelItems { get; set;}
    }
}
