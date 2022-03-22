namespace AbstraindoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP1,int HP2, int MP1, int MP2) : base(Name, Level, HeroType, HP1, HP2, MP1, MP2){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP1 = HP1;
            this.HP2 = HP2;
            this.MP1 = MP1;
            this.MP2 = MP2;  
        }
    public override string Attack(){
            return this.Name + "atacou com estrela ninja";
        }

        public string Attack(int Bonus){

            if(Bonus > 6){

                return this.Name + "atacou com estrela ninja com bônus de " + Bonus;

            }else{
                return this.Name +" " + "realizou ataque fraco com a estrela ninja com bônus de " + Bonus;
            }
    }
    }
}