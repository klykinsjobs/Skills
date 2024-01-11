namespace Skills
{
    public class Skill : IEquatable<Skill>
    {
        public string Name { get; set; } = "";
        public decimal Level { get; set; } = 0.0m;
        public DateTime LastUsed { get; set; } = DateTime.MinValue;

        public override string ToString()
        {
            return Name + " | " + Level.ToString("F1");
        }

        public bool Equals(Skill? other)
        {
            if (other == null) return false;
            return (this.Name.Equals(other.Name));
        }
    }
}