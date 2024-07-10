using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateAttributeValuesErrorQueryBuilderDsl
    {
        public DuplicateAttributeValuesErrorQueryBuilderDsl()
        {
        }

        public static DuplicateAttributeValuesErrorQueryBuilderDsl Of()
        {
            return new DuplicateAttributeValuesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateAttributeValuesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateAttributeValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateAttributeValuesErrorQueryBuilderDsl>(p, DuplicateAttributeValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateAttributeValuesErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateAttributeValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateAttributeValuesErrorQueryBuilderDsl>(p, DuplicateAttributeValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicateAttributeValuesErrorQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateAttributeValuesErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                DuplicateAttributeValuesErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DuplicateAttributeValuesErrorQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<DuplicateAttributeValuesErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<DuplicateAttributeValuesErrorQueryBuilderDsl>(p, DuplicateAttributeValuesErrorQueryBuilderDsl.Of));
        }

    }
}
