using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeNestedTypeQueryBuilderDsl
    {
        public AttributeNestedTypeQueryBuilderDsl()
        {
        }

        public static AttributeNestedTypeQueryBuilderDsl Of()
        {
            return new AttributeNestedTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeNestedTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeNestedTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeNestedTypeQueryBuilderDsl>(p, AttributeNestedTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeNestedTypeQueryBuilderDsl> TypeReference(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeNestedTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("typeReference"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl.Of())),
                AttributeNestedTypeQueryBuilderDsl.Of);
        }


    }
}
