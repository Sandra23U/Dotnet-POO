namespace dotnet___poo.src.Entities
{
    // classe público Wizard que herda a classe Hero
    public class Wizard: Hero
    {
        // construtor com as características

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        // sobrescreve o comportamento padrão com uma mensagem
        public override string Attack(){
            return this.Name + "Lançou Magia";
        }
        // método de ataque com bônus
        public string Attack(int Bonus){
            // se o bônus for maior que 6 mostra uma mensagem, caso contrário mostra outra mensagem
            if (Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else{
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
       
    }
}