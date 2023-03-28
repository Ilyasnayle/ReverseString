
/*C#9 - Aşağıdaki kelimelerden herhangi birini tersten yazacak uygulama hazırlayınız.
  İLAÇİÇALİ,  ALKASADASAKLA, KİMOKOMİK, EYKEKEMEKEKYE, MUMOMUMUMOMUM*/



using System;
using System.Text;

class Program{
static void Main(string[] args){
    Console.Write("Enter the String: ");

    string str = Console.ReadLine();

    char[] cArray = str.Normalize(NormalizationForm.FormKD).ToCharArray();
    Array.Reverse(cArray);
    string reversedString = new string(cArray);

    Console.WriteLine("Reversed String: " + reversedString);

    }
}
