
let rec binomial = function
    | (n,k) when k = 0 || n = k -> 1
    | (n,k) -> binomial(n-1,k-1) + binomial(n-1,k)

[<EntryPoint>]
let main(param: string []) =
    let mutable n = 0
    let mutable k = 0
    let mutable doevents = false
    try
        n <- int param.[0]
        k <- int param.[1]
        doevents <- true
    with
        |_ -> printfn "two integer parameters must be passed\n"
    if doevents then
        let binonmialResult = binomial(n,k)
        printfn "%i" binonmialResult
    0
    
