namespace JobApplicationLibrary.Models;

public class JobApplication
{
    public Applicant Applicant { get; set; } = null!;
    public int YearsOfExperience { get; set; }
    public List<string> TestStackList { get; set; }
    public JobApplication() => TestStackList = new List<string>();
}

