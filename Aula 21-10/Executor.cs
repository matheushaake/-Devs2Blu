using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21_10
{
    public interface IAutenticavel
    {
        void Autenticar();
        void Deslogar();
    }

    public class UsuarioSistema : IAutenticavel
    {
        public void Autenticar()
        {
            Console.WriteLine("Usuário autenticado");
        }
        public void Deslogar()
        {
            Console.WriteLine("Deslogado com sucesso");
        }
    }
    public interface IMotor
    {
        void Ligar();
        void Desligar();
    }
   
    public interface ICambioManual
    {
        void ColocarMarchaAcima();
        void ColocarMarchaAbaixo();
    }
    public class Gol : IMotor, ICambioManual
    {
        public void ColocarMarchaAbaixo() 
        {
            Console.WriteLine("Reduziu a marcha");
        }
        public void ColocarMarchaAcima()
        {
            Console.WriteLine("Aumentou a marcha");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando motor");
        }
        public void Desligar()
        {
            Console.WriteLine("Desligando motor");
        }
    }
    
    public abstract class Forma
    {
        public abstract void CalcularArea();
        
        public int Base { get; set; }
        public int Altura { get; set; }
        
        

    }



    public class Triangulo : Forma
    {
        // base => Palavra reservada -> Precisa colocar @
        public Triangulo(int @base, int altura)
        {
            Base = @base;
            Altura = altura;
        }
        public override void CalcularArea()
        {
            Console.WriteLine($"O resultado do calculo é: {(Base * Altura) / 2}");
        }
    }

    public class Retangulo : Forma
    {
        // base => Palavra reservada -> Precisa colocar @
        public Retangulo(int @base, int altura)
        {
            Base = @base;
            Altura = altura;
        }
        public override void CalcularArea()
        {
            Console.WriteLine($"O resultado do calculo é: {Base * Altura}");
        }
    }
    public abstract class RegistroDB
    {
        
        protected abstract string NomeTabela { get; }
        public void Select()
        {
            var select = $"SELECT * FROM {NomeTabela}";
            Console.WriteLine($"Executando o select no banco de dados: {select}");
        }
    }

    public class PessoaDB : RegistroDB
    {
        protected override string NomeTabela { get => "PESSOAS"; }
    }

    public class ProdutoDB : RegistroDB
    {
        // protected override string NomeTabela => "PRODUTOS";
        protected override string NomeTabela { get => "PRODUTOS"; }
    }
    public class Executor
    {
      
        public static void Executar()
        {
            var usuario = new UsuarioSistema();
            usuario.Autenticar();
            usuario.Deslogar();

          var registro = new PessoaDB();
            registro.Select();

        var registro2 = new ProdutoDB();
        registro2.Select();

            var triangulo = new Triangulo(2,5);
            triangulo.CalcularArea();
            var retangulo = new Retangulo(2, 5);
            retangulo.CalcularArea();
        }
    }
}
