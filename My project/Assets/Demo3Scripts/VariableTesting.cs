using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTesting : MonoBehaviour
{
    //~Demo 2~ Using these simple variables we can create a rudimentary set of statistics for a character in an RPG.//
    public GameObject MainCharacter;
    //~Biographical Information~//
    public string CharacterName = "John Brown";
    public string CharacterRace = "Human";
    public string CharacterClass = "Fighter";
    private string CharacterFavoriteFood = "Peanut butter";
    private string CharacterHates = "Goblins";
    //~Modifiable Statistics~//
    public int CharacterHitPoints = 14;
    public int CharacterLevel = 1;
    private int CharacterAge = 33;
    private int Strength = 16;
    private int Dexterity = 14;
    private int Constitution = 18;
    private int Wisdom = 10;
    private int Intelligence = 10;
    private int Charisma = 10;
    //~Elemental Resistances~//
    private int FireResistance = 10;
    private int AirResistance = 10;
    private int EarthResistance = 10;
    private int WaterResistance = 10;
    private int PoisonResistance = 10;
    //~Catchphrases~//
    public string BattleCry = "Have at thee!";
    public string DeathCry = "My leg!";
    public string LevelUpShout = "I don't skip leg day!";
    public string VictoryCry = "I'm the best!";

    //Awake is used to initialize any variables or game state before the game starts.
    //Awake is called only once during the lifetime of the script instance.
    //Awake is called after all objects are initialized so you can safely speak to other objects or query them using eg.
    //GameObject.FindWithTag. Each GameObject's Awake is called in a random order between objects. Because of this, you
    //should use Awake to set up references between scripts, and use Start to pass any information back and forth.
    //Awake is always called before any Start functions. This allows you to order initialization of scripts. Awake can not act as a coroutine.
    private void Awake()
    {
        CharacterSelect();
    }

    //Start is called on the frame when a script is enabled just before any of the Update methods are called the first time.
    //Like the Awake function, Start is called exactly once in the lifetime of the script.However, Awake is called when the
    //script object is initialised, regardless of whether or not the script is enabled.Start may not be called on the same frame
    //as Awake if the script is not enabled at initialisation time.

    //The Awake function is called on all objects in the Scene before any object's Start function is called. This fact is useful in
    //cases where object A's initialisation code needs to rely on object B's already being initialised; B's initialisation should be
    //done in Awake, while A's should be done in Start.

    //Where objects are instantiated during gameplay, their Awake function is called after the Start functions of Scene objects have already completed.
    //The Start function can be defined as a Coroutine, which allows Start to suspend its execution(yield).
    private void Start()
    {
        CharacterNoise();
    }
    // Here is a public method
    public void PublicExample()
    {
        //public: The type or member can be accessed by any other
        //code in the same assembly or another assembly that references it.
        //The accessibility level of public members of a type is controlled
        //by the accessibility level of the type itself.
    }

    // Here is a private method
    private void PrivateExample()
    {
        //private: The type or member can be accessed only by code in the same class or struct.
    }

    //Play mode observations
    private void PlayMode()
    {
        //Changes made to a public variable during play mode are for testing purposes only, changes
        //revert to the original value defined in the script on exiting play mode. To permanently change
        //the value of a variable, it should be changed in the script and not through the inspector.
    }

    public void CharacterSelect()
    {
        Debug.Log("You picked me? Are you sure?");
        Debug.Log("Ok." + "I'm " + CharacterName + ", " + "I'm a " + CharacterAge + " year old" + " " + "level " + CharacterLevel + " " + CharacterRace + " " + CharacterClass + ". " + "I have " + CharacterHitPoints + " hit points.");
    }

    public void CharacterNoise()
    {
        Debug.Log("I love " + CharacterFavoriteFood + "!" + "I hate " + CharacterHates + "!" + " " + VictoryCry + " " + LevelUpShout);

    }

    //Update runs once per frame.FixedUpdate can run once, zero, or several times per frame,
    //depending on how many physics frames per second are set in the time settings, and how fast/slow the framerate is.

    //It's for this reason that FixedUpdate should be used when applying forces, torques, or other physics-related functions -
    //because you know it will be executed exactly in sync with the physics engine itself.
    //Whereas Update() can vary out of step with the physics engine, either faster or slower, depending on how much of a load
    //the graphics are putting on the rendering engine at any given time, which - if used for physics - would give correspondingly
    //variant physical effects!
    private void Update()
    {
        
    }
}
