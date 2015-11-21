open System
open System.IO

type Target = {
    X: float; 
    Y: float; 
    Speed: float; 
    ExpectedDistance: float;
    Name: string;}

let gravity = 9.81

let angleOfReach distance speed = 0.5 * Math.Asin( (gravity * distance) / Math.Pow(speed, 2.0))

//theta is the angle of the plane
let distanceTravelled speed theta = (Math.Pow(speed, 2.0) * sin(2.0 * theta)) / gravity

let calculateAngle x y = Math.Atan(y / x)

let (|Hit|Miss|) input =
    match input with
        | {Target.ExpectedDistance = expectedDistance; Target.Speed = speed;} when System.Double.IsNaN(angleOfReach expectedDistance speed) -> Hit
        | _ -> Miss

[<EntryPoint>]
let main argv = 
    
    let getFile =
        Console.Write("Enter the full path to the name of the input file: ")
        Console.ReadLine()

    use input =
        new StreamReader(match argv.Length with
                        | 0 -> getFile
                        | _ -> argv.[0])
    
    let entities = 
        [ while not input.EndOfStream do
            let raw = input.ReadLine()
            let values = raw.Split(',')
            yield { X = float values.[0]
                    Y = float values.[1]
                    Speed = float values.[2]
                    ExpectedDistance = float values.[3]
                    Name = values.[4] } ]
    (*for e in entities do
        printfn "%A" e |> ignore*)
    
    for e in entities do
        let theta = calculateAngle e.X e.Y 
        let angleOfReach = angleOfReach e.ExpectedDistance e.Speed
        let dist = distanceTravelled e.Speed theta
        printfn "%s theta:%f angle:%f dist:%f" e.Name theta angleOfReach dist |> ignore

    printfn "The following guns HIT their target:"
    for t in entities do
        match t with
        | Hit -> printfn "%s" t.Name 
        | _ -> ()
                    
    printfn "The following guns MISS their target:"
    for t in entities do
        match t with
        | Miss -> printfn "%s" t.Name 
        | _ -> ()

    Console.ReadKey() |> ignore
    0