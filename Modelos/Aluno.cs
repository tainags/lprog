namespace Modelos{

  class Aluno{

    
    private int periodo;

    public int Periodo{
      get => this.periodo;
      set {
        if (value > 0) {
        this.periodo = value;
      } else {
        this.periodo = 1;      
        }
      }
    }

    public string Nome{
      get; set;
    }

    public string Matricula{
      get; set;
    }
    
    public Aluno () : this(1) {
      
    }
    
      public Aluno(int periodo) {
        this.Periodo = periodo;
      
      
    }

    public bool Matricular(Disciplina disciplina){
       return this.Periodo == disciplina.Semestre;
    }

    public Aluno(string Matricula, string Nome) : this() {
      this.Matricula = Matricula;
      this.Nome = Nome;              
   }
    
   
    public Aluno(string Matricula, string Nome, int periodo) : this(periodo) {
      this.Matricula = Matricula;
      this.Nome = Nome;
               
   }
  }
}

