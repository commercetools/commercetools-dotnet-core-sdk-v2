using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Carts
{
   public enum ProductPublishScope
   {
       [Description("All")]
       All,
       
       [Description("Prices")]
       Prices
   }
   public class ProductPublishScopeWrapper : IProductPublishScope
   {
       public string JsonName { get; internal set; }
       public ProductPublishScope? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(IProductPublishScope), "FindEnum")]
   public interface IProductPublishScope : IJsonName
   {
        public static IProductPublishScope All = new ProductPublishScopeWrapper
         {Value = ProductPublishScope.All, JsonName = "All"}; 
       
        public static IProductPublishScope Prices = new ProductPublishScopeWrapper
         {Value = ProductPublishScope.Prices, JsonName = "Prices"}; 
       
        ProductPublishScope? Value { get; }
        
        static IProductPublishScope[] Values()
        {
           return new[]
           {
                All ,
                Prices 
           };
        }
        static IProductPublishScope FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductPublishScopeWrapper() {JsonName = value};
        }
   }
}
