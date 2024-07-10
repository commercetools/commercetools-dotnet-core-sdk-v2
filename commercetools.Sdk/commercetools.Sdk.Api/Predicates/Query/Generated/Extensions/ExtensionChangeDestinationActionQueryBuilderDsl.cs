using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionChangeDestinationActionQueryBuilderDsl
    {
        public ExtensionChangeDestinationActionQueryBuilderDsl()
        {
        }

        public static ExtensionChangeDestinationActionQueryBuilderDsl Of()
        {
            return new ExtensionChangeDestinationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionChangeDestinationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionChangeDestinationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionChangeDestinationActionQueryBuilderDsl>(p, ExtensionChangeDestinationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionChangeDestinationActionQueryBuilderDsl> Destination(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionChangeDestinationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("destination"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionDestinationQueryBuilderDsl.Of())),
                ExtensionChangeDestinationActionQueryBuilderDsl.Of);
        }


    }
}
