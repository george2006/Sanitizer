namespace dotnettest.Abstractions
{
    public interface ISanitizer
    {
        TObject Sanitize<TObject>(TObject @object) where TObject : class;
    }
}