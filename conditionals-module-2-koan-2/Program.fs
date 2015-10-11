// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

[<EntryPoint>]
let main argv = 
    
    let input = Console.ReadLine()
    let input = int input

    let rec dosomethingrandom x =
        if x = 0 then 
            1
        else 
            dosomethingrandom (x - 1) * x

    let result = dosomethingrandom(input)

    printfn "%A" result

    Console.ReadKey()

    0 // return an integer exit code
