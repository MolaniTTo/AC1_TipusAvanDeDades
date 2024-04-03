using System.Text.RegularExpressions;

namespace AC1_Validations
{
    public class CheckValidations
    {
        public static bool ValidatePlayer(string Player)
        {
            bool result = true;
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            result = regex.IsMatch(Player);
            if (!result) { Console.WriteLine("Can only contain alphabetic characters (no accents or special characters)"); }
            return result;
            
        }  

        public static bool ValidateMission(string Mission)
        {
            bool result = true; 

            Regex regex = new Regex(@"^(Delta|Alpha|Beta|Gamma|Epsilon|Zeta|Eta|Theta|Iota|Kappa|Lambda|Mu|Nu|Xi|Omicron|Pi|Rho|Sigma|Tau|Upsilon|Phi|Chi|Psi|Omega)-\d{3}$");

            result = regex.IsMatch(Mission);

            if (!result) { Console.WriteLine("It must start with a Greek letter and end with hyphen followed by 3 numbers"); }

            return result;
        }

        public static bool ValidateScore(int Scoring)
        {
            bool result = false;
            if(Scoring >=0 && Scoring <= 500) { result = true; return result;}

            Console.WriteLine(" Scoring must be between 0 and 500!");

            return result;
        }
    }
}
