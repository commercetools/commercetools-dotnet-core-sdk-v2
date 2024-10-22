

namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class NewMasterVariantAdditionNotAllowedError : INewMasterVariantAdditionNotAllowedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public NewMasterVariantAdditionNotAllowedError()
        {
            this.Code = "NewMasterVariantAdditionNotAllowed";
        }
    }
}
