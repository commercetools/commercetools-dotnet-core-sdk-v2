using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class KeyReferenceQueryBuilderDsl
    {
        public KeyReferenceQueryBuilderDsl()
        {
        }

        public static KeyReferenceQueryBuilderDsl Of()
        {
            return new KeyReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<KeyReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<KeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<KeyReferenceQueryBuilderDsl>(p, KeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<KeyReferenceQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<KeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<KeyReferenceQueryBuilderDsl>(p, KeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<KeyReferenceQueryBuilderDsl> AsAssociateRole(
            Func<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<KeyReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.AssociateRoles.AssociateRoleKeyReferenceQueryBuilderDsl.Of()),
                KeyReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<KeyReferenceQueryBuilderDsl> AsBusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<KeyReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of()),
                KeyReferenceQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<KeyReferenceQueryBuilderDsl> AsStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<KeyReferenceQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of()),
                KeyReferenceQueryBuilderDsl.Of);
        }
    }
}
