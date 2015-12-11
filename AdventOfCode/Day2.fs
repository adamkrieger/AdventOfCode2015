namespace AdventOfCode

open FParsec
open ParserHelpers

type Day2 () =

    let filePath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Input_Day2.txt")

    let input = System.IO.File.ReadAllText filePath

    let pX = pchar 'x'

    let num = manyCharsTill digit pX
              |>> (fun str -> System.Int32.Parse(str))

    let lastNum = restOfLine true
                  |>> (fun str -> System.Int32.Parse(str))

    let wrappingPaper ((l, w), h) =
        let a = l * w
        let b = l * h
        let c = w * h

        let min = List.min [ a; b; c ]

        2 * a + 2 * b + 2 * c + min

    let prism = 
        num .>>. num .>>. lastNum
        |>> wrappingPaper

    let p = printfn "%d"

    member this.solve = 
        input
        |> iterateParserUntilEndAndResolve prism
        |> List.reduce (fun a b -> a + b)