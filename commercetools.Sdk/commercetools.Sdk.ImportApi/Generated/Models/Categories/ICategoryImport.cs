using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Categories
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Categories.CategoryImport))]
    public partial interface ICategoryImport : IImportResource
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        ILocalizedString Description { get; set;}
        
        ICategoryKeyReference Parent { get; set;}
        
        string OrderHint { get; set;}
        
        string ExternalId { get; set;}
        
        ILocalizedString MetaTitle { get; set;}
        
        ILocalizedString MetaDescription { get; set;}
        
        ILocalizedString MetaKeywords { get; set;}
        
        List<IAsset> Assets { get; set;}
        
        ICustom Custom { get; set;}
    }
}
