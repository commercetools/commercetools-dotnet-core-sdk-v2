using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateAttributeValueErrorQueryBuilderDsl
    {
        public DuplicateAttributeValueErrorQueryBuilderDsl()
        {
        }

        public static DuplicateAttributeValueErrorQueryBuilderDsl Of()
        {
            return new DuplicateAttributeValueErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateAttributeValueErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateAttributeValueErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateAttributeValueErrorQueryBuilderDsl>(p, DuplicateAttributeValueErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateAttributeValueErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateAttributeValueErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateAttributeValueErrorQueryBuilderDsl>(p, DuplicateAttributeValueErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicateAttributeValueErrorQueryBuilderDsl> Attribute(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateAttributeValueErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attribute"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                DuplicateAttributeValueErrorQueryBuilderDsl.Of);
        }


    }
}
