using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customers
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customers.CustomerAddress))]
    public partial interface ICustomerAddress 
    {
        string Key { get; set;}
        
        string Title { get; set;}
        
        string Salutation { get; set;}
        
        string FirstName { get; set;}
        
        string LastName { get; set;}
        
        string StreetName { get; set;}
        
        string StreetNumber { get; set;}
        
        string AdditionalStreetInfo { get; set;}
        
        string PostalCode { get; set;}
        
        string City { get; set;}
        
        string Region { get; set;}
        
        string State { get; set;}
        
        string Country { get; set;}
        
        string Company { get; set;}
        
        string Department { get; set;}
        
        string Building { get; set;}
        
        string Apartment { get; set;}
        
        string POBox { get; set;}
        
        string Phone { get; set;}
        
        string Mobile { get; set;}
        
        string Email { get; set;}
        
        string Fax { get; set;}
        
        string AdditionalAddressInfo { get; set;}
        
        string ExternalId { get; set;}
    }
}
