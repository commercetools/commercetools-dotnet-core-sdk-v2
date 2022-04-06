using System;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    public partial class DuplicateFieldError : IDuplicateFieldError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string Field { get; set; }

        public Object DuplicateValue { get; set; }
        public DuplicateFieldError()
        {
            this.Code = "DuplicateField";
        }
    }
}
