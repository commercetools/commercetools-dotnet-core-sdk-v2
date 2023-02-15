using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    public enum QuotePermission
    {
        [Description("AcceptMyQuotes")]
        AcceptMyQuotes,

        [Description("AcceptOthersQuotes")]
        AcceptOthersQuotes,

        [Description("DeclineMyQuotes")]
        DeclineMyQuotes,

        [Description("DeclineOthersQuotes")]
        DeclineOthersQuotes,

        [Description("RenegotiateMyQuotes")]
        RenegotiateMyQuotes,

        [Description("RenegotiateOthersQuotes")]
        RenegotiateOthersQuotes,

        [Description("ViewMyQuotes")]
        ViewMyQuotes,

        [Description("ViewOthersQuotes")]
        ViewOthersQuotes
    }

    public class QuotePermissionWrapper : IQuotePermission
    {
        public string JsonName { get; internal set; }
        public QuotePermission? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IQuotePermission), "FindEnum")]
    public interface IQuotePermission : IJsonName, IEnumerable<char>
    {
        public static IQuotePermission AcceptMyQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.AcceptMyQuotes, JsonName = "AcceptMyQuotes" };

        public static IQuotePermission AcceptOthersQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.AcceptOthersQuotes, JsonName = "AcceptOthersQuotes" };

        public static IQuotePermission DeclineMyQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.DeclineMyQuotes, JsonName = "DeclineMyQuotes" };

        public static IQuotePermission DeclineOthersQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.DeclineOthersQuotes, JsonName = "DeclineOthersQuotes" };

        public static IQuotePermission RenegotiateMyQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.RenegotiateMyQuotes, JsonName = "RenegotiateMyQuotes" };

        public static IQuotePermission RenegotiateOthersQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.RenegotiateOthersQuotes, JsonName = "RenegotiateOthersQuotes" };

        public static IQuotePermission ViewMyQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.ViewMyQuotes, JsonName = "ViewMyQuotes" };

        public static IQuotePermission ViewOthersQuotes = new QuotePermissionWrapper
        { Value = QuotePermission.ViewOthersQuotes, JsonName = "ViewOthersQuotes" };

        QuotePermission? Value { get; }

        static IQuotePermission[] Values()
        {
            return new[]
            {
                 AcceptMyQuotes ,
                 AcceptOthersQuotes ,
                 DeclineMyQuotes ,
                 DeclineOthersQuotes ,
                 RenegotiateMyQuotes ,
                 RenegotiateOthersQuotes ,
                 ViewMyQuotes ,
                 ViewOthersQuotes
             };
        }
        static IQuotePermission FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new QuotePermissionWrapper() { JsonName = value };
        }
    }
}
