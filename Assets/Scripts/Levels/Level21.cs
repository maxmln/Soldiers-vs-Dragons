using UnityEngine;
using System.Collections;

public class Level21 : Levels
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
        addEnemy(blackDragon, 14,2);
        addEnemy(dragonKnight, 15,2);
        addEnemy(blackDragon, 14,1);
        addEnemy(dragonKnight, 15,4);
        addEnemy(blackDragon, 14,3);
        addEnemy(dragonKnight, 15,3);

        addEnemy(dragonWarrior, 21);
        addEnemy(blackDragon, 23);
        addEnemy(dragonKnight, 25);

        addEnemy(blackDragon, 30);

        addEnemy(dragonKnight, 32);
        addEnemy(dragonWarrior, 34);
        addEnemy(blackDragon, 36);
        addEnemy(blackDragon, 38);

        addEnemy(whiteDragon, 40);
        addEnemy(blackDragon, 41);
        addEnemy(blackDragon, 42);
        addEnemy(blackDragon, 44);
        addEnemy(whiteDragon, 45);
        addEnemy(dragonWarrior, 47);
        addEnemy(dragonKnight, 49);
        addEnemy(blackDragon, 51);

        addEnemy(dragonKnight, 53);
        addEnemy(blackDragon, 54);
        addEnemy(whiteDragon, 56, 4);
        addEnemy(blackDragon, 56, 3);
        addEnemy(blackDragon, 56, 2);

        addEnemy(whiteDragon, 60);
        addEnemy(dragonKnight, 61);
        addEnemy(whiteDragon, 62, 2);
        addEnemy(blackDragon, 63, 1);

        addEnemy(whiteDragon, 64);
        addEnemy(dragonFly, 65);
        addEnemy(whiteDragon, 66);
        addEnemy(dragonFly, 67);

        addEnemy(whiteDragon, 68);
        addEnemy(blackDragon, 69);
        addEnemy(whiteDragon, 70);
        addEnemy(blackDragon, 71);

        addEnemy(whiteDragon, 72);
        addEnemy(dragonFly, 73);
        addEnemy(whiteDragon, 74);
        addEnemy(blackDragon, 75);
        addEnemy(whiteDragon, 76);
        addEnemy(dragonFly, 78, 3);
        addEnemy(whiteDragon, 78, 2);
        addEnemy(blackDragon, 78, 1);
    }

    // Update is called once per frame
    void Update()
    {
        goToNextLevel();
    }
}
