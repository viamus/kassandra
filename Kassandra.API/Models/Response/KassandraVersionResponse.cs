namespace Kassandra.API.Models.Response
{
    /// <summary>
    /// Kassandra Framework Information
    /// </summary>
    public class KassandraVersionResponse
    {
        /// <summary>
        /// Template Project Name
        /// </summary>
        public string Core { get; set; }

        /// <summary>
        /// Version of the template project
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Project address url
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// Running on Develop or Production configurations
        /// </summary>
        public string Environment { get; set; }

    }
}
