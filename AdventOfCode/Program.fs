open AdventOfCode

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let problem = new Day3()

    printfn "%s" problem.solve

    do System.Console.ReadKey() |> ignore

    0 // return an integer exit code
