// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System; 



[<EntryPoint>]
let main argv = 
    printfn "This application will demonstate the different types of loops available in f#"
    
    
    let loopFunc = 
        for index = 0 to 10 do
            printfn "counting up %A" index

    let loopFuncDesc = 
        for index = 10 downto 1 do
            printfn "counting down %A" index

    let loopForIn =
        let items = [0,10,20,30]
        for item in items do
            printfn "for in %A" item

    let loopWhile =
        let mutable counter = 0
        while counter < 10 do
            printfn "while %A" counter
            counter <- counter + 1

    loopFunc

    loopFuncDesc

    loopForIn

    loopWhile

    Console.ReadKey()

    printfn "%A" argv
    0 // return an integer exit code

