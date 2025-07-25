namespace commercetools.Sdk.Api.Models.Types;

public partial interface ICustomFields
{
    ICustomFieldsDraft ToDraft()
    {
        return new CustomFieldsDraft()
        {
            Type = new TypeResourceIdentifier() { Id = this.Type.Id },
            Fields = this.Fields
        };
    }
}