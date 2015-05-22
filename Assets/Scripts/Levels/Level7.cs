using UnityEngine;
using System.Collections;

public class Level7 : Levels
{

    public static bool isLevelCompleted = false;
    public GameObject dragonFly;
    public GameObject dragonWarrior;
    public GameObject dragonKnight;
    public GameObject whiteDragon;

    // Use this for initialization
    void Start()
    {
        addEnemy(dragonFly, 14);
        addEnemy(dragonFly, 15);

        addEnemy(dragonFly, 21);
        addEnemy(dragonFly, 23);
        addEnemy(dragonFly, 25);

        addEnemy(dragonWarrior, 30);

        addEnemy(dragonKnight, 32);
        addEnemy(dragonFly, 34);
        addEnemy(dragonWarrior, 36);
        addEnemy(dragonFly, 38);

        addEnemy(dragonWarrior, 44, 1);
        addEnemy(dragonWarrior, 44, 3);
        addEnemy(dragonKnight, 46);
        addEnemy(dragonFly, 47);
        addEnemy(dragonWarrior, 48);
        addEnemy(dragonFly, 49);
        addEnemy(dragonWarrior, 50);
        addEnemy(dragonFly, 51);

        addEnemy(dragonKnight, 53, 2);

        addEnemy(dragonWarrior, 55);
        addEnemy(dragonWarrior, 56);
        addEnemy(dragonWarrior, 57);
        addEnemy(dragonFly, 55);
        addEnemy(dragonFly, 56);
        addEnemy(dragonFly, 57);

        addEnemy(dragonWarrior, 58);
        addEnemy(dragonWarrior, 59);
        addEnemy(dragonWarrior, 60);
        addEnemy(dragonKnight, 61, 2);
    }

    // Update is called once per frame
    void Update()
    {
        goToNextLevel();
    }
}
