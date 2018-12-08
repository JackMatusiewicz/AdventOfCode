open AdventOfCode

[<EntryPoint>]
let main argv =
    let r = ProblemOne.partTwo ProblemOne.parseData
    printfn "%d" r
    0 // return an integer exit code
