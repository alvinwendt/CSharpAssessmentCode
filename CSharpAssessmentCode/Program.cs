using Orientation;

namespace CSharpAssessmentCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Illusion> illusions = new List<Illusion>()
            {
                new Illusion() { Name = "Rabbit Trick", IsExpert = false }, 
                new Illusion() { Name = "Disappearing Trick", IsExpert = true },
                new Illusion() { Name = "Card Trick", IsExpert = false },
             };
            Magician aMagician = new Magician(illusions); 
            aMagician.FirstName = "Nuttin";
            aMagician.LastName = "Upmesleve";
       
            ISkilled skilledMagician = aMagician;
            Magician m = new Magician(new List<Illusion>());
            //Console.WriteLine($"{typeof(skilledMagician)});
            aMagician.GetBeginnerSkills();
            aMagician.StudySkill("Sawing in Half Trick");
            aMagician.StudySkill("Rabbit Trick");
            aMagician.GetExpertSkills();
            Console.WriteLine(aMagician.ToString());


        }
    }
}