using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionUpdateQueryBuilderDsl
    {
        public ExtensionUpdateQueryBuilderDsl()
        {
        }

        public static ExtensionUpdateQueryBuilderDsl Of()
        {
            return new ExtensionUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ExtensionUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ExtensionUpdateQueryBuilderDsl>(p, ExtensionUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionUpdateActionQueryBuilderDsl.Of())),
                ExtensionUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ExtensionUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ExtensionUpdateQueryBuilderDsl>(p, ExtensionUpdateQueryBuilderDsl.Of));
        }

    }
}
