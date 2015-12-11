open AdventOfCode

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let problem = new Day2()

    printfn "%d" problem.solve

    do System.Console.ReadKey() |> ignore

    0 // return an integer exit code
