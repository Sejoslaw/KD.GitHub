namespace KD.GitHub.Models
{
    /// <summary>
    /// Contains informations about GitHub License.
    /// </summary>
    public sealed class GitHubLicense : GitHubElement
    {
        public string Key { get => this.TryGetDataValue("key"); }
        public string SpdxId { get => this.TryGetDataValue("spdx_id"); }

        public GitHubLicense(string httpResponse) : base(httpResponse)
        {
        }
    }
}
