using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Carts
{
   public enum CartState
   {
       [Description("Active")]
       Active,
       
       [Description("Merged")]
       Merged,
       
       [Description("Ordered")]
       Ordered
   }
   public class CartStateWrapper : ICartState
   {
       public string JsonName { get; internal set; }
       public CartState? Value { get; internal set; }
   }
   [EnumInterfaceCreator(typeof(ICartState), "FindEnum")]
   public interface ICartState : IJsonName
   {
        public static ICartState Active = new CartStateWrapper
         {Value = CartState.Active, JsonName = "Active"}; 
       
        public static ICartState Merged = new CartStateWrapper
         {Value = CartState.Merged, JsonName = "Merged"}; 
       
        public static ICartState Ordered = new CartStateWrapper
         {Value = CartState.Ordered, JsonName = "Ordered"}; 
       
        CartState? Value { get; }
        
        static ICartState[] Values()
        {
           return new[]
           {
                Active ,
                Merged ,
                Ordered 
           };
        }
        static ICartState FindEnum(string value)
        {
           return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new CartStateWrapper() {JsonName = value};
        }
   }
}
