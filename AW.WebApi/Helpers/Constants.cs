namespace AW.WebApi.Helpers
{
    /// <summary>
    /// String constants used throughout the application
    /// </summary>
    public static class Constants
    {
        public const string connectionStringName = "MainConnectionString";
        public const string customHeaderKey = "HeaderAuthorization";
        public const string customHeaderValue = "=saASFe982dq19Dskadj";
        public const string customHeaderExceptionMessage = "Missing Authentication Header";
        public const string productKeyValidationExceptionMessage = "Wrong Product Key";
        public const string productNotFound = "Product Not Found";
        public const string productNotCreated = "Product Could Not Be Created";
    }
}