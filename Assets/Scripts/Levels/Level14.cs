using UnityEngine;
using System.Collections;

public class Level14 : Levels
{

    public static bool isLevelCompleted = false;

    public GameObject dragonFly;
    public GameObject dragonWarrior;
    public GameObject dragonKnight;
    public GameObject whiteDragon;

    // Use this for initialization
    void Start()
    {
        addEnemy(dragonKnight, 14);
        addEnemy(dragonWarrior, 15);

        addEnemy(dragonFly, 21);
        addEnemy(dragonKnight, 23);
        addEnemy(dragonKnight, 25);

        addEnemy(dragonWarrior, 30);
        addEnemy(whiteDragon, 31);
        addEnemy(dragonKnight, 33);
        addEnemy(dragonWarrior, 34);

        addEnemy(whiteDragon, 40);
        addEnemy(dragonWarrior, 41);
        addEnemy(dragonKnight, 42);
        addEnemy(dragonFly, 44);
        addEnemy(whiteDragon, 45);
        addEnemy(dragonWarrior, 47);
        addEnemy(dragonKnight, 49);
        addEnemy(dragonFly, 51);

        addEnemy(dragonKnight, 53);
        addEnemy(dragonKnight, 54);
        addEnemy(whiteDragon, 56,4);
        addEnemy(dragonWarrior, 56, 3);
        addEnemy(dragonWarrior, 56, 2);

        addEnemy(whiteDragon, 60);
        addEnemy(dragonKnight, 61);
        addEnemy(whiteDragon, 62, 2);
        addEnemy(dragonFly, 63, 1);

        addEnemy(whiteDragon, 64);
        addEnemy(dragonFly, 65);
        addEnemy(whiteDragon, 66);
        addEnemy(dragonFly, 67); 

        addEnemy(whiteDragon, 68);
        addEnemy(dragonFly, 69);
        addEnemy(whiteDragon, 70);
        addEnemy(dragonFly, 71);
    }

    // Update is called once per frame
    void Update()
    {
        goToNextLevel();
    }
}
