using BugNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugNet.Pages;

public class IndexModel : PageModel
{
    
    public IList<Bug> BugList { get; set; }
    public int UnDoneCount { get; set; }
    public void OnGet()
    {
        BugList = new List<Bug>
        {
            new Bug{ Id = 1,Name="Taks1",Description="h1",IsDone=false},
            new Bug{ Id = 2,Name="Taks2",Description="h2",IsDone=false},
            new Bug{ Id = 3,Name="Taks3",Description="h3",IsDone=true},
        };

        UnDoneCount = BugList.Count(b=>b.IsDone==false);

    }
}
