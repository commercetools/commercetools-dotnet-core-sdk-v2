using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionSetTimeoutInMsActionQueryBuilderDsl
    {
        public ExtensionSetTimeoutInMsActionQueryBuilderDsl()
        {
        }

        public static ExtensionSetTimeoutInMsActionQueryBuilderDsl Of()
        {
            return new ExtensionSetTimeoutInMsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionSetTimeoutInMsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionSetTimeoutInMsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionSetTimeoutInMsActionQueryBuilderDsl>(p, ExtensionSetTimeoutInMsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionSetTimeoutInMsActionQueryBuilderDsl, long> TimeoutInMs()
        {
            return new ComparisonPredicateBuilder<ExtensionSetTimeoutInMsActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timeoutInMs")),
            p => new CombinationQueryPredicate<ExtensionSetTimeoutInMsActionQueryBuilderDsl>(p, ExtensionSetTimeoutInMsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
