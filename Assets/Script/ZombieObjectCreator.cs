using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieObjectCreator : MonoBehaviour {

    public void Create() {
        IZombie z = ZombieFactory.Make(ZombieFactory.Catagory.Crazy, ZombieFactory.IsRange.Range, ZombieColor.White);


        Generator(z);
    }

    public  void Generator(IZombie z)
    {
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        //cube.AddComponent<IZombie>();
        capsule.AddComponent<Zombie>();
        Zombie zombie = capsule.GetComponent<Zombie>();
        zombie.characterProperty = z.characterProperty;
        zombie.zombieColor = z.zombieColor;
        zombie.name = z.characterProperty.Name;

        Debug.Log("zombie color is" + zombie.zombieColor + "_HP" + zombie.characterProperty.HP + "_MP" + z.characterProperty.MP + "_SPEED" + zombie.characterProperty.Speed + "_ISRANGE" + zombie.characterProperty.IsRange);
    }
    /*
    public static T CreateZombie<T>(GameObject gameObject) where T : Component
    {
        T com = gameObject.AddComponent<T>();
        return com;
    }
    */
}
