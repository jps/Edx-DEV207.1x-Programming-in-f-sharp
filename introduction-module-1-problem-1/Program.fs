open System

let volumeOfCylinder radius height =
    (Math.PI * Math.Pow(radius, 2.0)) * height

[<EntryPoint>]
let main argv = 

    printfn "Enter the HEIGHT of the cylinder:"
    let height = Console.ReadLine() |> Microsoft.FSharp.Core.float.Parse

    printfn "Enter the RADIUS of the cylinder:"
    let radius = Console.ReadLine() |> Microsoft.FSharp.Core.float.Parse

    let computedVolume = volumeOfCylinder radius height

    printfn " The computed volume of the cylinder is: %f units" computedVolume

    Console.ReadKey()

    0 // return an integer exit code
