namespace KD.GitHub
{
    /// <summary>
    /// Contains information about GitHub Organization.
    /// </summary>
    public sealed class GitHubOrganization : GitHubElement
    {
        public string HooksUrl { get => this.TryGetDataValue("hooks_url"); }
        public string IssuesUrl { get => this.TryGetDataValue("issues_url"); }
        public string MembersUrl { get => this.TryGetDataValue("members_url"); }
        public string PublicMembersUrl { get => this.TryGetDataValue("public_members_url"); }
        public string Description { get => this.TryGetDataValue("description"); }
        public bool HasOrganizationProjects { get => bool.Parse(this.TryGetDataValue("has_organization_projects")); }
        public bool HasRepositoryProjects { get => bool.Parse(this.TryGetDataValue("has_repository_projects")); }

        public GitHubOrganization(string httpResponse) : base(httpResponse)
        {
        }
    }
}
