namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, int memoria) : base ( numero,  imei,  memoria)
        {
            
        }

        // Implementado
        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine("Instalando aplicativo iphone...");
        } 
    }
}