using commercetools.ImportApi.Models.Customfields;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Common
{
    public partial class Asset : IAsset
    {
        public string Key { get; set;}
        
        public List<IAssetSource> Sources { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public List<string> Tags { get; set;}
        
        public ICustom Custom { get; set;}
    }
}
