using KD.GitHub;

namespace Test_GetUserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            GitHubClient client = new GitHubClient();
            GitHubUser user = client.GetUserInformation("Sejoslaw");
            ;
        }
    }
}
