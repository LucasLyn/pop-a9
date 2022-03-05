// Part of the "readwrite" module.
module readwrite

// Open System.IO for file input/output.
open System.IO

// Set up a url as a stream.
let url2Stream url =
    let uri = System.Uri url
    let request = System.Net.WebRequest.Create uri
    let response = request.GetResponse()
    response.GetResponseStream()
// The source for this code-black has been found in fSharpNotes.pdf
// released by Jon Sporring, in chapter 19.6.


// Read all contents of a web page as a string.
let readUrl url =
    let stream = url2Stream url
    let reader = new StreamReader(stream)
    reader.ReadToEnd()
// The source for this code-black has been found in fSharpNotes.pdf
// released by Jon Sporring, in chapter 19.6.


///<summary>Counts the amountf of links on a website.</summary>
///<param name = "url">The url to check for links.</param>
///<returns>The amount of links on a websites as an integer.<returns>
let countLinks (url:string) : int =
    let key = "<a"
    let data = readUrl url
    let rec loop count (index : int) =
        if index >= String.length data then count
        else
            match data.IndexOf(key, index) with
            | -1 -> count
            | idx -> loop (count + 1) (idx + 1)
    if String.length key = 0 then 0 else loop 0 0
// Inspiration for this code-black can be found at the following site;
// https://stackoverflow.com/questions/40385154/f-count-how-many-times-a-
// substring-contains-within-a-string



// Takes arguments when run in the commandline separated by spaces.
[<EntryPoint>]
let main args =
    try
        let url = args |> Seq.map string |> String.concat ""
        printfn "You have requested the following url: %A" url
        printfn ""
        let result = countLinks url
        printfn "%A" result
        0
    with
        _ -> 0