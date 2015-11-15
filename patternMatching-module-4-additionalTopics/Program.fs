open System
//type checking with pattern matching
let checkType x =
    match box x with
    | :? System.Int32 -> printfn "It's an int 32"
    | :? System.String -> printfn "It's a string"
    | _ -> printfn "This is another type"

type MyRecord = { Name: string; Id: int}

//The below example checks if the name of the record is the same as the 
//argument provided and a match is found. It executes the first expression.
//Second path of the match is if the first case is not met.
let IsMatchByName record1 (name:string) = 
    match record1 with
    | {MyRecord.Name = nameFound; MyRecord.Id = _;} when nameFound = name -> true
    | _ -> false


//exception handling
let divideList = 
    [(1, 2)
     (2, 0) 
     (3, 2)]
//try
//    let a = System.New.WebRequest.Create(url)
//with
//    | :? System.UriFormatException -> ""


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    
    for item in divideList do
        match item with 
        | (_, 0) -> printfn "%A" "Divde by zero error"
        | (x, y) -> printfn "%A" (x / y)

    Console.ReadKey()
    0 // return an integer exit code
