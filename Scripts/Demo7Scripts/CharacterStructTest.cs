using UnityEngine;

namespace AD1020
{

    public class CharacterStructTest : MonoBehaviour, IPlayable
    {

        public struct CharacterSheet
        {
            string characterName;
            public string CharacterRace { get; set; }
            public string CharacterClass { get; set; }
            int characterHP;
            public int characterLevel;
            public int CharacterExp;
            public string SetName()
            {
                characterName = "What is your name?";
                return characterName;
            }

            public string SetRace()
            {
                CharacterRace = "Select race";
                return CharacterRace;
            }
            public string SetClass()
            {
                CharacterClass = "Select class";
                return CharacterClass;
            }
            public int SetLevel()
            {
                characterLevel = 1;
                return characterLevel;
            }
            public int SetHP()
            {
                CharacterHP = Random.Range(50, 100);
                return CharacterHP;
            }
            public string CharacterName
            {
                get { return CharacterName; }
                set
                {
                    if (value is string)
                    {
                        CharacterName = value;
                    }
                }
            }
            public int CharacterHP
            {
                get { return characterHP; }
                set
                {
                    if (value is int)
                    {
                        characterHP = value;
                    }
                }
            }
            public int CharacterLevel
            {
                get { return characterLevel; }
                set
                {
                    if (value is int)
                    {
                        characterLevel = value;
                    }
                }
            }
        }
        CharacterSheet characterInfo;

        void Start()
        {
            characterInfo.SetName();
            characterInfo.SetRace();
            characterInfo.SetClass();
            characterInfo.SetHP();
            characterInfo.SetLevel();
            TestFunction();
        }
        protected void TestFunction()
        {
            Debug.Log("Character Name is = " + characterInfo.CharacterName);
            Debug.Log("Character race is = " + characterInfo.CharacterRace);
            Debug.Log("Character Class is = " + characterInfo.CharacterClass);
            Debug.Log("Character HP is = " + characterInfo.CharacterHP);
            Debug.Log("Character Mana is = " + characterInfo.CharacterLevel);
        }
        public CharacterStructTest(string name, string playerRace, string playerClass, int hp, int level)
        {
            characterInfo.CharacterName = name;
            characterInfo.CharacterRace = playerRace;
            characterInfo.CharacterClass = playerClass;
            characterInfo.CharacterHP = hp;
            characterInfo.CharacterLevel = level;
        }

        public virtual void Playable()
        {
            Debug.Log(name + " has been selected.");
        }
    }
}
