
using JobApplicationLibrary;

namespace JobApplication.UnitTest;

public class JobApplicationTest
{
    [Test]
    public void ApplicationEveluator_WithUnderAge_UnderCondition()
    {
        // Arrange
        ApplicationEveluator eveluator = new ApplicationEveluator();
        JobApplicationLibrary.Models.JobApplication form = new()
        {
            Applicant = new()
            {
                Age = 18
            }
        };

        // Act
        var result = eveluator.Evaluate(form);

        // Assert
        Assert.AreEqual(ApplicationResult.AutoAccepted, result);
    }
}

