using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridCar
{
    public static class Extensions
    {
        public static void AddBinding<TControl, TSourse>(this TControl target,
            Expression<Func<TControl, object>> targetProperty,
            TSourse sourse,
            Expression<Func<TSourse, object>> sourseProperty,
            ErrorProvider errorProvider = null)
            where TControl : Control
            where TSourse : class
        {
            var targetName = GetMemberName(targetProperty);
            var sourseName = GetMemberName(sourseProperty);
            target.DataBindings.Add(new Binding(targetName, sourse, sourseName,
                false,
                DataSourceUpdateMode.OnPropertyChanged));

            if (errorProvider != null)
            {
                var soursePropertyInfo = sourse.GetType().GetProperty(sourseName);
                var validators = soursePropertyInfo.GetCustomAttributes<ValidationAttribute>();
                if (validators?.Any() == true)
                {
                    target.Validating += (sender, args) =>
                    {
                        var context = new ValidationContext(sourse);
                        var results = new List<ValidationResult>();
                        errorProvider.SetError(target, string.Empty);
                        if (!Validator.TryValidateObject(sourse, context, results, validateAllProperties: true))
                        {
                            foreach (var error in results.Where(x => x.MemberNames.Contains(sourseName)))
                            {
                                errorProvider.SetError(target, error.ErrorMessage);
                            }
                        }
                    };
                }
            }
        }

        private static string GetMemberName<TItem, TMember>(Expression<Func<TItem, TMember>> targetMember)
        {
            if (targetMember.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }
            if (targetMember.Body is UnaryExpression unaryExpression)
            {
                var operand = unaryExpression.Operand as MemberExpression;
                return operand.Member.Name;
            }
            throw new ArgumentException();
        }
    }
}
