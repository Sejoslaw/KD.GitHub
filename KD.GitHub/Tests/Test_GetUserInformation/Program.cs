using KD.GitHub;
using System.Collections.Generic;

namespace Test_GetUserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHubClient client = new GitHubClient();
            GitHubUser user = client.GetUserInformation("Sejoslaw");
            IEnumerable<GitHubUser> followers = user.GetFollowers();
            IEnumerable<GitHubOrganization> organizations = user.GetOrganizations();
            ;
        }
    }
}
