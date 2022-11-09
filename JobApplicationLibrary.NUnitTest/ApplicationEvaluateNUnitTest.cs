using JobApplicationLibrary.Models;

namespace JobApplicationLibrary.UnitTest;

public class ApplicationEvaluateNUnitTest
{
    //UnitOfWork_Condition_ExpectedResult

    [Test]
    public void Application_WithUnderAge_TransferredToAutoRejected()
    {
        //Arrange
        var evaluator = new ApplicationEvaluator();
        var form = new JobApplication() { Applicant = new Applicant() { Age = 17 } };

        //Action
        var appResult = evaluator.Evaluate(form);

        //Assert
        Assert.That(appResult, Is.EqualTo(ApplicationResult.AutoRejected));
    }
}