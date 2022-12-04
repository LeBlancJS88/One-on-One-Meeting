using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{

    public class Enemy : MonoBehaviour
    {
        public string enemyName;
        public int health = 10;
        public int level = 1;
        public int strength = 5;
        public int dexterity = 5;
        public int constitution = 5;
        public int intelligence = 5;
        public int wisdom = 5;
        public int charisma = 5;
        public int experience = 100;

       

        public const bool isEnemy = true;
        public const bool containsLoot = true;

        public const int elementalResist = fireResist + iceResist + lightningResist + poisonResist;

        [SerializeField] private const int fireResist = 0;
        [SerializeField] private const int iceResist = 0;
        [SerializeField] private const int lightningResist = 0;
        [SerializeField] private const int poisonResist = 0;

        void Start()
        {
            enemyName = RandomNameGenerator.GenerateName();
            SetStatistics(enemyName, 20, 1, 5, 5);
            PrintGreeting();
        }

        protected void SetStatistics(string setName, int setHp, int setLevel, int setStr, int setXp)
        {
            enemyName = setName;
            health = setHp;
            level = setLevel;
            strength = setStr;
            experience = setXp;
        }

        protected void PrintGreeting()
        {
            Debug.Log(string.Format("Behold! I am {0}. My extensive exercise regimen has endowed me with {1} HP! I'm level {2}, touch me if you dare!", enemyName, health.ToString(), level.ToString()));
        }
    }
}