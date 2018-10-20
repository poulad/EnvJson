// ReSharper disable once CheckNamespace

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// Contains extension methods for adding JSON-serialized environment variables
    /// </summary>
    public static class ConfigurationBuilderExtensions
    {
        /// <summary>
        /// Adds JSON-serialized environment variable to the configuration builder
        /// </summary>
        /// <param name="configurationBuilder">The instance of <see cref="IConfigurationBuilder"/> to add to</param>
        /// <param name="envVar">Environment variable name</param>
        /// <param name="optional">Whether the environment variable is optional</param>
        /// <returns>The instance of <see cref="IConfigurationBuilder"/></returns>
        public static IConfigurationBuilder AddJsonEnvVar(
            this IConfigurationBuilder configurationBuilder,
            string envVar,
            bool optional = false
        )
        {
            configurationBuilder.Add(new JsonEnvVarConfigurationSource
            {
                EnvVarName = envVar,
                IsOptional = optional,
            });
            return configurationBuilder;
        }
    }
}