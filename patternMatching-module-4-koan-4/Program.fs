open System

type Adapter =
    { IP : string
      MAC : string
      FriendlyName : string
      ID : int }

let (|IsMatchByName|_|) (input : Adapter) (name: string) =
    match input with
    | {FriendlyName = friendlyName} when friendlyName = name -> Some()
    | _ -> None
 
let checkmatch (record: Adapter) (name : string) =
    match name with 
    | IsMatchByName record -> "Match"
    | _ -> "No match"

[<EntryPoint>]
let main argv = 
    let testRecord = {IP = "10.1.1.1"; MAC = "FF:FF:FF:FF:FF:FF"; FriendlyName = "ServerFailure";ID = 0} 
    let result = checkmatch testRecord "ServerFailure" 
       
    Console.WriteLine(result)
    Console.ReadKey() |> ignore
    0 // return an integer exit code
