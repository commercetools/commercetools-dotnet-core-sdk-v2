using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomFieldAddedMessageQueryBuilderDsl
    {
        public BusinessUnitCustomFieldAddedMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomFieldAddedMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomFieldAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
