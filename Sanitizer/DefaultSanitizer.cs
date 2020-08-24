using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using dotnettest.Dto;
using dotnettest.Abstractions;

namespace dotnettest.Sanitizer
{
    public class DefaultSanitizer : ISanitizer
    {
        public TObject Sanitize<TObject>(TObject @object) where TObject : class
        {
            PropertyInfo[] props = typeof(OrderDto).GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    SanitizeAttribute authAttr = attr as SanitizeAttribute;
                    if (authAttr != null)
                    {
                        // Get sanitizer instance.
                        dynamic sanitizer = authAttr.DynamicInstance;
                        // Get property to act on.
                        dynamic propValue = prop.GetValue(@object);
                        // Sanitize.
                        dynamic result = sanitizer.Sanitize(propValue);
                        // Update property value.
                        prop.SetValue(@object, result);
                    }
                }
            }
            return @object;
        }

    }
}
