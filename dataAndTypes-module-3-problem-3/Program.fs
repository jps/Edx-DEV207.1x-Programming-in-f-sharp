open System

let goldenRatio = 
    (1.0 + (Math.Sqrt 5.0)) / 2.0

let rec enterAnother() =
    printfn "add another Y/N?"
    let yesNo = Console.ReadLine()
    let yesNo = yesNo.Trim().ToLower()

    if yesNo = "y" then
        true
    elif yesNo = "n" then
        false
    else
        printfn "Undexpected input"
        enterAnother()

let rec enterNumber() = 
    printfn "Please enter a number:"
    let age = Console.ReadLine() 
    let couldParse, parsed = System.Double.TryParse(age)
    if couldParse then
        parsed
    else
        printfn "Undexpected input"
        enterNumber()

let printResult initalValue product =
    printfn "inital value: %f product %f" initalValue product
    ()

[<EntryPoint>]
let main argv = 
    printfn "Golden ratio is : %.10f" goldenRatio
    
    //first input
    let mutable numbers = [enterNumber()]

    //allow user to input as many more values as they like
    while enterAnother() do        
        numbers <- enterNumber() :: numbers

    //Calculate product for provided values
    let products = numbers |> List.map (fun x -> (x,x * goldenRatio))

    //Print
    products |> List.iter(fun x ->  
        let init , prod = x
        printResult init prod) 
    
    Console.ReadKey()
    0 // return an integer exit code