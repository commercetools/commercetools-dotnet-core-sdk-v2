using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionErrorQueryBuilderDsl
    {
        public ExtensionErrorQueryBuilderDsl()
        {
        }

        public static ExtensionErrorQueryBuilderDsl Of()
        {
            return new ExtensionErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionErrorQueryBuilderDsl>(p, ExtensionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionErrorQueryBuilderDsl>(p, ExtensionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string> ExtensionId()
        {
            return new ComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionId")),
            p => new CombinationQueryPredicate<ExtensionErrorQueryBuilderDsl>(p, ExtensionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string> ExtensionKey()
        {
            return new ComparisonPredicateBuilder<ExtensionErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionKey")),
            p => new CombinationQueryPredicate<ExtensionErrorQueryBuilderDsl>(p, ExtensionErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
