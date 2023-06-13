using System;
using System.Globalization;
using commercetools.Base.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    static class PredicateFormatter
    {
        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        private const string DefaultDateFormat = "yyyy'-'MM'-'dd";

        public static ConstantQueryPredicate Format(Boolean value) {
            return new ConstantQueryPredicate().Constant($"{value}");
        }

        public static ConstantQueryPredicate Format(Date value) {
            return new ConstantQueryPredicate()
                .Constant($"\"{value.ToString(DefaultDateFormat)}\"");
        }

        public static ConstantQueryPredicate Format(DateTime value) {
            return new ConstantQueryPredicate()
                .Constant($"\"{value.ToUniversalTime().ToString(DefaultDateTimeFormat)}\"");
        }

        public static ConstantQueryPredicate Format(double value) {
            return new ConstantQueryPredicate(value.ToString(CultureInfo.InvariantCulture));
        }

        public static ConstantQueryPredicate Format(decimal value) {
            return new ConstantQueryPredicate(value.ToString(CultureInfo.InvariantCulture));
        }

        public static ConstantQueryPredicate Format(long value) {
            return new ConstantQueryPredicate().Constant($"{value}");
        }

        public static ConstantQueryPredicate Format(string value) {
            return new ConstantQueryPredicate().Constant($"\"{value.Escape()}\"");
        }

        public static ConstantQueryPredicate Format(TimeSpan value) {
            return new ConstantQueryPredicate()
                .Constant($"\"{value:'HH':'mm'}\"");
        }

        /**
         * Internal: Escapes Strings like that (Scala notation) """query by name " test name"""
         * @param s the unescaped String
         * @return the escaped string
         */
        public static string Escape(this string s) {
            return s.Replace("\"", "\\\"");
        }
    }
}