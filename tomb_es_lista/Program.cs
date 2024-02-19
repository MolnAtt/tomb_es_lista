using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb_es_lista
{
	internal class Program
	{

		static string Stringbe(int[] t, string separator=" ", string start="[ ", string end=" ]")
		{
			if (t.Length==0) 
			{ 
				return start + end; 
			}
			
			string result = start;
			for (int i = 0; i < t.Length - 1; i++)
			{
				result += $"{t[i]}" + separator;
			}
			result += t[t.Length - 1];
			return result + end;
			// default: "[ 0 10 0 0 0 ]";
		}

		static void Main(string[] args)
		{
			// Tömb

			// pl. egy számtömb:

			int[] t = new int[5]; // egyből 5 elemű lesz.

			// pl. egy string-tömb:

			string[] st = new string[5];
			// a tömb létrehozásakor KÖTELEZŐ megmondani annak méretét.
			// ami aztán nem is változhat.

			Console.WriteLine(t[0]); // ő itt az első elem
									 // mivel az int-nek van alapértelmezett értéke,
									 // a 0, ezért ez 0 lesz.
			Console.WriteLine(t[4]); // Ez az utolsó elem!
									 // ha olyan elemet kérdezel le,
									 // ami nincs, akkor errort ad!

			Console.WriteLine(t.Length);

			t[1] = 10; // a második elem értéke 10 lesz.

			for (int i = 0; i < t.Length; i++)
			{
				Console.WriteLine($"{i+1}. [{i}] {t[i]}");
			}

			string s = Stringbe(t, ", ", "[", "]");
			Console.WriteLine(s);
			int[] t2 = new int[12];
			t2[10] = 9;
			t2[3] = -1;
			Console.WriteLine(Stringbe(t2));
			int[] t3 = new int[0];
			Console.WriteLine(Stringbe(t3));

			Console.ReadKey();


		}
	}
}
