namespace DesafioPOO.Models
{
    // Implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, int memoria) : base ( numero,  imei,  memoria)
        {
            
        }

        // Implementado
        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine("Instalando aplicativo nokia...");
        } 
    }
}