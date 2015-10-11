(*
In this problem we are going to create a simple console application that reads in the name and age of a person. We need
to input multiple peoples details which we specify at the start of the application. We then output each persons name 
and age as well as a field which is determined by the following rules:

    If age >= 20 then the field is a string which states the person's name and that they are no longer a teenager
    If the age < 20 and greater than 13 then the field is a string that states the persons name and that they are a teenager
    If the age is < than 13 then is states the name and the person is a kid or child.

As part of this exercise your application must handle erroneous input.

To complete this assignment please complete the Q and A and peer review.
*)
open System

//app funcs
let rec enterAge() = 
    printfn "Please enter AGE:"
    let age = Console.ReadLine() 
    let couldParse, parsed = Int32.TryParse(age)
    if couldParse then
        if parsed < 0 || parsed > 120 then
            printfn "invalid age"
            enterAge()
        else
            parsed
    else
        printfn "Undexpected input"
        enterAge()

let rec enterName() =
    printfn "Please enter NAME:" 
    let name = Console.ReadLine()   
    let name = name.Trim()
    if name.Length = 0 then
        printfn "Undexpected input"
        enterName()
    else
        name

let rec enterAnother() =
    printfn "add another person Y/N?"
    let yesNo = Console.ReadLine()
    let yesNo = yesNo.Trim().ToLower()

    if yesNo = "y" then
        true
    elif yesNo = "n" then
        false
    else
        printfn "Undexpected input"
        enterAnother()

let getAgeString age = 
    if age >= 20 then
        "no longer a teenager" 
    elif age < 13 then
        "a child" 
    else
        "a teenager" 

let NameAgeString(name, age) = 
    name + " age " + age.ToString() + " is " + (getAgeString(age))     

[<EntryPoint>]
let main argv = 
    //Add first person and name and age lists
    let mutable names = [enterName()]
    let mutable ages = [enterAge()]
    //add any more people? 
    while enterAnother() do        
        names <- enterName() :: names 
        ages <- enterAge() :: ages
    //Display entered people
    for index = names.Length - 1 downto 0 do
        printfn "%A" (NameAgeString( names.Item(index), ages.Item(index)))
    //Prevent application from closing
    Console.ReadKey()
    0 // return an integer exit code
