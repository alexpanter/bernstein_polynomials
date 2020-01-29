let binFunc (n: float) (k: float) (bin: float) (x: float) =
    bin * (x ** k) * (1.0 - x) ** (n - k)
    
let rec getMaxValue = function
    | x,value,func when x >= 1.0        ->
        value
    | x,value,func when func(x) > value ->
        getMaxValue(x+0.05, func(x), func)
    | x,value,func                      ->
        getMaxValue(x+0.05, value, func)

[<EntryPoint>]
let main(param: string []) =
    let n = param.[0] |> int
    let k = param.[1] |> int
    let bin = param.[2] |> int

    let bFunc = (fun (x: float) ->
                 binFunc (float n) (float k) (float bin) x)
    
    let maxY = getMaxValue(0.0,0.0,bFunc) + 0.05
    printfn "%g" maxY
    
    0
