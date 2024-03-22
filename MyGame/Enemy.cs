using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health = 100;
        private float shield = 0;
        static int pwrupnum;

        static void initStatic()
        {
            pwrupnum = 0;
        }
        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
            initStatic();
        }

        public string GetName()
        {
            return name;
        }


        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield<0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health<0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public static int GetPowerUps()
        {
            return pwrupnum;
        }
        public float GetShield()
        {
            return shield;
        }

        public string SetName(string name)
        {
            int MaxLength = 8;
            if (name.Length > MaxLength)
            name = name.Substring(0,MaxLength);
            return name;
        }

        public void PickupPowerUp(PowerUp pwrup, float vlr)
        {
            if (pwrup == PowerUp.health)
            {
                health += vlr;
                if (health>100) health = 100;
                pwrupnum += 1;
            }
            else if (pwrup == PowerUp.shield)
            {
                shield += vlr;
                if (shield>100) shield = 100;
                pwrupnum += 1;
            }
            else
            Console.WriteLine("Invalid power up"); 
        }
    }
}