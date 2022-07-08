using Microsoft.OpenApi.Models;

namespace SuperHero_Api
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Verison { get; set; }
    }
}