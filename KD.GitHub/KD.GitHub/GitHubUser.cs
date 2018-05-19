using System.Collections.Generic;

namespace KD.GitHub
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

        /// <summary>
        /// Returns collection of users who are following current user.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GitHubUser> GetFollowers()
        {
            var followers = new List<GitHubUser>();

            JsonParser.ParseCollection(this.FollowersUrl, (token) =>
            {
                string json = token.ToString();
                GitHubUser follower = new GitHubUser(json);

                followers.Add(follower);
            });

            return followers;
        }

        /// <summary>
        /// Returns collection of organizations to which the current user belongs.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GitHubOrganization> GetOrganizations()
        {
            var organizations = new List<GitHubOrganization>();

            JsonParser.ParseCollection(this.OrganizationsUrl, (token) =>
            {
                string json = token.ToString();
                GitHubOrganization follower = new GitHubOrganization(json);

                organizations.Add(follower);
            });

            return organizations;
        }
    }
}