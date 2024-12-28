namespace Lemao.UtilExtensions;

public static class GuidExtensions
{
    public static bool IsEmpty(this Guid id) => id == Guid.Empty;

    public static bool IsNullOrEmpty(this Guid? id) => !id.HasValue || id.Value == Guid.Empty;
}
