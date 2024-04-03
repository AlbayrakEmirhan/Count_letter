using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        string belgelerKlasoru = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string dosyaAdi = @"C:\\Users\\themi\\OneDrive\\Belgeler\\1mb-examplefile-com.txt";
        string path = Path.Combine(belgelerKlasoru, dosyaAdi);
        string text = File.ReadAllText(path);
        text = text.ToUpper();
        char[] array = text.ToCharArray();
        /*string[] array2 =
        {
            "A, B, C, Ç, D, E, F, G, Ğ, H, I, İ, J, K, L, M, N, O, Ö, P, R, S, Ş, T, U, Ü, V, Y, Z"
        };
        */
        //List<string> list = new List<string>(File.ReadAllLines(path));
        Dictionary<char, int> harfSayilari = new Dictionary<char, int>();
        foreach (char s in array)
        {
            if (char.IsLetter(s))
            {
                if (harfSayilari.ContainsKey(s) && harfSayilari.ContainsKey(s))
                {
                    harfSayilari[s]++;
                }
                else {
                    harfSayilari[s] = 1;
                     }
            }
        }
        foreach(var hs in harfSayilari) 
        {
            Console.WriteLine("{0} harfinin sayısı : {1}", hs.Key, hs.Value);
        }
    }
    }

