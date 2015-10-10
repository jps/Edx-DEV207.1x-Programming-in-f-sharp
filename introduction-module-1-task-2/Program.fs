// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

let areaOfAHexagon t =
    (3.0 * Math.Sqrt(3.0) / 2.0) * t * t
    
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("enter the size of the hexagon")
    let size = Console.ReadLine()
    let size = float size
    let computedArea = areaOfAHexagon size

    Console.WriteLine("the area of the hexagon is: " + (string computedArea) )

    Console.ReadKey()

    0 // return an integer exit code
