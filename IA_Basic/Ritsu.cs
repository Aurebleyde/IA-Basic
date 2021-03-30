using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Basic
{
    class Ritsu
    {
        private Cerveau Cerveau;

        public Ritsu()
        {
            Cerveau = new Cerveau(4);
        }

        public void Life()
        {
            /*Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double Valor = r.Next(1, 2);
                if (Cerveau.Reflexion(Valor) != Valor)
                {
                    Cerveau.Correction(Valor);
                }
                else
                {
                    Cerveau.Correction(Valor);
                }
            }*/

            Console.WriteLine("Entrainement terminé !");

            while (true)
            {
                Console.WriteLine("Donnez le nombre 0 ou 1 :");
                double Valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ritsu pense que c'est un : " + Cerveau.Reflexion(Valor));

                Console.WriteLine("Est-ce le cas ? (y/n)");
                string correction = Console.ReadLine().ToLower();

                if (correction == "n")
                {
                    Cerveau.Correction(Valor);
                }
            }
        }
    }
}
