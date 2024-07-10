using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupPagedQueryResponseQueryBuilderDsl
    {
        public AttributeGroupPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static AttributeGroupPagedQueryResponseQueryBuilderDsl Of()
        {
            return new AttributeGroupPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl>(p, AttributeGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl>(p, AttributeGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl>(p, AttributeGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl>(p, AttributeGroupPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl.Of())),
                AttributeGroupPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<AttributeGroupPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<AttributeGroupPagedQueryResponseQueryBuilderDsl>(p, AttributeGroupPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
