using dotnettest.Abstractions;

namespace dotnettest.Sanitizers.Orders
{
    public class AddressSanitizer : IFieldSanitizer<string>
    {
        public string Sanitize(string @object)
        {
            return @object.TrimEnd();
        }
    }
}