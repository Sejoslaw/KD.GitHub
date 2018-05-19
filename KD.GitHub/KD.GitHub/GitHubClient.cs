using KD.GitHub.Models;
using System.Collections.Generic;
using System.Linq;

namespace KD.GitHub
{
    /// <summary>
    /// Main class which is used for changing informations with GitHub.
    /// </summary>
    public class GitHubClient
    {
        /// <summary>
        /// Additional parameters / arguments added to URL.
        /// </summary>
        public IDictionary<string, string> Parameters { get; }

        public GitHubClient()
        {
            this.Parameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Retrieves basic information about specified User.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public GitHubUser GetUserInformation(string username)
        {
            string httpResponse = RequestSender.Get($"{ Constants.UrlUsers }/{ username }");
            return new GitHubUser(httpResponse);
        }

        /// <summary>
        /// Returns collection of users who are following specified user.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GitHubUser> GetFollowers(GitHubUser user)
        {
            var followers = new List<GitHubUser>();

            JsonParser.ParseCollection(user.FollowersUrl + this.ParseUrlArguments(), (token) =>
            {
                string json = token.ToString();
                GitHubUser follower = new GitHubUser(json);

                followers.Add(follower);
            });

            return followers;
        }

        /// <summary>
        /// Returns collection of organizations to which the specified user belongs.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GitHubOrganization> GetOrganizations(GitHubUser user)
        {
            var organizations = new List<GitHubOrganization>();

            JsonParser.ParseCollection(user.OrganizationsUrl + this.ParseUrlArguments(), (token) =>
            {
                string json = token.ToString();
                GitHubOrganization follower = new GitHubOrganization(json);

                organizations.Add(follower);
            });

            return organizations;
        }

        /// <summary>
        /// Returns collection of repositories which specified user subscribes.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IEnumerable<GitHubRepository> GetSubscriptions(GitHubUser user)
        {
            var subs = new List<GitHubRepository>();

            JsonParser.ParseCollection(user.SubscriptionsUrl + this.ParseUrlArguments(), (token) =>
            {
                string json = token.ToString();
                GitHubRepository repo = new GitHubRepository(json);

                subs.Add(repo);
            });

            return subs;
        }

        /// <summary>
        /// Returns collection which contains all repositories of specified used.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IEnumerable<GitHubRepository> GetRepositories(GitHubUser user)
        {
            var subs = new List<GitHubRepository>();

            JsonParser.ParseCollection(user.ReposUrl + this.ParseUrlArguments(), (token) =>
            {
                string json = token.ToString();
                GitHubRepository repo = new GitHubRepository(json);

                subs.Add(repo);
            });

            return subs;
        }

        private string ParseUrlArguments()
        {
            string urlArgs = "?";

            this.Parameters.ToList().ForEach((pair) =>
            {
                urlArgs += $"{ pair.Key }={ pair.Value }&";
            });

            return urlArgs;
        }
    }
}
