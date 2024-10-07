using USP.Domain.Enums;

namespace USP.Domain.Extenstions;

public class EnumExtenstions
{
    public static readonly string ValidCategoryList =
        string.Join(", ", Category.List.Select(x => x.ToString()));
}