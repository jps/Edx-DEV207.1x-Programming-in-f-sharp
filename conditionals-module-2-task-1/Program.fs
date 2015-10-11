// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

let readIntOrReturnZero =
    printfn "enter an integer:"
    let canparse, keyin = Int32.TryParse(Console.ReadLine())
    if canparse then 
        keyin
    else 
        0

let parseFirstItemAsIntOrRequestConsoleInput (argv : string []) : int =
    if argv.Length > 0 then      
        let couldparse, consolein = Int32.TryParse(argv.[0])
        if couldparse then consolein
        else
            readIntOrReturnZero
    else
        readIntOrReturnZero

let computeFibIterative (fibIndex : int) : int= 
    if fibIndex = 0 then
        0
    elif fibIndex <= 2 then
        1
    else 
        let mutable a = 0
        let mutable b = 1
        let mutable c = 0


        for i = 2 to fibIndex do
            c <- a + b
            a <- b
            b <- c
    
        c

let rec computeFibRecursive (fibIndex : int) =
    if fibIndex = 0 then
        0
    elif fibIndex <= 2 then
        1
    else
        computeFibRecursive(fibIndex - 1) + computeFibRecursive(fibIndex - 2)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let fibIndex = parseFirstItemAsIntOrRequestConsoleInput(argv)
        
//    let result = computeFibIterative(fibIndex)

 //   printfn "Result iterative %i" result
    
    let result = computeFibRecursive(fibIndex)

    printfn "Result recursive %i" result

    Console.ReadKey()
    0 // return an integer exit code
