open System; 
open System.IO;

type Point = { X: int; Y: int; Name: string }

//define pattern
let (|Quadrant1|Quadrant2|Quadrant3|Quadrant4|Origin|Undefined|) input = 
    match input with
        | {Point.X = x; Point.Y = y; Point.Name = name;} when x > 0 && y > 0 -> Quadrant1 //Point.X = 0 & Point.Y > 0
        | {Point.X = x; Point.Y = y; Point.Name = name;} when x < 0 && y > 0 -> Quadrant2
        | {Point.X = x; Point.Y = y; Point.Name = name;} when x < 0 && y < 0 -> Quadrant3
        | {Point.X = x; Point.Y = y; Point.Name = name;} when x > 0 && y < 0 -> Quadrant4
        | {Point.X = x; Point.Y = y; Point.Name = name;} when x = 0 && y = 0 -> Origin
        | _ -> Undefined
    
    

[<EntryPoint>]
let main argv = 

    let getFile =
        Console.Write("Enter the full path to the name of the input file: ")
        Console.ReadLine()

    try
        use input =
            new StreamReader(match argv.Length with
                            | 0 -> getFile
                            | _ -> argv.[0])
        let entities = 
            [ while not input.EndOfStream do
                let raw = input.ReadLine()
                let values = raw.Split(',')
                yield { X = int values.[0]
                        Y = int values.[1]
                        Name = values.[2] } ]
        let errornames =
            seq {
                for p in entities ->
                    match p with
                    | Undefined -> Some(p.Name)
                    | _ -> None
            }
        Console.WriteLine("The undefined entries are: ")
        for e in errornames do
            match e with
            | Some i -> Console.WriteLine(i)
            | None -> ()
        Console.ReadKey() |> ignore
        0
    with
    | :? System.IO.FileNotFoundException ->
        Console.Write("File Not Found. Press a key to exit")
        Console.ReadKey() |> ignore
        -1
    | _ ->
        Console.Write("Something else happened")
        -1 
