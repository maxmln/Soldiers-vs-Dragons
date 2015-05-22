using UnityEngine;
using System.Collections;

public class Level17 : Levels
{

    public static bool isLevelCompleted = false;

    public GameObject dragonFly;
    public GameObject dragonWarrior;
    public GameObject dragonKnight;
    public GameObject whiteDragon;
    public GameObject blackDragon;

    // Use this for initialization
    void Start()
    {
        addEnemy(dragonWarrior, 14);
        addEnemy(dragonKnight, 15);

        addEnemy(dragonWarrior, 21);
        addEnemy(dragonFly, 23);
        addEnemy(dragonKnight, 25);

        addEnemy(blackDragon, 30);

        addEnemy(dragonKnight, 32);
        addEnemy(dragonWarrior, 34);
        addEnemy(blackDragon, 36);
        addEnemy(whiteDragon, 38);

        addEnemy(whiteDragon, 40);
        addEnemy(dragonWarrior, 41);
        addEnemy(dragonKnight, 42);
        addEnemy(blackDragon, 44);
        addEnemy(whiteDragon, 45);
        addEnemy(dragonWarrior, 47);
        addEnemy(dragonKnight, 49);
        addEnemy(blackDragon, 51);

        addEnemy(dragonKnight, 53);
        addEnemy(blackDragon, 54);
        addEnemy(whiteDragon, 56, 4);
        addEnemy(dragonWarrior, 56, 3);
        addEnemy(dragonWarrior, 56, 2);

        addEnemy(whiteDragon, 60);
        addEnemy(dragonKnight, 61);
        addEnemy(whiteDragon, 62, 2);
        addEnemy(blackDragon, 63, 1);

        addEnemy(whiteDragon, 64);
        addEnemy(dragonFly, 65);
        addEnemy(whiteDragon, 66);
        addEnemy(dragonFly, 67);

        addEnemy(whiteDragon, 68);
        addEnemy(dragonFly, 69);
        addEnemy(whiteDragon, 70);
        addEnemy(blackDragon, 71);

    }

    // Update is called once per frame
    void Update()
    {
        goToNextLevel();
    }
}
