type Player = PlayerA | PlayerB

type PlayerScore =
    | Zero
    | Fifteen
    | Thirty
    | Forty

type Score =
   | NormalScore of PlayerScore * PlayerScore
   | Deuce
   | Advantage of Player
   | Game of Player

let initialScore = NormalScore(Zero,Zero)

let up playerScore =
    match playerScore with
    | Zero -> Fifteen
    | Fifteen -> Thirty
    | Thirty -> Forty
    | Forty -> failwith "Nope"

let normalize score =
    match score with
    | NormalScore(Forty,Forty) -> Deuce
    | _ -> score

let folder score player =
     match score with
     | NormalScore (Forty,_) when player = PlayerA  -> Game PlayerA 
     | NormalScore (_,Forty) when player = PlayerB  -> Game PlayerB 
     | NormalScore (a,b) -> if player = PlayerA then NormalScore( up a,b) else NormalScore( a, up b) 
     | Deuce -> Advantage player
     | Advantage advantagee -> if player = advantagee then Game player else Deuce
     | Game _ -> score

     |> normalize

let playGame points =
    points |> Seq.scan folder initialScore 

let game = seq {
    while true do
        yield PlayerA
        yield PlayerB
}

let score = game |> Seq.take 10 |> playGame |> Seq.toList