namespace KD.GitHub.Models
{
    /// <summary>
    /// Contains information about GitHub user.
    /// </summary>
    public sealed class GitHubUser : GitHubElement
    {
        public string GravatarId { get => this.TryGetDataValue("gravatar_id"); }
        public string FollowersUrl { get => this.TryGetDataValue("followers_url"); }
        public string FollowingUrl { get => this.TryGetDataValue("following_url"); }
        public string GistsUrl { get => this.TryGetDataValue("gists_url"); }
        public string StarredUrl { get => this.TryGetDataValue("starred_url"); }
        public string SubscriptionsUrl { get => this.TryGetDataValue("subscriptions_url"); }
        public string OrganizationsUrl { get => this.TryGetDataValue("organizations_url"); }
        public string ReceivedEventsUrl { get => this.TryGetDataValue("received_events_url"); }
        public bool IsSiteAdmin { get => bool.Parse(this.TryGetDataValue("site_admin")); }
        public bool IsHireable { get => bool.Parse(this.TryGetDataValue("hireable")); }
        public string Bio { get => this.TryGetDataValue("bio"); }

        public GitHubUser(string httpResponse) : base(httpResponse)
        {
        }
    }
}