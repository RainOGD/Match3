using UnityEngine;

namespace Game.Scripts.Education
{
    public class Hero
    {
        // ?????? ?????
        public string Name;
        public float Hp;
        public float Damage;

        // ??????????? ?????
        
        public void SayPhrase()
        {
            Debug.Log("My name is " + Name);
        }

        public void CauseDamage(Hero targetHero)
        {
            targetHero.TakeDamage(Damage);
        }
        
        public void TakeDamage(float damage)
        {
            Hp = Hp - damage;
        }
    }
}