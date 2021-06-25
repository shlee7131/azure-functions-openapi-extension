namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.FunctionApp.Models
{
    /// <summary>
    /// This represents the model entity for API request body (multipart/form-data) of Swagger Pet Store.
    /// </summary>
    public class ApiFormDataRequest
    {
        /// <summary>
        /// Gets or sets the additional metadata.
        /// </summary>
        public string AdditionalMetadata { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public byte[] File { get; set; }
    }
}
