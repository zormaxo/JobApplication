using JobApplicationLibrary.Models;

namespace JobApplicationLibrary;

public class ApplicationEvaluator
{
    private const int MIN_AGE = 18;

    public ApplicationResult Evaluate(JobApplication form)
    {
        if (form.Applicant.Age < MIN_AGE)
            return ApplicationResult.AutoRejected;

        return ApplicationResult.AutoAccepted;
    }
}

public enum ApplicationResult
{
    AutoRejected,
    TransferredToHR,
    TransferredToLead,
    TransferredToCTO,
    AutoAccepted
}

