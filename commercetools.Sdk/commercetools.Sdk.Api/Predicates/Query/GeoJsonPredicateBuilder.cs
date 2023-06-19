
using System;
using System.Collections.Generic;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class GeoJsonPredicateBuilder<T>
    {
        private BinaryQueryPredicate predicate;

        private Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn;

        public GeoJsonPredicateBuilder(BinaryQueryPredicate predicate,
         Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn)
        {
            this.predicate = predicate;
            this.combinationFn = combinationFn;
        }

        public CombinationQueryPredicate<T> WithinCircle(decimal longitude, decimal latitude,
        long distance)
        {
            IEnumerable<IQueryPredicate> p = new[]{ ConstantQueryPredicate.Of().Constant(longitude.ToString()),
                ConstantQueryPredicate.Of().Constant(latitude.ToString()),
                ConstantQueryPredicate.Of().Constant(distance.ToString())};
            return combinationFn.Invoke(predicate.Operator(PredicateOperator.Within.ToString())
                .Right(ContainerQueryPredicate.Of()
                    .Parent(ConstantQueryPredicate.Of().Constant("circle"))
                    .Inner(CollectionQueryPredicate.Of().Predicates(p))));
        }
    }
}


