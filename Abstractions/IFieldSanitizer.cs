using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.Abstractions
{
    public interface IFieldSanitizer<TObject> where TObject : class
    {
        TObject Sanitize(TObject @object);
    }
}
