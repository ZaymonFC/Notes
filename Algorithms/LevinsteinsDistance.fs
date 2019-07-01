let Distance (s: string) (t: string) =
  let m = s.Length
  let n = t.Length

  let mutable d = [|for i in 0..m -> [|for j in 0..n -> 0|]|]

  for i in 1..m do
    d.[i].[0] <- i

  for j in 1..n do
    d.[0].[j] <- j

  for j in 1..n do
    for i in 1..m do
      let substitutionCost =
        match s.[i] = t.[j] with
        | true -> 0
        | _ -> 1

      d.[i].[j] <- [(d.[i-1].[j] + 1);(d.[i].[j-1] + 1);(d.[i - 1].[j - 1] + substitutionCost)] |> List.min

  d.[m].[n]

printf "%d" (Distance "asdf" "asdff")