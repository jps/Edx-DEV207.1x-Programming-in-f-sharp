open System

//define pattern
let (|Positive|Negative|Zero|) input = 
    if input > 0 then Positive
    elif input < 0 then Negative
    else Zero
//check pattern
let CheckState x =
    match x with
    | Positive -> "I'm positive"
    | Negative -> "I'm negative"
    | Zero -> "I'm zero"

//partial active pattern
let (|IsOdd|_|) input = 
    if input % 2 = 0 then None
    else Some()

let (|IsMultiple|_|) input multiple= 
    if input % multiple = 0 
        then Some() 
        else None
//combine
let CheckOdd x multiple =
    match x with
    | IsOdd & IsMultiple multiple -> sprintf "I'm Odd multiple of %i" multiple
    | IsOdd -> "I'm Odd"
    | _ -> "Not Odd"


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "Check state" 
    [for i in -10..10 -> Console.WriteLine (CheckState i)]
    printfn "Check odd" 
    [for i in -10..10 -> Console.WriteLine (CheckOdd i 3)]
    Console.ReadKey()
    0 // return an integer exit code
