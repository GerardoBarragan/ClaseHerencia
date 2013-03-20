using System;

namespace Claseherencia
{
	class Principal
	{
		public static void Main (string[] args)
		{
			Ferrari coche = new Ferrari ();
			coche.ingresarTipo(coche);
			coche.ingresarDatos(coche);
			coche.imprimirDatos(coche);
			coche.imprimirTipo(coche);

		}
		
	}
}

