using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerInfo[0];
                if (trainers.ContainsKey(trainerName) == false)
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
                string pokemonName = trainerInfo[1];
                string pokemonType = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonType, pokemonHealth);
                trainers[trainerName].Pokemons.Add(pokemon);
            }
            while ((input = Console.ReadLine()) != "End")
            {


                foreach (var item in trainers)
                {
                    if (item.Value.Pokemons.Any(x=>x.Element==input))
                    {
                        item.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in item.Value.Pokemons)
                        {
                            pokemon.Health -= 10;                            
                        }
                    }
                    item.Value.Pokemons.RemoveAll(x => x.Health <= 0);                    
                }                
            }
            
            foreach (var item in trainers.OrderByDescending(x=>x.Value.Badges))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
