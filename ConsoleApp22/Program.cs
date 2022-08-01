using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int healthPlayer = random.Next(450, 501);
            int healthBoss = random.Next(400, 601);
            int damageBoss;
            int shadowBall = 50;
            int mindBlast = 100;
            int soulFire = 200;
            int heal = 300;
            string useSpell;
            bool startFight = true;

            Console.WriteLine("Выберете заклинания для боя с боссом: \n 1) shadowball - Шар тьмы наносит 50 урона." +
                " \n 2) mindblast - Взрыв разума наносит 100 урона. \n 3) soulfire - Ожог души наносит 200 урона.(можно использовать если у босса больше здоровья чем у игрока) " +
                "\n 4) heal - Восстанавливает 300 здоровья. (можно использовать если у босса больше здоровья чем у игрока)");

            while (startFight)
            {
                damageBoss = random.Next(100, 151);
                Console.WriteLine("\nКоличество здоровья игрока - " + healthPlayer);
                Console.WriteLine("Количество здоровья босса - " + healthBoss + ". Урон босса - " + damageBoss);
                Console.Write("Выберете заклинание: ");
                useSpell = Console.ReadLine();
                if (healthPlayer <= 0)
                {
                    startFight = false;
                    Console.WriteLine("\nИгрок погиб");
                }
                else if (healthBoss <= 0)
                {
                    startFight = false;
                    Console.WriteLine("\nИгрок победил");
                }
                else
                {
                    switch(useSpell)
                    {
                        case "shadowball":
                            if(healthPlayer>0)
                            {
                                healthBoss -= shadowBall;
                                Console.WriteLine("\nБосс потерял " + shadowBall + " здоровья");
                                healthPlayer -= damageBoss;
                                Console.WriteLine("\nПосле атаки босса игрок потерял " + damageBoss + " здоровья");
                            }
                            break;
                        case "mindblast":
                            if(healthPlayer>0)
                            {
                                healthBoss -= mindBlast;
                                Console.WriteLine("\nБосс потерял " + mindBlast + " здоровья");
                                healthPlayer -= damageBoss;
                                Console.WriteLine("\nПосле атаки босса игрок потерял " + damageBoss + " здоровья");
                            }
                            break;
                        case "soulfire":
                            if(healthPlayer<healthBoss)
                            {
                                healthBoss -= soulFire;
                                Console.WriteLine("\nБосс потерял " + soulFire + " здоровья");
                                healthPlayer -= damageBoss;
                                Console.WriteLine("\nПосле атаки босса игрок потерял " + damageBoss + " здоровья");
                            }
                            else
                            {
                                Console.WriteLine("\nПока вы не можете использовать данное заклинание.");
                            }
                            break;
                        case "heal":
                            if(healthPlayer<healthBoss)
                            {
                                healthPlayer += heal;
                                Console.WriteLine("\nВы восстановили " + heal + " здоровья");
                                healthPlayer -= damageBoss;
                                Console.WriteLine("\nПосле атаки босса игрок потерял " + damageBoss + " здоровья");
                            }
                            else
                            {
                                Console.WriteLine("\nПока вы не можете использовать данное заклинание.");
                            }
                            break;
                        default:
                            Console.WriteLine("\nНеизвестно это заклинание");
                            break;
                    }
                }
            }
        }
    }
}
