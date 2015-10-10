// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" argv


    let mutable a = 100
    let b = 1000

    a <- 101

    let f x y = x + y / 10

    printfn "%A" (f a b)

    Console.ReadKey()

    0 // return an integer exit code
