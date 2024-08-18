using Microsoft.AspNetCore.Mvc;
using resume_api.Models;

namespace resume_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WorkHistoryController : ControllerBase
{
    private static readonly List<WorkHistory> WorkHistories = [
        new WorkHistory{
            Id =  1,
            Company = "Krush",
            Years = 2,
            Description = "All the Krush",
            Image = "https://www.krushoz.com/wp-content/uploads/2021/03/Krush-Logo-By-Riders-for-Riders-Black.png"
        },
        new WorkHistory {
            Id = 2,
            Company = "Cincinnati Reds",
            Years = 5,
            Description = "Go Reds!",
            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Cincinnati_Reds_Logo.svg/294px-Cincinnati_Reds_Logo.svg.png"
        }
    ];

    private readonly ILogger<WorkHistoryController> _logger;

    public WorkHistoryController(ILogger<WorkHistoryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Get")]
    public List<WorkHistory> Get()
    {
        _logger.LogInformation("Getting work-histories");
        return WorkHistories;
    }
}
