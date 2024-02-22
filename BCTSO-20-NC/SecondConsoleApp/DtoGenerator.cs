using System.Reflection;
using System.Text;

namespace SecondConsoleApp
{
    public class DtoGenerator
    {
        public static void GenerateDto(Type sourceType, string outputPath)
        {
            string dtoClassName = sourceType.Name + "Dto";
            string dtoCode = GetDtoCode(sourceType, dtoClassName);

            string outputFilePath = Path.Combine(outputPath, dtoClassName + ".cs");

            File.WriteAllText(outputFilePath, dtoCode);
        }

        private static string GetDtoCode(Type sourceType, string dtoClassName)
        {
            StringBuilder dtoCode = new StringBuilder();
            dtoCode.Append($"public class {dtoClassName}\n{{\n");

            PropertyInfo[] properties = sourceType.GetProperties();

            foreach (var property in properties)
            {
                string propertyType = property.PropertyType.Name;
                string propertyName = property.Name;

                dtoCode.Append($"\tpublic {propertyType} {propertyName} {{ get; set; }}\n");
            }

            dtoCode.Append("}\n");

            return dtoCode.ToString();
        }
    }
}


