namespace KD.GitHub
{
    /// <summary>
    /// Main class which is used for changing informations with GitHub.
    /// </summary>
    public class GitHubClient
    {
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
    }
}
