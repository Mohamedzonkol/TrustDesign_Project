using System.Linq.Expressions;

namespace TrustDesgin_Persistence.Extensions
{
    public static class LinqExtension
    {
        public static IQueryable<T> Where<T>(this IQueryable<T> query, string column, object value, string whereOperator)
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
            }
        }
    }
}
