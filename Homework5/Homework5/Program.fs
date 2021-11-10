module Homework5.Program

open System
open Homework5.Operation
open Homework5.Parser
open Homework5.Calculator
open Homework5.MaybeBuilder


[<EntryPoint>]
let main argv =
    let result = maybeBuilder{
        let! Parsed = Parser.Parse argv
        let res = Calculator.Calculate Parsed
        return res
    }
    match result with
    | Ok b ->
        printf $"{b}"
        0
    | Error error -> int error