using System.Collections.Generic;

namespace Tabela
{
    public class Campeonato
    {
        public List<Equipe> equipes;

        public Campeonato(){
            this.equips = new List<Equip>();
        }

        public void resultado() {
            this.equips.ForEach(delegate(Equip e){
                System.Console.WriteLine($"Equipe: {e.nome} - Pontuação: {e.pontuacao}");
            });        
        }
    }
}
