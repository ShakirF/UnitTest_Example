using JobApplicationLibrary.Models;

namespace JobApplicationLibrary;

public class ApplicationEveluator
{
    public ApplicationResult Evaluate(JobApplication form)
    {
        if (form.Applicant.Age < 18) return ApplicationResult.AutoRejeced;
        return ApplicationResult.AutoAccepted;
    }
}
public enum ApplicationResult
{
    AutoRejeced,
    TransferredToHR,
    TransferredToLead,
    TransferredToCTO,
    AutoAccepted
}
