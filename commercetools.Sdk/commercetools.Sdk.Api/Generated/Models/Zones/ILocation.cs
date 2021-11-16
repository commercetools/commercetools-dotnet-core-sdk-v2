using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.Location))]
    public partial interface ILocation 
    {
        string Country { get; set;}
        
        string State { get; set;}
    }
}
