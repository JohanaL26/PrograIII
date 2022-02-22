namespace LibreriaClases;

public class Coche
{
    //Atributos

        private int id;
        //private string marca;
        //private string modelo;
        //private string precio;
        //private string km;


    //Propiedades
    public int Id { get => id; set => id =value; } 
    public string Marca { get;set; } //otra forma de hacerlo directamente sin necesidad de declarar atruibuto
    public string Modelo { get; set; }
    public decimal Precio { get; set; }
    public int Km { get; set; }

    //Constructor
    public Coche() //contructor sin parametros o por defecto
    {
    } 
    public Coche( int id, string marca) //constructor con parametros
    { 
        Id= id;
        Marca= marca;
    }

    //Metodos 
    public string DevolverSatosCoche()
    {
        return "Id: " + Id + " Marca: " + Marca + " Modelo: " + Modelo;
    }
    //+ " Precio: " + precio + " Km: " + Km

}
