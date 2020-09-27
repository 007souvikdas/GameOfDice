using System;
using System.Collections.Generic;

namespace GameOfDice
{
    
class Person{
    public string Name{get;}
    
    public Person(string name){        
        Name = name;
    }
    public int Score{get;set;}

    public int WinningPosition{get;set;} =-1;

    public int LastDiceRoll{get;set;}=-1;

    public bool SkipChance = false;

}

class PersonComparer: IComparer<Person>{
    public int Compare(Person first,Person second){
        return first.Score.CompareTo(second.Score);
    }
}
}

