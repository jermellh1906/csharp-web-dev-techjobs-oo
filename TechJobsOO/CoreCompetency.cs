using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {

        // private int id;
        // private string value;
        private static int nextId = 1;
        
        // TODO: Change the fields to auto-implemented properties.
        public int Id { get; }
        public string Value { get; set; }
        public CoreCompetency()
        {
            this.Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            this.Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   this.Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}

