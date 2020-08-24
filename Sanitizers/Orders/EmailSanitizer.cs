using dotnettest.Abstractions;
using dotnettest.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.Sanitizers.Orders
{
    public class EmailSanitizer : IFieldSanitizer<Email>
    {
        public Email Sanitize(Email @object)
        {
            // Clean up just changing value for demo purposes.
            return new Email("Jorge");
        }
    }
}
