using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        // TODO: Test the Empty Constructor
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job1.Id == (job2.Id - 1));
        }

        [TestMethod]
        // TODO: Test the Full Constructor
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), 
                new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string expectedJobName = "Product tester";
            string actualJobName = testJob.Name;
            string expectedEmployerName = "ACME";
            string actualEmployerName = testJob.EmployerName.Value;
            string expectedLocationName = "Desert";
            string actualLocationName = testJob.EmployerLocation.Value;
            string expectedPositionTypeName = "Quality control";
            string actualPositionTypeName = testJob.JobType.Value;
            string expectedCoreCompetencyName = "Persistence";
            string actualCoreCompetencyName = testJob.JobCoreCompetency.Value;

            Assert.AreEqual(expectedJobName, actualJobName);
            Assert.AreEqual(expectedEmployerName, actualEmployerName);
            Assert.AreEqual(expectedLocationName, actualLocationName);
            Assert.AreEqual(expectedPositionTypeName, actualPositionTypeName);
            Assert.AreEqual(expectedCoreCompetencyName, actualCoreCompetencyName);
        }

        [TestMethod]
        // TODO: Test the Equals() Method
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testJob1.Equals(testJob2));
        }
    }
}
