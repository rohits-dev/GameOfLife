using Mckinsey.GameOfLifeEngine;
using Mckinsey.GameOfLifeUI;
using Mckinsey.GameOfLifeUI.Base;

namespace Mckinsey.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            //fetch the dependencies - here we just create them
            var neighbourCalculator = new NeighbourCalculator();
            var gameRules = new GameRules(new LiveCellRule(), new DeadCellRule());
            var evolution = new Evolution(neighbourCalculator, gameRules);
            var gridRowColumnParser = new GridRowColumnParser();
            //typically we would create such an object and inject its dependencies
            //using an IoC container
            IGameOfLife gameOfLife = new GameOfLifeUI.GameOfLife(evolution, gridRowColumnParser);
            gameOfLife.Start();

        }
    }
}