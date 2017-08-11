namespace BD_CSharp
{
    public class AlunoAplicacao
   {
       private Contexto contexto;

       public void Insert(Aluno aluno)
       {
           var strQuery = "";
            strQuery += "INSERT INTO Aluno (Nome,Mae,DataNascimento)";
           strQuery += $"VALUES ('{aluno.Nome}','{aluno.Mae}','{aluno.DataNascimento}')";

           using ( contexto = new Contexto())
           {
               contexto.ExecutaComando(strQuery);
           }
       }

       public void Alterar(Aluno aluno)
       {
           var strQuery = "";
           strQuery += "UPDATE Aluno SET ";
           strQuery += $"Nome = {aluno.Nome},";
           strQuery += $"Mãe = {aluno.Mae},";
           strQuery += $"DataNascimento = {aluno.DataNascimento},";
           strQuery += $"WHERE AlunoId  = {aluno.Id},";
           using (contexto = new Contexto())
           {
              contexto.ExecutaComando(strQuery);     
           }
       }
    }
}
