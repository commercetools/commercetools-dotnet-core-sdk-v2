using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    public enum QuoteRequestPermission
    {
        [Description("CreateMyQuoteRequestsFromMyCarts")]
        CreateMyQuoteRequestsFromMyCarts,

        [Description("CreateQuoteRequestsFromOthersCarts")]
        CreateQuoteRequestsFromOthersCarts,

        [Description("UpdateMyQuoteRequests")]
        UpdateMyQuoteRequests,

        [Description("UpdateOthersQuoteRequests")]
        UpdateOthersQuoteRequests,

        [Description("ViewMyQuoteRequests")]
        ViewMyQuoteRequests,

        [Description("ViewOthersQuoteRequests")]
        ViewOthersQuoteRequests
    }

    public class QuoteRequestPermissionWrapper : IQuoteRequestPermission
    {
        public string JsonName { get; internal set; }
        public QuoteRequestPermission? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IQuoteRequestPermission), "FindEnum")]
    public interface IQuoteRequestPermission : IJsonName, IEnumerable<char>
    {
        public static IQuoteRequestPermission CreateMyQuoteRequestsFromMyCarts = new QuoteRequestPermissionWrapper
        { Value = QuoteRequestPermission.CreateMyQuoteRequestsFromMyCarts, JsonName = "CreateMyQuoteRequestsFromMyCarts" };

        public static IQuoteRequestPermission CreateQuoteRequestsFromOthersCarts = new QuoteRequestPermissionWrapper
        { Value = QuoteRequestPermission.CreateQuoteRequestsFromOthersCarts, JsonName = "CreateQuoteRequestsFromOthersCarts" };

        public static IQuoteRequestPermission UpdateMyQuoteRequests = new QuoteRequestPermissionWrapper
        { Value = QuoteRequestPermission.UpdateMyQuoteRequests, JsonName = "UpdateMyQuoteRequests" };

        public static IQuoteRequestPermission UpdateOthersQuoteRequests = new QuoteRequestPermissionWrapper
        { Value = QuoteRequestPermission.UpdateOthersQuoteRequests, JsonName = "UpdateOthersQuoteRequests" };

        public static IQuoteRequestPermission ViewMyQuoteRequests = new QuoteRequestPermissionWrapper
        { Value = QuoteRequestPermission.ViewMyQuoteRequests, JsonName = "ViewMyQuoteRequests" };

        public static IQuoteRequestPermission ViewOthersQuoteRequests = new QuoteRequestPermissionWrapper
        { Value = QuoteRequestPermission.ViewOthersQuoteRequests, JsonName = "ViewOthersQuoteRequests" };

        QuoteRequestPermission? Value { get; }

        static IQuoteRequestPermission[] Values()
        {
            return new[]
            {
                 CreateMyQuoteRequestsFromMyCarts ,
                 CreateQuoteRequestsFromOthersCarts ,
                 UpdateMyQuoteRequests ,
                 UpdateOthersQuoteRequests ,
                 ViewMyQuoteRequests ,
                 ViewOthersQuoteRequests
             };
        }
        static IQuoteRequestPermission FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new QuoteRequestPermissionWrapper() { JsonName = value };
        }
    }
}
