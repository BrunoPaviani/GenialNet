using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;
using System.Reflection;

namespace GenialNet.SwaggerExtensions;

public static class SwaggerExtension
{
    public static void DescricaoEnumeradores(this SwaggerGenOptions options)
    {
        options.SchemaFilter<EnumSchemaFilter>();
    }
}

public class EnumSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (schema.Enum != null && schema.Enum.Count > 0 && context.Type.IsEnum)
        {
            var enumType = context.Type;
            var enumValues = Enum.GetValues(enumType)
                .Cast<Enum>()
                .Select(e => new
                {
                    Value = e.ToString(),
                    Description = GetEnumDescription(e)
                })
                .ToList();

            schema.Enum.Clear();
            foreach (var enumValue in enumValues)
            {
                schema.Enum.Add(new OpenApiString(enumValue.Value));
            }
        }
    }

    private static string GetEnumDescription(Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var descriptionAttribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
        return descriptionAttribute == null ? value.ToString() : descriptionAttribute.Description;
    }
}