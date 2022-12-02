using UnityEngine;

namespace AD1020
{

    public class RandomNameGenerator
    {
        private static string[] firstNameFrontSyllables = {"Ji", "Zev", "Glu", "Plai", "Droc", "Kle", "Es", "Fog", "Scel", "Nor",
            "Shii", "Leb", "Ank", "Whil", "Usce", "Ostro", "Oci", "Gy", "Ohe", "She" };
        private static string[] firstNameRearSyllables = {"ud", "um", "pri", "ip", "isc", "kleau", "aasc", "ur", "ceu", "ne", "up",
            "fi", "quoa", "ohf", "id", "urk", "ugh", "vu", "eb", "ye" };
        private static string[] lastNameFrontSyllables = {"Hul", "Xem", "Muc", "Opla", "Uvo", "Z'ph", "Fiv", "Umai", "Ateau", "Eti",
            "Jech", "Grov", "Iidi", "Brag", "Umoo", "Istri", "Gip", "Dahb", "Aski", "Nis" };
        private static string[] lastNameRearSyllables = {"krosco", "auclon", "auga", "ames", "airoiv", "ya", "klesk", "eausto",
            "drofri", "oisk", "boshaa", "berestro", "arik", "fu", "pheglu", "ba", "pob", "ucreri", "aprooka", "onajo" };

        public static string GenerateName()    
        {
            string randomFirstName = firstNameFrontSyllables[Random.Range(0, firstNameFrontSyllables.Length)] +
                                        firstNameRearSyllables[Random.Range(0, firstNameRearSyllables.Length)];

            string randomLastName = lastNameFrontSyllables[Random.Range(0, lastNameFrontSyllables.Length)] +
                                        lastNameRearSyllables[Random.Range(0, lastNameRearSyllables.Length)];

            return randomFirstName + " " + randomLastName;
        }

        private void OnEnable()
        {
            GenerateName();
        }
    }
}