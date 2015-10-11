// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System


let isPositiveEven v = 
    if v < 0 then
        false
    elif (v % 2) = 0 then
        true
    else
        false

[<EntryPoint>]
let main argv = 
    
    let check = Console.ReadLine()
    let check = int check
    
    let result = isPositiveEven check

    printfn "%b" result

    Console.ReadKey()
    0 // return an integer exit code
