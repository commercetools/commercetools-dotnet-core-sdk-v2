// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AssociateRoles
{

    public partial class AssociateRoleResourceIdentifierQueryBuilderDsl
    {
        public AssociateRoleResourceIdentifierQueryBuilderDsl()
        {
        }

        public static AssociateRoleResourceIdentifierQueryBuilderDsl Of()
        {
            return new AssociateRoleResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<AssociateRoleResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<AssociateRoleResourceIdentifierQueryBuilderDsl>(p, AssociateRoleResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRoleResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRoleResourceIdentifierQueryBuilderDsl>(p, AssociateRoleResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AssociateRoleResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AssociateRoleResourceIdentifierQueryBuilderDsl>(p, AssociateRoleResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
