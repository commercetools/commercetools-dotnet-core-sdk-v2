using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupUpdateQueryBuilderDsl
    {
        public AttributeGroupUpdateQueryBuilderDsl()
        {
        }

        public static AttributeGroupUpdateQueryBuilderDsl Of()
        {
            return new AttributeGroupUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AttributeGroupUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AttributeGroupUpdateQueryBuilderDsl>(p, AttributeGroupUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupUpdateActionQueryBuilderDsl.Of())),
                AttributeGroupUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeGroupUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<AttributeGroupUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<AttributeGroupUpdateQueryBuilderDsl>(p, AttributeGroupUpdateQueryBuilderDsl.Of));
        }

    }
}
