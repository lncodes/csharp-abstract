﻿using System;

namespace Lncodes.Example.Abstract
{
    public class Program
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// Constructor
        /// </summary>
        protected Program() { }

        /// <summary>
        /// Main program
        /// </summary>
        private static void Main()
        {
            var enemyId = GetRandomEnemyTypesId();
            var enemy = CreateEnemyTypes(enemyId);
            enemy.Run();
            enemy.Walk();
            enemy.Attack();
        }
              
        /// <summary>
        /// Method to random enemy
        /// </summary>
        /// <return cref="EnemyController"></return>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when random value > 2</exception>
        private static EnemyController CreateEnemyTypes(int enemyId)
        {
            switch (enemyId)
            {
                case 0:
                    return new OrcEnemyController();
                case 1:
                    return new TrollEnemyController();
                case 2:
                    return new GoblinEnemyController();
                default:
                    throw new ArgumentOutOfRangeException(nameof(enemyId));
            }
        }

        /// <summary>
        /// Method for random enemy types id
        /// </summary>
        /// <returns cref=int></returns>
        private static int GetRandomEnemyTypesId()
        {
            var ammountOfEnemyTypes = 3;
            return random.Next(ammountOfEnemyTypes);
        }

    }
}