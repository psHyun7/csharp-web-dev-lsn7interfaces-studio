using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        private static int nextId = 1;
        public int DiscId { get;  }
        public string Name { get; set; }
        public double Storage { get; set; }
        public int MinRPM { get; set; }
        public int MaxRPM { get; set; }

        public BaseDisc()
        {
            DiscId = nextId;
            nextId++;
        }
        public BaseDisc(string name) : this()
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"Disc#: {DiscId}. Name: " + Name;
        }

        public override bool Equals(object obj)
        {
            return obj is BaseDisc disc &&
                   DiscId == disc.DiscId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DiscId);
        }
    }
}
