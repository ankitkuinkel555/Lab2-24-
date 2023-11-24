// Question number 1.
// Creating a list of 5 teams
type Coach = {
    Name : string
    FormerPlayer : bool
}

type Stats = {
    Wins : int
    Losses : int
}

type Team = {
    Name : string
    Coach : Coach
    Stats : Stats
}
