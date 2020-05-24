module ProjectB

open System.Reflection

let getName() =
    Assembly.GetExecutingAssembly().GetName()

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "ProjectA: %A" <| ProjectA.getName()
    printfn "ProjectB: %A" <| getName()
    0
