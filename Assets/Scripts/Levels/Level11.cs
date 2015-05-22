using UnityEngine;
using System.Collections;

public class Level11 : Levels
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
        addEnemy(dragonFly, 15);

        addEnemy(dragonFly, 21);
        addEnemy(dragonKnight, 23);
        addEnemy(dragonKnight, 25);

        addEnemy(whiteDragon, 30);
        addEnemy(dragonWarrior, 31);
        addEnemy(dragonKnight, 33);
        addEnemy(dragonFly, 34);

        addEnemy(whiteDragon, 40);
        addEnemy(dragonWarrior, 41);
        addEnemy(dragonKnight, 42);
        addEnemy(dragonFly, 44);
        addEnemy(dragonFly, 45);
        addEnemy(dragonWarrior, 47);
        addEnemy(dragonKnight, 49);
        addEnemy(dragonFly, 51);

        addEnemy(dragonKnight, 53);
        addEnemy(dragonKnight, 54);
        addEnemy(whiteDragon, 56,2);
        addEnemy(dragonWarrior, 56,1);
        addEnemy(dragonWarrior, 56,3);


      
    }

    // Update is called once per frame
    void Update()
    {
        goToNextLevel();
    }
}
