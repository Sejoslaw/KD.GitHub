using System.IO;
using System.Net;

namespace KD.GitHub
{
    /// <summary>
    /// Used for sending requests to GitHub API.
    /// </summary>
    internal static class RequestSender
    {
        public static string Get(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Timeout = int.MaxValue;
            request.UserAgent = "KD.GitHub";
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            request.Credentials = CredentialCache.DefaultNetworkCredentials;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
