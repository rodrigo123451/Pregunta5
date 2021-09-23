// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "hola mundo F#!"
    let lista=[1..10 ]
    printfn"%A"lista
    printfn"pares"
    let lista1=[for i in 1..10 do if i%2=0 then yield i]
    printfn"%A"lista1
    printfn"impares"
    let lista2=[for i in 1..10 do if i%2=1 then yield i]
    printf"%A"lista2


    
    
  
    


    Console.ReadKey() |>ignore
    0 // return an integer exit code
   