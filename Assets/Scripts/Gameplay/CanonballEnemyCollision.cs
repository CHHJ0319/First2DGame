using Platformer.Core;
using Platformer.Mechanics;
using Platformer.UI;
using static Platformer.Core.Simulation;

namespace Platformer.Gameplay
{
    public class CanonballEnemyCollision : Simulation.Event<CanonballEnemyCollision>
    {
        public EnemyController enemy;
        public CanonballController canonball;

        public override void Execute()
        {

            var enemyHealth = enemy.GetComponent<Health>();
            if (enemyHealth != null)
            {
                enemyHealth.Decrement();
                if (!enemyHealth.IsAlive)
                {
                    MainUIController.Instance.UpdateEnemyKillCounter();
                    Schedule<EnemyDeath>().enemy = enemy;
                }
                else
                {

                }
            }
            else
            {
                MainUIController.Instance.UpdateEnemyKillCounter();
                Schedule<EnemyDeath>().enemy = enemy;
            }

        }
    }
}