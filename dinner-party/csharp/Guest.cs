
namespace DinnerParty
{
    public class Guest
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string Bio { get; set; }

        public Guest(string name, string occ, string bio)
        {
            Name = name;
            Occupation = occ;
            Bio = bio;
        }
    }
}