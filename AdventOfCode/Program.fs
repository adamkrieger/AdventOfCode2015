open AdventOfCode

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let day1 = new Day1()

    printfn "%d" day1.solve

    do System.Console.ReadKey() |> ignore

    0 // return an integer exit code
