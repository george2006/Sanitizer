using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.Dto
{
    public class Email
    {
        public Email(string value)
        {
            this.Value = value;
        }
        public string Value { get; set; } = "Carlos";
    }
}
