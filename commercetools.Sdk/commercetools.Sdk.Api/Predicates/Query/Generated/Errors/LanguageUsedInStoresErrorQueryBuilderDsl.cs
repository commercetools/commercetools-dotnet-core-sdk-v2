using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class LanguageUsedInStoresErrorQueryBuilderDsl
    {
        public LanguageUsedInStoresErrorQueryBuilderDsl()
        {
        }

        public static LanguageUsedInStoresErrorQueryBuilderDsl Of()
        {
            return new LanguageUsedInStoresErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LanguageUsedInStoresErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<LanguageUsedInStoresErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<LanguageUsedInStoresErrorQueryBuilderDsl>(p, LanguageUsedInStoresErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LanguageUsedInStoresErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<LanguageUsedInStoresErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<LanguageUsedInStoresErrorQueryBuilderDsl>(p, LanguageUsedInStoresErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
