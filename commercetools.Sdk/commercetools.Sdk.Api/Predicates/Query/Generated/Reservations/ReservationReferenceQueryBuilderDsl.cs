using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reservations
{

    public partial class ReservationReferenceQueryBuilderDsl
    {
        public ReservationReferenceQueryBuilderDsl()
        {
        }

        public static ReservationReferenceQueryBuilderDsl Of()
        {
            return new ReservationReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReservationReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ReservationReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ReservationReferenceQueryBuilderDsl>(p, ReservationReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReservationReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReservationReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReservationReferenceQueryBuilderDsl>(p, ReservationReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReservationReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Reservations.ReservationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reservations.ReservationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReservationReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reservations.ReservationQueryBuilderDsl.Of())),
                ReservationReferenceQueryBuilderDsl.Of);
        }


    }
}
