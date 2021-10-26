

open System
open FSharp.Data

let doRequest=
    async {
        let! r1 = Http.AsyncRequest "http://localhost:5000/add?v1=1&v2=2"
        let str =
            match r1.Body with
            |HttpResponseBody.Text t -> t
            |HttpResponseBody.Binary _ -> "Binary"
        return str 
    }

let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let r = doRequest |> Async.RunSynchronously
    
    printfn $"{r}"
    
    0 