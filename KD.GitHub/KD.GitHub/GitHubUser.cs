using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace KD.GitHub
{
    /// <summary>
    /// Contains information about GitHub user.
    /// </summary>
    public sealed class GitHubUser : GitHubElements
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
            this.ParseUserInformation();
        }

        public IEnumerable<GitHubUser> GetFollowers()
        {
            string httpResponse = RequestSender.Get(this.FollowersUrl);
            var followers = new List<GitHubUser>();

            JArray array = JArray.Parse(httpResponse);
            array.ToList().ForEach(token =>
            {
                string followerJson = token.ToString();
                GitHubUser follower = new GitHubUser(followerJson);

                followers.Add(follower);
            });

            return followers;
        }

        private void ParseUserInformation()
        {
            JsonParser.FillData(this.Data, this.HttpResponse);
        }
    }
}