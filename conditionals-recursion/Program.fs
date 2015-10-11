// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let rec calcFib x =
    if x <= 2 then 1
    else calcFib(x-1) + calcFib(x-2)

[<EntryPoint>]
let main argv = 
    printfn "Enter a value to calulate the fib:"
    
    let value = Console.ReadLine()
    let value = int value

    let result = calcFib(value)

    printfn "result is: %i" result

    Console.ReadKey()

    0 // return an integer exit code
