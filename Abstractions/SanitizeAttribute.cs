using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace dotnettest.Abstractions
{
    public sealed class SanitizeAttribute : Attribute
    {
        public object DynamicInstance { get; private set; }
        public SanitizeAttribute(Type type, object[] args)
        {
            ThrowIfNotSanitizer(type);
            this.DynamicInstance = Activator.CreateInstance(type, args);
        }
        private void ThrowIfNotSanitizer(Type type)
        {
            bool isAnImplementer = type
                .GetInterfaces()
                .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IFieldSanitizer<>));
            if (isAnImplementer == false)
                throw new InvalidOperationException($"{type.FullName} must implement {typeof(IFieldSanitizer<>).Name}");
        }
    }
}
