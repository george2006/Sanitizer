using dotnettest.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.ProposedSolution
{
    public class EmailSanitizer : IOrderSanitizer
    {
        public OrderDto Sanitize(OrderDto orderDto)
        {
            orderDto.Email = new Email("Dog@gmail.com");
            return orderDto;
        }
    }
}
