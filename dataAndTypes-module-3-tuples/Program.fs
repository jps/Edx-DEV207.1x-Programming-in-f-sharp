// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.


type person =
    {
        name: string;
        mutable age : int
    }

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    
    //Create
    let animal1 = ("Jack", "Dog", 1, 1229292)    
    let animal2 = ("Rex", "Dinosaur", 12, 1229293)
    let animal3 = ("Tom", "Cat", 7, 1229294)
    //Decompose
    let name, animaltype, age, id = animal1
    

    //Types
    let dave = { name = "Dave Russell"; age = 35}

    let myname = dave.name;


    0 // return an integer exit code
