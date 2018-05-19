using System;
using System.Collections.Generic;

namespace KD.GitHub
{
    /// <summary>
    /// Contains information about GitHub user.
    /// </summary>
    public sealed class GitHubUser
    {
        /// <summary>
        /// Contains data received from API.
        /// </summary>
        private IDictionary<string, string> Data { get; set; }
        /// <summary>
        /// API response.
        /// </summary>
        private string HttpResponse { get; set; }

        public string Login { get => this.TryGetDataValue("login"); }
        public string Id { get => this.TryGetDataValue("id"); }
        public string AvatarUrl { get => this.TryGetDataValue("avatar_url"); }
        public string GravatarId { get => this.TryGetDataValue("gravatar_id"); }
        public string Url { get => this.TryGetDataValue("url"); }
        public string HtmlUrl { get => this.TryGetDataValue("html_url"); }
        public string FollowersUrl { get => this.TryGetDataValue("followers_url"); }
        public string FollowingUrl { get => this.TryGetDataValue("following_url"); }
        public string GistsUrl { get => this.TryGetDataValue("gists_url"); }
        public string StarredUrl { get => this.TryGetDataValue("starred_url"); }
        public string SubscriptionsUrl { get => this.TryGetDataValue("subscriptions_url"); }
        public string OrganizationsUrl { get => this.TryGetDataValue("organizations_url"); }
        public string ReposUrl { get => this.TryGetDataValue("repos_url"); }
        public string Events { get => this.TryGetDataValue("events_url"); }
        public string ReceivedEventsUrl { get => this.TryGetDataValue("received_events_url"); }
        public string Type { get => this.TryGetDataValue("type"); }
        public bool SiteAdmin { get => bool.Parse(this.TryGetDataValue("site_admin")); }
        public string Name { get => this.TryGetDataValue("name"); }
        public string Company { get => this.TryGetDataValue("company"); }
        public string Blog { get => this.TryGetDataValue("blog"); }
        public string Location { get => this.TryGetDataValue("location"); }
        public string Email { get => this.TryGetDataValue("email"); }
        public bool Hireable { get => bool.Parse(this.TryGetDataValue("hireable")); }
        public string Bio { get => this.TryGetDataValue("bio"); }
        public string PublicRepos { get => this.TryGetDataValue("public_repos"); }
        public string PublicGists { get => this.TryGetDataValue("public_gists"); }
        public string Followers { get => this.TryGetDataValue("followers"); }
        public string Following { get => this.TryGetDataValue("following"); }
        public DateTime CreatingAt { get => DateTime.Parse(this.TryGetDataValue("created_at")); }
        public DateTime UpdatedAt { get => DateTime.Parse(this.TryGetDataValue("updated_at")); }

        public GitHubUser(string httpResponse)
        {
            this.HttpResponse = httpResponse;
            this.Data = new Dictionary<string, string>();

            this.ParseUserInformation();
        }

        private void ParseUserInformation()
        {
            JsonParser.FillData(this.Data, this.HttpResponse);
        }

        private string TryGetDataValue(string key)
        {
            try
            {
                return this.Data[key];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}