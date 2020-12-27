using System;
using System.Windows.Markup;

namespace WhereIsMyMoney.Enums
{
    public class BindingEnumsExtension : MarkupExtension
    {
        public Type EnumType { get; private set; }
        public BindingEnumsExtension(Type enumtype)
        {
            EnumType = enumtype;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
