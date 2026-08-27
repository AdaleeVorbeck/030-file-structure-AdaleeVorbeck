namespace Knightmoves.KnightLight.Trainer;

public class Trainer{
    public string Listen(object[] animals) {
        string sounds = "";

        foreach(object animal in animals){
            if(typeof(Cat.Cat).IsInstanceOfType(animal))
            {
                sounds += ((Cat.Cat) animal).Say() + ", ";
            } 
            else if (typeof(Dog.Dog).IsInstanceOfType(animal))
            {   
                sounds += ((Dog.Dog) animal).Talk() + ", ";
            } 
            else if (typeof(Bird.Bird).IsInstanceOfType(animal))
            {
                sounds += ((Bird.Bird) animal).Sing() + ", ";
            }
        }

        return sounds;
    }
}