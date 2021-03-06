﻿using System;

namespace KD.GitHub.Models
{
    /// <summary>
    /// Contains information about GitHub Repository.
    /// </summary>
    public sealed class GitHubRepository : GitHubElement
    {
        public string FullName { get => this.TryGetDataValue("full_name"); }
        public GitHubUser Owner { get => new GitHubUser(this.TryGetDataValue("owner")); }
        public bool IsPrivate { get => bool.Parse(this.TryGetDataValue("private")); }
        public bool IsFork { get => bool.Parse(this.TryGetDataValue("fork")); }
        public string ForksUrl { get => this.TryGetDataValue("forks_url"); }
        public string KeysUrl { get => this.TryGetDataValue("keys_url"); }
        public string CollaboratorsUrl { get => this.TryGetDataValue("collaborators_url"); }
        public string TeamsUrl { get => this.TryGetDataValue("teams_url"); }
        public string IssueEventsUrl { get => this.TryGetDataValue("issue_events_url"); }
        public string AssigneesUrl { get => this.TryGetDataValue("assignees_url"); }
        public string BranchesUrl { get => this.TryGetDataValue("branches_url"); }
        public string TagsUrl { get => this.TryGetDataValue("tags_url"); }
        public string BlobsUrl { get => this.TryGetDataValue("blobs_url"); }
        public string GitTagsUrl { get => this.TryGetDataValue("git_tags_url"); }
        public string GitRefsUrl { get => this.TryGetDataValue("git_refs_url"); }
        public string TreesUrl { get => this.TryGetDataValue("trees_url"); }
        public string StatusesUrl { get => this.TryGetDataValue("statuses_url"); }
        public string LanguagesUrl { get => this.TryGetDataValue("languages_url"); }
        public string StargazersUrl { get => this.TryGetDataValue("stargazers_url"); }
        public string ContributorsUrl { get => this.TryGetDataValue("contributors_url"); }
        public string SubscribersUrl { get => this.TryGetDataValue("subscribers_url"); }
        public string SubscriptionUrl { get => this.TryGetDataValue("subscription_url"); }
        public string CommitsUrl { get => this.TryGetDataValue("commits_url"); }
        public string GitCommitsUrl { get => this.TryGetDataValue("git_commits_url"); }
        public string CommentsUrl { get => this.TryGetDataValue("comments_url"); }
        public string IssueCommentsUrl { get => this.TryGetDataValue("issue_comment_url"); }
        public string ContentsUrl { get => this.TryGetDataValue("contents_url"); }
        public string CompareUrl { get => this.TryGetDataValue("compare_url"); }
        public string MergesUrl { get => this.TryGetDataValue("merges_url"); }
        public string ArchiveUrl { get => this.TryGetDataValue("archive_url"); }
        public string DownloadsUrl { get => this.TryGetDataValue("downloads_url"); }
        public string PullsUrl { get => this.TryGetDataValue("pulls_url"); }
        public string MilestonesUrl { get => this.TryGetDataValue("milestones_url"); }
        public string NotificationsUrl { get => this.TryGetDataValue("notifications_url"); }
        public string LabelsUrl { get => this.TryGetDataValue("labels_url"); }
        public string ReleasesUrl { get => this.TryGetDataValue("releases_url"); }
        public string DeploymentsUrl { get => this.TryGetDataValue("deployments_url"); }
        public DateTime PushedAt { get => DateTime.Parse(this.TryGetDataValue("pushed_at")); }
        public string GitUrl { get => this.TryGetDataValue("git_url"); }
        public string SshUrl { get => this.TryGetDataValue("ssh_url"); }
        public string CloneUrl { get => this.TryGetDataValue("clone_url"); }
        public string SvnUrl { get => this.TryGetDataValue("svn_url"); }
        public string Homepage { get => this.TryGetDataValue("homepage"); }
        public int Size { get => int.Parse(this.TryGetDataValue("size")); }
        public int StargazersCount { get => int.Parse(this.TryGetDataValue("stargazers_count")); }
        public int WatchersCount { get => int.Parse(this.TryGetDataValue("watchers_count")); }
        public string Language { get => this.TryGetDataValue("language"); }
        public bool HasIssues { get => bool.Parse(this.TryGetDataValue("has_issues")); }
        public bool HasProjects { get => bool.Parse(this.TryGetDataValue("has_projects")); }
        public bool HasDownloads { get => bool.Parse(this.TryGetDataValue("has_downloads")); }
        public bool HasWiki { get => bool.Parse(this.TryGetDataValue("has_wiki")); }
        public bool HasPages { get => bool.Parse(this.TryGetDataValue("has_pages")); }
        public int ForksCount { get => int.Parse(this.TryGetDataValue("forks_count")); }
        public string MirrorUrl { get => this.TryGetDataValue("mirror_url"); }
        public bool IsArchived { get => bool.Parse(this.TryGetDataValue("archived")); }
        public int OpenIssuesCount { get => int.Parse(this.TryGetDataValue("open_issues_count")); }
        public GitHubLicense License { get => new GitHubLicense(this.TryGetDataValue("license")); }
        public int Forks { get => int.Parse(this.TryGetDataValue("forks")); }
        public int OpenIssues { get => int.Parse(this.TryGetDataValue("open_issues")); }
        public int Watchers { get => int.Parse(this.TryGetDataValue("watchers")); }
        public string DefaultBranch { get => this.TryGetDataValue("default_branch"); }
        public int NetworkCount { get => int.Parse(this.TryGetDataValue("network_count")); }
        public int SubscribersCount { get => int.Parse(this.TryGetDataValue("subscribers_count")); }

        public GitHubRepository(string httpResponse) : base(httpResponse)
        {
        }
    }
}
