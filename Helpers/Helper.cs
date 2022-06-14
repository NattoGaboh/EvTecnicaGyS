using System;

namespace EvTecnicaGyS.Helpers
{
    public class Helper
    {
        public static string FillString(string Cadena, char Char, int Long, bool Left)
        {
            if (Left)
            {
                return Cadena.PadLeft(Long, Char);
            }
            else
            {
                return Cadena.PadRight(Long, Char);
            }
        }
    }
}
