namespace Modelos {

  class Telefone : Contato{

    public string Modelo{
      get; set;
      
    }

    public string Numero{
      get; set;
      
    }

    public string Informar(){
      return "Modelo:" + this.Modelo + "\n" + 
        "Numero: " + this.Numero;



     }    
    
  }
}