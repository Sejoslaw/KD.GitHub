using System;
using System.Collections.Generic;

namespace KD.GitHub.Models
{
    /// <summary>
    /// Contains basic data for each GitHub element.
    /// </summary>
    public class GitHubElement
    {
        public string Login { get => this.TryGetDataValue("login"); }
        public string Id { get => this.TryGetDataValue("id"); }
        public string Url { get => this.TryGetDataValue("url"); }
        public string ReposUrl { get => this.TryGetDataValue("repos_url"); }
        public string EventsUrl { get => this.TryGetDataValue("events_url"); }
        public string AvatarUrl { get => this.TryGetDataValue("avatar_url"); }
        public string Name { get => this.TryGetDataValue("name"); }
        public string Company { get => this.TryGetDataValue("company"); }
        public string Blog { get => this.TryGetDataValue("blog"); }
        public string Location { get => this.TryGetDataValue("location"); }
        public string Email { get => this.TryGetDataValue("email"); }
        public string HtmlUrl { get => this.TryGetDataValue("html_url"); }
        public int PublicRepos { get => int.Parse(this.TryGetDataValue("public_repos")); }
        public int PublicGists { get => int.Parse(this.TryGetDataValue("public_gists")); }
        public int Followers { get => int.Parse(this.TryGetDataValue("followers")); }
        public int Following { get => int.Parse(this.TryGetDataValue("following")); }
        public DateTime CreatingAt { get => DateTime.Parse(this.TryGetDataValue("created_at")); }
        public DateTime UpdatedAt { get => DateTime.Parse(this.TryGetDataValue("updated_at")); }
        public string Type { get => this.TryGetDataValue("type"); }
        public string Description { get => this.TryGetDataValue("description"); }
        public string HooksUrl { get => this.TryGetDataValue("hooks_url"); }
        public string IssuesUrl { get => this.TryGetDataValue("issues_url"); }

        /// <summary>
        /// Contains data received from API.
        /// </summary>
        protected IDictionary<string, string> Data { get; set; }
        /// <summary>
        /// API response.
        /// </summary>
        protected string HttpResponse { get; set; }

        public GitHubElement(string httpResponse)
        {
            this.HttpResponse = httpResponse;
            this.Data = new Dictionary<string, string>();

            this.ParseInformations();
        }

        protected string TryGetDataValue(string key)
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

        private void ParseInformations()
        {
            JsonParser.FillData(this.Data, this.HttpResponse);
        }
    }
}
