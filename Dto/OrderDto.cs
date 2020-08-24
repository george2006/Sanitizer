using dotnettest.Abstractions;
using dotnettest.Sanitizers.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.Dto
{
    public class OrderDto
    {
        [Sanitize(typeof(EmailSanitizer), null)]
        public Email Email { get; set; }

        [Sanitize(typeof(AddressSanitizer), null)]
        public string Address { get; set; }
    }
}
