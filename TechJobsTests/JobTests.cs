using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    
    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Job testJob2;
        Job testJob3;
        Job testJob4;
        Job testJob5;
        [TestInitialize]
        public void CreateJobObjects()
        {
            testJob1 = new Job();
            testJob2 = new Job(); 
            testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));

            testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));

            testJob5 = new Job("Product tester", new Employer("ACME"), new Location(""),
                new PositionType("Quality control"), new CoreCompetency());
        }        

        [TestMethod]
        // TODO: Test the Empty Constructor
        public void TestSettingJobId()
        {
            

            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.IsTrue(testJob1.Id == (testJob2.Id - 1));
        }

        [TestMethod]
        // TODO: Test the Full Constructor
        public void TestJobConstructorSetsAllFields()
        {
            string expectedJobName = "Product tester";
            string actualJobName = testJob3.Name;
            string expectedEmployerName = "ACME";
            string actualEmployerName = testJob3.EmployerName.Value;
            string expectedLocationName = "Desert";
            string actualLocationName = testJob3.EmployerLocation.Value;
            string expectedPositionTypeName = "Quality control";
            string actualPositionTypeName = testJob3.JobType.Value;
            string expectedCoreCompetencyName = "Persistence";
            string actualCoreCompetencyName = testJob3.JobCoreCompetency.Value;

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
            Assert.IsFalse(testJob3.Equals(testJob4));
        }

        [TestMethod]
        public void TestForToStringOpeningBlankLine()
        {
            // test starting blank line
            Assert.IsTrue(testJob4.ToString().StartsWith("\n"));
        }

        [TestMethod]
        public void TestForToStringEndingBlankLine()
        {
            // test ending blank line
            Assert.IsTrue(testJob3.ToString().EndsWith("\n"));
        }

        // Testing for proper formatted string from ToString() when all properties added
        [TestMethod]
        public void TestForToStringFormat()
        {
            string expected =
                $"\nID: { testJob3.Id }" +
                $"\nName: Product tester" +
                $"\nEmployer: ACME" +
                $"\nLocation: Desert" +
                $"\nPosition Type: Quality control" +
                $"\nCore Competency: Persistence\n";

            string actual = testJob3.ToString();

            Assert.AreEqual(expected, actual);
        }

        // If a field is empty, the method should add, “Data not available” after the label.
        [TestMethod]
        public void TestForToStringDataNotAvailable()
        {
            string expected =
                $"\nID: { testJob5.Id }" +
                $"\nName: Product tester" +
                $"\nEmployer: ACME" +
                $"\nLocation: Data not available" +
                $"\nPosition Type: Quality control" +
                $"\nCore Competency: Data not available\n";

            string actual = testJob5.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
