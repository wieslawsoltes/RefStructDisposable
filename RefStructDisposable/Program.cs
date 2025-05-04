using var test = DisposableStruct.Create(() => Console.WriteLine("Hello, World!"));

internal readonly ref struct DisposableStruct : IDisposable
{
    private readonly Action _dispose;

    private DisposableStruct(Action dispose)
    {
        _dispose = dispose;
    }

    public static DisposableStruct Create(Action dispose) => new(dispose);

    public void Dispose() => _dispose();
}
