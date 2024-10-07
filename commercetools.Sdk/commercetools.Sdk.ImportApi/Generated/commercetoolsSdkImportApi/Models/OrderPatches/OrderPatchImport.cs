

namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{

    public partial class OrderPatchImport : IOrderPatchImport
    {
        public string OrderNumber { get; set; }

        public IOrderField Fields { get; set; }
    }
}
