using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override string ToString()
        {
            string output = $"\nID: { this.Id }";

            if (this.Name is null || this.Name == "")
            {
                output += $"\nName: Data not available";
            } else
            {
                output += $"\nName: { this.Name }";
            }

            if (this.EmployerName.Value is null || this.EmployerName.Value == "")
            {
                output += $"\nEmployer: Data not available";
            }
            else
            {
                output += $"\nEmployer: { this.EmployerName.Value }";
            }

            if (this.EmployerLocation.Value is null || this.EmployerLocation.Value == "")
            {
                output += $"\nLocation: Data not available";
            }
            else
            {
                output += $"\nLocation: { this.EmployerLocation.Value }";
            }

            if (this.JobType.Value is null || this.JobType.Value == "")
            {
                output += $"\nPosition Type: Data not available";
            }
            else
            {
                output += $"\nPosition Type: { this.JobType.Value }";
            }

            if (this.JobCoreCompetency.Value is null || this.JobCoreCompetency.Value == "")
            {
                output += $"\nCore Competency: Data not available\n";
            }
            else
            {
                output += $"\nCore Competency: { this.JobCoreCompetency.Value }\n";
            }
            
            return output;
        }
        

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
