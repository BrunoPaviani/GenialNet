namespace GenialNet.Extensions;

public static class StringExtension
{
    public static string RemoverCaracteresEspeciais(this string value)
    {
        if (string.IsNullOrEmpty(value))
            return value;

        return value.Replace(".", string.Empty).Replace("/", string.Empty).Replace("-", string.Empty);
    }
}