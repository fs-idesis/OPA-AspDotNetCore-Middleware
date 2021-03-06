namespace Build.Security.AspNetCore.Middleware.Configuration
{
    public class OpaAuthzConfiguration
    {
        public bool Enable { get; set; }
        public int Timeout { get; set; }
        public string BaseAddress { get; set; } = string.Empty;
        public string PolicyPath { get; set; } = string.Empty;
        public bool AllowOnFailure { get; set; } = true;
        public bool IncludeBody { get; set; } = false;
        public bool IncludeHeaders { get; set; } = false;
        public string[] IgnoreEndpoints { get; set; } = { };
        public string[] IgnoreRegex { get; set; } = { };
    }
}
