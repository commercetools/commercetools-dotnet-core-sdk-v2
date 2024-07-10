using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl
    {
        public BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string> OldValue()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldValue")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
