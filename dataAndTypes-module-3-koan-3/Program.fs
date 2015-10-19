// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System;

[<EntryPoint>]
let main argv = 
    

    let arr = [1; 2; 3; 4; 5; 6; 7; 8; 9]
    let l = arr.Length - 1
    let isEven x = 
        x % 2 = 0

    let out = seq { for i in 1 .. l do
                if (isEven (arr.Item i)) then yield arr.[i] }

    let newout =  [0] @ List.ofSeq(out)

    printfn "%A" newout

    Console.ReadKey()

    0 // return an integer exit code
