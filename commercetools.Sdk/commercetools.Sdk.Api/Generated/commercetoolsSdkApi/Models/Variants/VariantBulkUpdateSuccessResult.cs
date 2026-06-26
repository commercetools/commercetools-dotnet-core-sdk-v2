

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantBulkUpdateSuccessResult : IVariantBulkUpdateSuccessResult
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public string Status { get; set; }

        public IVariantBulkUpdateResource Resource { get; set; }
        public VariantBulkUpdateSuccessResult()
        {
            this.Status = "Success";
        }
    }
}
