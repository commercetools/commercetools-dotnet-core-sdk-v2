using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceCustomFieldRemovedMessageQueryBuilderDsl
    {
        public ProductPriceCustomFieldRemovedMessageQueryBuilderDsl()
        {
        }

        public static ProductPriceCustomFieldRemovedMessageQueryBuilderDsl Of()
        {
            return new ProductPriceCustomFieldRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessageQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
