namespace Lemao.UtilExtensions;

public static class EnvironmentVariable
{
    public static bool IsTrue(string variable)
    {
        var value = Environment.GetEnvironmentVariable(variable);

        return value is not null && (value.Equals("true", StringComparison.OrdinalIgnoreCase) || int.TryParse(value, out var intValue) && intValue == 1);
    }

    public static bool IsFalse(string variable)
    {
        var value = Environment.GetEnvironmentVariable(variable);

        return value is not null && (value.Equals("false", StringComparison.OrdinalIgnoreCase) || int.TryParse(value, out var intValue) && intValue == 0);
    }
}
