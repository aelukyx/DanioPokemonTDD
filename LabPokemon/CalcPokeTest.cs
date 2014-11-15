using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using MasterPokemon;

namespace LabPokemon
{
    [TestFixture]
    public class CalcPokeTest
    {

        private PokemonBattle pokemonBattle { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            pokemonBattle = new PokemonBattle();
        }

        [Test]
        public void TestBattleAguaElec8y4()
        {
            // Act
            var result = pokemonBattle.CalcularDanho("AGUA", "ELECTRICO", 8, 4);

            // Assert
            Assert.AreEqual(100, Convert.ToInt32(result));
        }

        [Test]
        public void TestBattleAguaHier15y20()
        {
            // Act
            var result = pokemonBattle.CalcularDanho("AGUA", "HIERBA", 15, 20);

            // Assert
            Assert.AreEqual(19, Convert.ToInt32(result));
        }

        [Test]
        public void TestBattleFuegFueg17y13()
        {
            // Act
            var result = pokemonBattle.CalcularDanho("FUEGO", "FUEGO", 17, 13);

            // Assert
            Assert.AreEqual(33, Convert.ToInt32(result));
        }



    }
}
