using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPokemon
{
    public class PokemonBattle
    {
        double damageTotal;

        public double CalcularDanho(string tipo1, string tipo2, double attack, double defense)
        {
            var efficacy = new Dictionary<string, double>();

            efficacy.Add("FUEGO.FUEGO", 0.5); efficacy.Add("FUEGO.HIERBA", 2); efficacy.Add("FUEGO.ELECTRICO", 1); efficacy.Add("FUEGO.AGUA", 0.5);
            efficacy.Add("HIERBA.FUEGO", 0.5); efficacy.Add("HIERBA.HIERBA", 0.5); efficacy.Add("HIERBA.ELECTRICO", 1); efficacy.Add("HIERBA.AGUA", 2);
            efficacy.Add("ELECTRICO.FUEGO", 1); efficacy.Add("ELECTRICO.HIERBA", 0.5); efficacy.Add("ELECTRICO.ELECTRICO", 0.5); efficacy.Add("ELECTRICO.AGUA", 2);
            efficacy.Add("AGUA.FUEGO", 2); efficacy.Add("AGUA.HIERBA", 0.5); efficacy.Add("AGUA.ELECTRICO", 1); efficacy.Add("AGUA.AGUA", 0.5);
            
            damageTotal = 50 * (attack / defense) * efficacy[(tipo1+"."+tipo2)];

            return  damageTotal;

        }
    }
}
