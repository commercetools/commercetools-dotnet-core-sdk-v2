using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeUpdateQueryBuilderDsl
    {
        public TypeUpdateQueryBuilderDsl()
        {
        }

        public static TypeUpdateQueryBuilderDsl Of()
        {
            return new TypeUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<TypeUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<TypeUpdateQueryBuilderDsl>(p, TypeUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeUpdateActionQueryBuilderDsl.Of())),
                TypeUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TypeUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<TypeUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<TypeUpdateQueryBuilderDsl>(p, TypeUpdateQueryBuilderDsl.Of));
        }

    }
}
