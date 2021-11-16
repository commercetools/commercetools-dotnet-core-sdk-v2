using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.OrderPatchImport))]
    public partial interface IOrderPatchImport 
    {
        string OrderNumber { get; set;}
        
        IOrderField Fields { get; set;}
    }
}
