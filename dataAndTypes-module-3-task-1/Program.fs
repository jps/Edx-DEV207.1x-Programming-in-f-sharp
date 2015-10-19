// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System


type User = {
    name : string;
    age : int;
    id : int;
}

let getUserId (name : string) age : int =
    name.Length * age
    
let readUser() : User = 
    printfn "Please enter user name:"
    let inputedName = Console.ReadLine()
    
    printfn "Please enter user age:"
    let inputedAge = Console.ReadLine()
    let inputedAge = int inputedAge 
    
    { 
        name = inputedName; 
        age = inputedAge; 
        id = (getUserId inputedName inputedAge)
    }

let rec enterAnother() =
    printfn "add another user Y/N?"
    let yesNo = Console.ReadLine()
    let yesNo = yesNo.Trim().ToLower()

    if yesNo = "y" then
        true
    elif yesNo = "n" then
        false
    else
        printfn "Undexpected input"
        enterAnother()

let rec addUsers (users : List<User>) : List<User> =
    let newUser = readUser()
    let newUserList = newUser :: users 
        
    if enterAnother() then
        addUsers newUserList
    else
        newUserList

let printUser user =
    printfn "name %s age %i id %i" user.name user.age user.id


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    //Main user
    let mainUser = readUser()
    //Add other users
    let otherUsers = addUsers List.empty<User>

    printfn "Main user:"
    printUser mainUser
    printfn "Matched users:"
    (List.filter(fun x -> x.id = mainUser.id) otherUsers) 
        |> List.iter printUser
        
    Console.ReadKey()
    0 // return an integer exit code


