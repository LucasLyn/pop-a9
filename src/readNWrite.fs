// Module for readwrite
module readwrite

// Open environments.
open System.IO
open FSharp.Data


///<summary>Opens a file from the filename and prints the contents.</summary>
///<param name = "filename">Name of file to read from.</param>
///<returns>A string of the contents in each file given.</returns>
let readFile (filename:string) : (string option) =
    try
        Some (File.ReadAllText filename)
    with
        _ -> None


///<summary>Takes a list of filenames and prints the contents of them.</summary>
///<param name = "filenames">List of filenames to use.</param>
///<returns>A string option of combined contents of given files.<returns>
let cat (filenames:string list) : string option =
    let mutable concat = Some ""
    // Checks if all reguested files exist.
    if List.forall File.Exists filenames then
        for i in 0 .. filenames.Length - 1 do
            concat <- Option.map2 (+) concat (readFile filenames.[i])
        concat
    else None


///<summary>Concats and reverses the contents of given files.</summary>
///<param name = "filenames">List of filenames to use.</param>
///<returns>String option of concat and reversed stings in given files.<returns>
let tac (filenames:string list) : string option =
    let mutable contac = Some ""
    // Checks if all reguested files exist.
    if List.forall File.Exists filenames then
        let result = (filenames |> cat).Value |> Seq.rev |> Seq.map string
                    |> String.concat ""
        Some result
    else None
