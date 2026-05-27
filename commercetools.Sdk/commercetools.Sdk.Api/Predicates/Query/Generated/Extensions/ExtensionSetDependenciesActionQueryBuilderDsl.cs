using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionSetDependenciesActionQueryBuilderDsl
    {
        public ExtensionSetDependenciesActionQueryBuilderDsl()
        {
        }

        public static ExtensionSetDependenciesActionQueryBuilderDsl Of()
        {
            return new ExtensionSetDependenciesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionSetDependenciesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionSetDependenciesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionSetDependenciesActionQueryBuilderDsl>(p, ExtensionSetDependenciesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionSetDependenciesActionQueryBuilderDsl> Dependencies(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionSetDependenciesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("dependencies"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionResourceIdentifierQueryBuilderDsl.Of())),
                ExtensionSetDependenciesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionSetDependenciesActionQueryBuilderDsl> Dependencies()
        {
            return new CollectionPredicateBuilder<ExtensionSetDependenciesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dependencies")),
                    p => new CombinationQueryPredicate<ExtensionSetDependenciesActionQueryBuilderDsl>(p, ExtensionSetDependenciesActionQueryBuilderDsl.Of));
        }

    }
}
