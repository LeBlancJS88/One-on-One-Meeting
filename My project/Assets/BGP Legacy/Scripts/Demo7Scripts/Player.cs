using UnityEngine;

namespace AD1020
{

public class Player
    {
        private string _playerName;
        private int _playerLevel;
        private string _playerRace;
        private string _playerClass;

        public int Age { get; private set; }


        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                    _playerName = value;
            }
        }

        public int PlayerLevel
        {
            get { return _playerLevel; }
            set
            {
                _playerLevel = value;
            }
        }

        public string PlayerRace
        {
            get { return _playerRace; }
            set
            {
                _playerRace = value;
            }
        }

        public string PlayerClass
        {
            get { return _playerClass; }
            set
            {
                _playerClass = value;
            }
        }

        public float ResistTotal()
        {
            int fire = 1;
            int water = 2;
            int earth = 3;
            int air = 4;
            return fire + water + earth + air;
        }


        public void PrintResist()
        {
            float sum = ResistTotal();
            if (sum <= 0)
            {
                Debug.Log("Resist total: " + sum);
            }
        }

        public Player(string pname, int plevel, string prace, string pclass, int page)
        {
            _playerName = pname;
            _playerLevel = plevel;
            _playerRace = prace;
            _playerClass = pclass;
            Age = page;
        }
    }
}
