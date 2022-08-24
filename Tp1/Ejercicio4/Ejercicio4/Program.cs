

internal class Program {

    static void Main()
    {
        string numeroWrapper = "";
        string digitoWrapper = "";
        string resultadoBusqueda = "";
        Boolean hayCoincidencia = false;
        cargaDatos();

        buscarCoincidencia();

        mostrarResultado();





        //método para cargar los datos 
        void cargaDatos(){

           

            Console.Write("Por favor ingrese un numero :" );
             numeroWrapper = Console.ReadLine();
            Console.Write("Por favor ingrese un digito :");
            digitoWrapper = Console.ReadLine();

            if ((numeroWrapper !="" )&& (digitoWrapper !="")) {

                Console.WriteLine("Datos Cargados Correctamente");


            }
           

        }
        
        //método para buscar la coincidencia
        void buscarCoincidencia() {
            int longitud = numeroWrapper.Length;
           
            for (int i = 0; i <longitud; i++)
            {
                resultadoBusqueda = numeroWrapper.Substring(i,1);

                if (resultadoBusqueda==digitoWrapper) {
                    hayCoincidencia = true;                
                }

            }

        }

        //mostrar resultados
        void mostrarResultado() {
            Console.WriteLine(hayCoincidencia);
        }

    }
}
