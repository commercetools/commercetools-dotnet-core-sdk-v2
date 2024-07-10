using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl
    {
        public BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
