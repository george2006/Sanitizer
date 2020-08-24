using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.Abstractions
{
    public sealed class SanitizeAttribute : Attribute
    {
        public object DynamicInstance { get; private set; }
        public SanitizeAttribute(Type type, object[] args)
        {
            this.DynamicInstance = Activator.CreateInstance(type, args);
        }
    }
}
