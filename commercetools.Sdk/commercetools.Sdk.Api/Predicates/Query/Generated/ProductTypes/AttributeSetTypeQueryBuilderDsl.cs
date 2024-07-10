using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeSetTypeQueryBuilderDsl
    {
        public AttributeSetTypeQueryBuilderDsl()
        {
        }

        public static AttributeSetTypeQueryBuilderDsl Of()
        {
            return new AttributeSetTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeSetTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeSetTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeSetTypeQueryBuilderDsl>(p, AttributeSetTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeSetTypeQueryBuilderDsl> ElementType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeSetTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("elementType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTypeQueryBuilderDsl.Of())),
                AttributeSetTypeQueryBuilderDsl.Of);
        }


    }
}
