module Homework4.Parser
let TryParseOperation (operation:string) =
    match operation with
    | "+" -> true
    | "-" -> true
    | "*" -> true
    | "/" -> true
    | _ -> false
    false


