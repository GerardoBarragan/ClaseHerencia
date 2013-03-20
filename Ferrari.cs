using System;

namespace Claseherencia
{
	public class Ferrari : Automovil {

		private string tipo;
	    
	    public string Tipo {
		get {
			return tipo;
		}
		set {
			tipo = value;
		}
	}

	
		public Ferrari ()
		{
				this.tipo="";

		}

		public void ingresarTipo(Ferrari automovil){
				Console.WriteLine("Ingresa el tipo de ferrari");
				automovil.tipo = Console.ReadLine();
			}

		public void imprimirTipo(Ferrari automovil){
				Console.WriteLine("El tipo de ferrari es:"+Tipo);
			}
	}
}

