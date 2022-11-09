using JobApplicationLibrary.Models;

namespace JobApplicationLibrary.xUnitTest;

public class ApplicationEvaluateXUnitTest
{
    [Fact]
    public void Application_WithUnderAge_TransferredToAutoRejected()
    {
        //Arrange
        var evaluator = new ApplicationEvaluator();
        var form = new JobApplication() { Applicant = new Applicant() { Age = 17 } };

        //Action
        var appResult = evaluator.Evaluate(form);

        //Assert
        Assert.Equal(ApplicationResult.AutoRejected, appResult);
    }
}