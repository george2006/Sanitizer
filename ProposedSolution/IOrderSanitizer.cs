using dotnettest.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnettest.ProposedSolution
{
    public interface IOrderSanitizer
    {
        OrderDto Sanitize(OrderDto orderDto);
    }
}
