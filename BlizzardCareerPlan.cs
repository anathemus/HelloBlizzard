public class BlizzardCareerPlan
{
   public static void Main()
   {
      bool BlizzardEmployment = false;
      bool TryingToAttainBlizzLife = true;

      while (InSchool())
      {
          Eat();
          Work();
          GetGoodGrades();
          DoGoodAtParenting();
          Sleep();
          if (SpareTime)
          {
              PracticeCoding();
              PlayBlizzardGames();
          }
      }

      while (TryingToAttainBlizzLife)
      {
          Eat();
          Work();
          PracticeCoding();
          LearnOnPluralSight();
          SideGamingProjects();
          ImproveSkillset();
          PlayBlizzardGames();
          Sleep();
          if (BlizzardPositionOpen)
          {
              ApplyToGreatestCompanyEver();
          }

          if (BlizzardEmployment == false)
          {
             Console.WriteLine("Illidan Stormrage: YOU ARE NOT PREPARED!!!");
          }
          else
          {
              TryingToAttainBlizzLife = false;
              Console.WriteLine("Illidan Stormrage: YOU ARE... Oh, wait. Huh, this guy might work. Proceed.");
              BlizzardEmployment = true;
          }
      }
   }

   public static bool InSchool()
   {
       if (graduated)
       {
           return false;
       }
       else
       {
           return true;
       }
   }
}