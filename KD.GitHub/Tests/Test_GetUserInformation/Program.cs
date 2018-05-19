using KD.GitHub;
using KD.GitHub.Models;
using System.Collections.Generic;

namespace Test_GetUserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHubClient client = new GitHubClient();
            client.Parameters.Add("per_page", int.MaxValue.ToString());

            GitHubUser user = client.GetUserInformation("Sejoslaw");
            IEnumerable<GitHubUser> followers = client.GetFollowers(user);
            IEnumerable<GitHubOrganization> organizations = client.GetOrganizations(user);
            IEnumerable<GitHubRepository> subscriptions = client.GetSubscriptions(user);
            IEnumerable<GitHubRepository> repositories = client.GetRepositories(user);
            ;
        }
    }
}
