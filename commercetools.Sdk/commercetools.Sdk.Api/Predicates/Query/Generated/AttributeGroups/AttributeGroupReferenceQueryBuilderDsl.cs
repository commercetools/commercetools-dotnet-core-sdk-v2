using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupReferenceQueryBuilderDsl
    {
        public AttributeGroupReferenceQueryBuilderDsl()
        {
        }

        public static AttributeGroupReferenceQueryBuilderDsl Of()
        {
            return new AttributeGroupReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<AttributeGroupReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<AttributeGroupReferenceQueryBuilderDsl>(p, AttributeGroupReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AttributeGroupReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AttributeGroupReferenceQueryBuilderDsl>(p, AttributeGroupReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AttributeGroups.AttributeGroupQueryBuilderDsl.Of())),
                AttributeGroupReferenceQueryBuilderDsl.Of);
        }


    }
}
