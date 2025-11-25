namespace MyProgram;

public class FancyResult<T> {
    public required T Data { get; init; }
    public required string Message { get; init; }
    public bool Success { get; init; }
}

public static class FancyResult {
    public static FancyResult<T> Create<T>(T data, bool success = true, string message = "") => new() {
        Data = data,
        Success = success,
        Message = message
    };
}
