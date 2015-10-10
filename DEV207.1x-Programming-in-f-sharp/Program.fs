// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("Please enter how far you have travelled:")
    let distance = Console.ReadLine()
    let distance = float distance
    Console.WriteLine("Please enter how much fuel you have used:")
    let fuel = Console.ReadLine()
    let fuel = float fuel
    
    let distancePerUnitOfFuel = distance / fuel; 
     
    Console.WriteLine("Your car does a distance of " + (string distancePerUnitOfFuel) + "units per unit of fuel" )

    Console.ReadKey()

    0 // return an integer exit code
