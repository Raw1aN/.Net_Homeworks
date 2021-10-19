module Homework4.Parser

open System
open Homework4.Operation


let ParseOperation (operation:string) =
    match operation with 
    | "+" -> Operation.Add
    | "-" -> Operation.Subtract
    | "*" -> Operation.Multiply
    | "/" -> Operation.Divide
    | _ -> Operation.None
    
let Parse (args:string[]) =
    if args.Length>3 or args.Length<3 then raise (MissingMemberException "WrongArgsLength")
    
    if args.[1]="/" & args.[2]="0" then raise (DivideByZeroException "DivideByZero")
    
    let arg1 =
        try
            args.[0] |> double
        with
            | _ -> raise (ArgumentException "WrongArgs")
    
    let arg2 =
        try
            args.[2] |> double
        with
            | _ -> raise (ArgumentException "WrongArgs")
            
    let operation = ParseOperation args.[1]
    if operation=Operation.None then raise (ArgumentException "WrongOperation")
    
    arg1,operation,arg2 