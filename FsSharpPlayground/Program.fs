// Learn more about F# at http://fsharp.org

open System
open MathFromCedric

[<EntryPoint>]
let main argv =
    printfn "%i from F#!" <| add 2 3
    Console.ReadLine() |> ignore
    0 // return an integer exit code
