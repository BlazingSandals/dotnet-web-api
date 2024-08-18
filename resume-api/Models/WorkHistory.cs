namespace resume_api.Models;

public class WorkHistory
{
    public int Id { get; set; }
    public string? Company { get; set; }
    public int Years { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
}
