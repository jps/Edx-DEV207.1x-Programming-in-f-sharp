// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

(*Question 1*)
[<EntryPoint>]
let main argv = 

    let test = ("Greetings", 10,1)

    let checktuple x =
        match x with
        | ("Hello", b, c) when b > 10 -> c
        | (a, b, c) -> a.Length  + b + c
    let result = checktuple test

    printfn "%i" result
    
    Console.ReadKey()

    0 // return an integer exit code
