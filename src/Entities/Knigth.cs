namespace dotnet___poo.src.Entities
{
    // classe público Knight que herda a classe Hero
    public class Knigth: Hero
    {
        // construtor com as características
        public Knigth(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
 
    }
}