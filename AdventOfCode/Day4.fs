namespace AdventOfCode

open System.Security.Cryptography

type Day4 () =

    let testHash (input:string) =
        let md5 = MD5.Create()

        let bytes = System.Text.Encoding.ASCII.GetBytes input

        let hash = md5.ComputeHash bytes

        let firstAndSecond = hash.[0].Equals 0uy
        let thirdAndFourth = hash.[1].Equals 0uy
        let fifth = (hash.[2] >>> 4).Equals 0uy

        firstAndSecond && thirdAndFourth && fifth

    member this.solve =
        let init = "ckczppom"

        let format = fun i -> init + i.ToString()

        let nums = Seq.initInfinite (fun i -> i + 1)

        let smallestThatMeetsTest = 
            nums
            |> Seq.find (fun i -> i |> format |> testHash)

        //let workingTestCase = testHash "abcdef609043"

        smallestThatMeetsTest
        