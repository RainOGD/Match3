using UnityEngine;

namespace Game.Scripts.Education
{
    public class Dota : MonoBehaviour
    {
        private void Start()
        {
            Hero phantomAssasin = new Hero {Name = "PA", Hp = 100, Damage = 20};
            phantomAssasin.SayPhrase();

            Hero crystalMaiden = new Hero {Name = "CM", Hp = 70, Damage = 50};
            crystalMaiden.SayPhrase();

            phantomAssasin.CauseDamage(crystalMaiden);
        }
    }
}