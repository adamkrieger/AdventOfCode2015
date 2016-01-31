namespace AdventOfCode

open System.Text.RegularExpressions

type Day5 () =

    let threeVowels input =
        let result = Regex("([aeiou][^aeiou]*){3}").Match(input)
        result.Success

    let doubleChar input =
        let result = Regex("(.)\1").Match(input)
        result.Success

    let specialSequence input =
        let result = Regex("ab|cd|pq|xy").Match(input)
        not result.Success

    let input = 
        let filePath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Input_Day5.txt")
        System.IO.File.ReadAllLines filePath

    member this.solve =
        // yes; no; no
        //[|"ugknbfddgicrmopn";"jchzalrnumimnmhp";"haegwjzuvuyypxyu"|]
        input
        |> Array.filter threeVowels
        |> Array.filter doubleChar
        |> Array.filter specialSequence
        |> Array.length