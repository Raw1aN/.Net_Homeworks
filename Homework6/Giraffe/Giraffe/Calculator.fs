module Giraffe.Calculator

open System
open Giraffe.Operation

let inline Calculate arg1 operation arg2 =
    match operation with
    | Operation.Add -> arg1 + arg2
    | Operation.Subtract -> arg1 - arg2
    | Operation.Divide -> arg1 / arg2
    | Operation.Multiply -> arg1 * arg2