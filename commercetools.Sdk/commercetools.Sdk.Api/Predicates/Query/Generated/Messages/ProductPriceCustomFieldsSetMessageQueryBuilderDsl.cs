using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceCustomFieldsSetMessageQueryBuilderDsl
    {
        public ProductPriceCustomFieldsSetMessageQueryBuilderDsl()
        {
        }

        public static ProductPriceCustomFieldsSetMessageQueryBuilderDsl Of()
        {
            return new ProductPriceCustomFieldsSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl> CustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customField"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldsSetMessageQueryBuilderDsl>(p, ProductPriceCustomFieldsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
