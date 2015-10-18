// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System; 


[<EntryPoint>]
let main argv = 

    //Arrays
    let arrayA = [|1;2;3;4|];
    printfn "%A" arrayA

    let arrayB = [|for i in 1..10 -> i * i|];
    printfn "%A" arrayB

    //Lists
    let listA = [1;2;3;4]
    printfn "%A" listA

    let listB = [ for i in 5 .. 10 -> i];
    printfn "%A" listB

    let addItemToList = 5 :: listA 
    printfn "%A" addItemToList

    let concatLists = listA @ listB
    printfn "%A" concatLists

    //Sequences
    let sequenceA = seq { 0 .. 2 .. 10 }
    printfn "%A" sequenceA 

    let sequenceB = seq { for i in 1 .. 10 do yield i * i }
    printfn "%A" sequenceB

    Console.ReadKey()

    0 // return an integer exit code
