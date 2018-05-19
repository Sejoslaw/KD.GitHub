namespace KD.GitHub.Models
{
    /// <summary>
    /// Contains information about GitHub Organization.
    /// </summary>
    public sealed class GitHubOrganization : GitHubElement
    {
        public string MembersUrl { get => this.TryGetDataValue("members_url"); }
        public string PublicMembersUrl { get => this.TryGetDataValue("public_members_url"); }
        public bool HasOrganizationProjects { get => bool.Parse(this.TryGetDataValue("has_organization_projects")); }
        public bool HasRepositoryProjects { get => bool.Parse(this.TryGetDataValue("has_repository_projects")); }

        public GitHubOrganization(string httpResponse) : base(httpResponse)
        {
        }
    }
}
