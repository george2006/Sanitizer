using dotnettest.Abstractions;
using dotnettest.Dto;
using dotnettest.Sanitizer;
using System;

namespace dotnettest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Build order.
            OrderDto orderDto = new OrderDto();
            orderDto.Email = new Email("Perro");
            orderDto.Address = "jorge y muchos espacios            ";

            // Sanitize using a specialized object
            ISanitizer sanitizer = new DefaultSanitizer();
            orderDto = sanitizer.Sanitize(orderDto);
            Console.ReadLine();
        }
    }
}
