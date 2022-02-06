namespace dotnet___poo.src.Entities
{
    // classe público Black que herda a classe Hero
    public class Black : Hero
    {
        // construtor com as características
        public Black(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        // sobrescreve o comportamento padrão com uma mensagem
        public override string Attack(){
             return this.Name + " Atacou com a sua Faca de Mythril.";
        }
    }
}