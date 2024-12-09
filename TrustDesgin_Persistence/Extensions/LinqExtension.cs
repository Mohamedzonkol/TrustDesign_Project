using System.Linq.Expressions;

namespace TrustDesgin_Persistence.Extensions
{
    public static class LinqExtension
    {
        public static IQueryable<T> WhereOperator<T>(this IQueryable<T> query, string column, object value, int whereOperator)
        {
            if (string.IsNullOrEmpty(column))
            {
                return query;
            }
            ParameterExpression? parameter = Expression.Parameter(query.ElementType, "p");
            MemberExpression member = null;
            foreach (var property in column.Split('.'))
            {
                member = Expression.Property(member ?? (parameter as Expression), property);
            }

            var filter = Expression.Constant(Convert.ChangeType(value, member?.Type ?? null));
            Expression? condition = null;
            LambdaExpression? lambda = null;
            switch (whereOperator)
            {
                case 1:
                    condition = Expression.Equal(member, filter);
                    lambda = Expression.Lambda(condition, parameter);
                    break;
                case 2:
                    condition = Expression.NotEqual(member, filter);
                    lambda = Expression.Lambda(condition, parameter);
                    break;
                case 3:
                    condition = Expression.Call(member, typeof(string).GetMethod("Contains", new[] { typeof(string) }), Expression.Constant(value));
                    lambda = Expression.Lambda(condition, parameter);
                    break;
                case 4:
                    condition = Expression.Call(member, typeof(string).GetMethod("StartsWith", new[] { typeof(string) }), Expression.Constant(value));
                    lambda = Expression.Lambda(condition, parameter);
                    break;
            }
            var result = Expression.Call(typeof(Queryable), "Where", [query.ElementType], query.Expression, lambda);
            return query.Provider.CreateQuery<T>(result);
        }
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> query, string sortColumn, string direction)
        {
            string methodName =
                $"OrderBy{(direction.Equals("asc", StringComparison.CurrentCultureIgnoreCase) ? "" : "descending")}";
            ParameterExpression? parameter = Expression.Parameter(query.ElementType, "p");
            MemberExpression member = null;
            foreach (var property in sortColumn.Split('.'))
            {
                member = Expression.Property(member ?? (parameter as Expression), property);
            }
            LambdaExpression? orderByLambda = Expression.Lambda(member, parameter);
            MethodCallExpression result = Expression.Call(typeof(Queryable), methodName, new[] { query.ElementType, member.Type }, query.Expression, Expression.Quote(orderByLambda));
            return query.Provider.CreateQuery<T>(result);
        }
    }
}
