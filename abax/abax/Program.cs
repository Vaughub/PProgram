using System;

namespace abax
{
	class Program
	{
		static void Main(string[] args)
		{
			//Printe informasjon om en en bil 1 med reg. nr NF123456, 147kw effekt, maksfart 200km / t, grønn farge av typen lett kjøretøy. 
			//Printe informasjon om en annen bil(bil 2) med reg. nr NF654321, 150kw effekt, maksfart 195km / t, blå farge og av typen lett kjøretøy

			Car carA = new Car("NF123456", 147, 200, "Lett kjøretøy", "Grønn");
			Car carB = new Car("NF654321", 150, 195, "Lett kjøretøy", "Blå");
			carA.Print();
			
		}
	}
}
