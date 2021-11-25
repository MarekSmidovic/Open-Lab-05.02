using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {            
            int pocetInterpunkcii = 0;
            int miestoInterpunkcie = 0;
            if (sentence.Contains("!"))
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == '!')
                    {
                        pocetInterpunkcii++;
                    }
                }
                if (pocetInterpunkcii > 1) //na mazanie
                {
                    int lenNaMazanie = pocetInterpunkcii - 1;
                    miestoInterpunkcie = sentence.IndexOf("!") + 1;
                    sentence = sentence.Remove(miestoInterpunkcie, lenNaMazanie);
                }
            }
            else if (sentence.Contains("?"))
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == '?')
                    {
                        pocetInterpunkcii++;
                        miestoInterpunkcie = i;
                    }
                }
                if (pocetInterpunkcii > 1) //na mazanie
                {
                    int lenNaMazanie = pocetInterpunkcii - 1;
                    miestoInterpunkcie = sentence.IndexOf("?") + 1;
                    sentence = sentence.Remove(miestoInterpunkcie, lenNaMazanie);
                }
            }

            return sentence;




        }
    }
}
