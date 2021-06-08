namespace Exercicio3
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;

        private const float MaxHealth = 100;
        private const float MaxShield = 100;

        public Enemy(string name)
        {
            SetName(name);
            health = MaxHealth;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageLeft = -shield;
                shield = 0;
                health -= damageLeft;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float gain)
        {
            if (powerUp == PowerUp.Health)
            {
                health += gain;
                if (health > MaxHealth) health = MaxHealth;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += gain;
                if (shield > MaxShield) shield = MaxShield;
            }
        }
    }
}
