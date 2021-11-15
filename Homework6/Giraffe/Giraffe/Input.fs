module Giraffe.Input

open Giraffe.Operation

[<CLIMutable>]
type Input =
    {
       v1: decimal
       Operation: string
       v2: decimal
    }