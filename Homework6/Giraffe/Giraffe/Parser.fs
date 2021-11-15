module Giraffe.Parser

open System
open Giraffe.Operation
open Giraffe.ErrorTypes
open Giraffe.MaybeBuilder
open Giraffe.Input


let ParseOperation (args:Input) =
    maybeBuilder{
        let! operationResult=
            match args.Operation with 
            | "+" -> Ok Operation.Add
            | "-" -> Ok Operation.Subtract
            | "*" -> Ok Operation.Multiply
            | "/" -> Ok Operation.Divide
            | _ -> Error "Wrong operation"
        return operationResult
    }

let CheckDivideByZero (args: Input) =
    if args.Operation="/" & args.v2=0.0m 
    then Error "DivideByZero"
    else Ok args

let Parse (args:Input) =
    maybeBuilder{
        let! First = CheckDivideByZero args
        let! Second = ParseOperation First
        return Second
    }