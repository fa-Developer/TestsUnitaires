using System;

namespace testsUnitaires
{
    /// <summary>
    /// Classe générant des phrases
    /// </summary>
    public class Fortune
    {
        /// <summary>
        /// Générateur de phrases
        /// </summary>
        /// <param name="v">indice</param>
        /// <returns></returns>
        public string phrase(int v)
        {
            string resultat = "";
            switch (v)
            {
                case 1:
                    resultat = "phrase 1";
                    break;
                case 2:
                    resultat = "phrase 2";
                    break;
                case 3:
                    resultat = "phrase 3";
                    break;
                case 4:
                    resultat = "phrase 4";
                    break;
                case 5:
                    resultat = "phrase 5";
                    break;
                default:
                    break;
            }

            return resultat;
        }
    }
}