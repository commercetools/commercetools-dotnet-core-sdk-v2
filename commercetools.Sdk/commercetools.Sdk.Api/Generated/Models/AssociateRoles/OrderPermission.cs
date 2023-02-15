using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    public enum OrderPermission
    {
        [Description("CreateMyOrdersFromMyCarts")]
        CreateMyOrdersFromMyCarts,

        [Description("CreateOrdersFromOthersCarts")]
        CreateOrdersFromOthersCarts,

        [Description("CreateMyOrdersFromMyQuotes")]
        CreateMyOrdersFromMyQuotes,

        [Description("CreateOrdersFromOthersQuotes")]
        CreateOrdersFromOthersQuotes,

        [Description("UpdateMyOrders")]
        UpdateMyOrders,

        [Description("UpdateOthersOrders")]
        UpdateOthersOrders,

        [Description("ViewMyOrders")]
        ViewMyOrders,

        [Description("ViewOthersOrders")]
        ViewOthersOrders
    }

    public class OrderPermissionWrapper : IOrderPermission
    {
        public string JsonName { get; internal set; }
        public OrderPermission? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IOrderPermission), "FindEnum")]
    public interface IOrderPermission : IJsonName, IEnumerable<char>
    {
        public static IOrderPermission CreateMyOrdersFromMyCarts = new OrderPermissionWrapper
        { Value = OrderPermission.CreateMyOrdersFromMyCarts, JsonName = "CreateMyOrdersFromMyCarts" };

        public static IOrderPermission CreateOrdersFromOthersCarts = new OrderPermissionWrapper
        { Value = OrderPermission.CreateOrdersFromOthersCarts, JsonName = "CreateOrdersFromOthersCarts" };

        public static IOrderPermission CreateMyOrdersFromMyQuotes = new OrderPermissionWrapper
        { Value = OrderPermission.CreateMyOrdersFromMyQuotes, JsonName = "CreateMyOrdersFromMyQuotes" };

        public static IOrderPermission CreateOrdersFromOthersQuotes = new OrderPermissionWrapper
        { Value = OrderPermission.CreateOrdersFromOthersQuotes, JsonName = "CreateOrdersFromOthersQuotes" };

        public static IOrderPermission UpdateMyOrders = new OrderPermissionWrapper
        { Value = OrderPermission.UpdateMyOrders, JsonName = "UpdateMyOrders" };

        public static IOrderPermission UpdateOthersOrders = new OrderPermissionWrapper
        { Value = OrderPermission.UpdateOthersOrders, JsonName = "UpdateOthersOrders" };

        public static IOrderPermission ViewMyOrders = new OrderPermissionWrapper
        { Value = OrderPermission.ViewMyOrders, JsonName = "ViewMyOrders" };

        public static IOrderPermission ViewOthersOrders = new OrderPermissionWrapper
        { Value = OrderPermission.ViewOthersOrders, JsonName = "ViewOthersOrders" };

        OrderPermission? Value { get; }

        static IOrderPermission[] Values()
        {
            return new[]
            {
                 CreateMyOrdersFromMyCarts ,
                 CreateOrdersFromOthersCarts ,
                 CreateMyOrdersFromMyQuotes ,
                 CreateOrdersFromOthersQuotes ,
                 UpdateMyOrders ,
                 UpdateOthersOrders ,
                 ViewMyOrders ,
                 ViewOthersOrders
             };
        }
        static IOrderPermission FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderPermissionWrapper() { JsonName = value };
        }
    }
}
