namespace AbstraindoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level , string HeroType, int HP1,int HP2, int MP1, int MP2){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP1 = HP1;
            this.HP2 = HP2;
            this.MP1 = MP1;
            this.MP2 = MP2;        }
        public string Name;
        public int Level;

        public string HeroType;

        public int HP1;

        public int HP2;

        public int MP1;

        public int MP2;

        public override string ToString(){
            return this.Name+" "+ this.Level+ " "+ this.HeroType+ " "+ this.HP1 + " " + this.HP2+ " " + this.MP1 + " " + this.MP2 + " "; 
        }

        public virtual string Attack(){
            return this.Name + " " + "atacou com a sua espada";
        }


    }
}