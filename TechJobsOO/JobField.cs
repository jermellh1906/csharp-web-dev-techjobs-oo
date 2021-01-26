using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
        public JobField(string value) : this()
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
