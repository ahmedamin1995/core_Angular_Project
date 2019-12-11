using Swashbuckle.AspNetCore.Swagger;

namespace CrudAngalurDemo
{
    internal class OpenApiInfo : Info
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}