// Part of the "readwrite" module.
module readwrite

// Open System.IO for file input/output.
open System.IO


// Takes arguments when run in the commandline separated by spaces.
[<EntryPoint>]
let main args =
    let lst = args |> List.ofArray
    printfn "You have requested the following files: %A" lst
    printfn ""
    let result = readwrite.tac lst
    printfn "%A" result
    0
