using System;

namespace Claseherencia
{
	public class Automovil
	{
		public string nombre;
		public string color;

			public Automovil()
	{
			this.color = "";

		}
		 
		public void ingresaDatos(Automovil autoCual){
			Console.WriteLine ("Ingresa el nombre del automovil");
			autoCual.nombre = Console.ReadLine ();
			Console.WriteLine ("Ingresa el color del automovil");
			autoCual.color = Console.ReadLine ();
		}

		public void imprimirDatos(Automovil autocual){
			Console.WriteLine("nombre:"+autocual.nombre);
			Console.WriteLine("color:"+autocual.color);

		
		}
	}
}
