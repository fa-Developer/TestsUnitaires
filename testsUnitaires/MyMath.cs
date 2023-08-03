using System;

namespace testsUnitaires
{
    /// <summary>
    /// Classe statique d'opérateurs mathématiques
    /// </summary>
    public class MyMath
    {
        /// <summary>
        /// Addition d'entiers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Division d'entiers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Vous tentez de diviser par zéro!");
            }
            return a / b;
        }

        /// <summary>
        /// Multiplication d'entiers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiplication(int a, int b )
        {
            return a * b;
        }

        /// <summary>
        /// Vérification de valeur supérieur
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Superieur(int a, int b)
        {
            return a > b ? true: false;
        }
    }
}