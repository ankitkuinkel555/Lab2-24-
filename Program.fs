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

// coaches
let coach1 = { Name = "Quin Snyder"; FormerPlayer = false }
let coach2 = { Name = "Joe Mazzulla"; FormerPlayer = true }
let coach3 = { Name = "Jacque Vaughn"; FormerPlayer = true }
let coach4 = { Name = "Steve Clifford"; FormerPlayer = false }
let coach5 = { Name = "Billy Donovan"; FormerPlayer = false }

// stats
let stats1 = { Wins = 2891; Losses = 2964 }
let stats2 = { Wins = 3570; Losses = 2462 }
let stats3 = { Wins = 1622; Losses = 2164 }
let stats4 = { Wins = 1153; Losses = 1478 }
let stats5 = { Wins = 2344; Losses = 2254 }

// teams
let team1 = { Name = "Atlanta Hawks"; Coach = coach1; Stats = stats1 }
let team2 = { Name = "Boston Celtics"; Coach = coach2; Stats = stats2 }
let team3 = { Name = "Brooklyn Nets"; Coach = coach3; Stats = stats3 }
let team4 = { Name = "Charlotte Hornets"; Coach = coach4; Stats = stats4 }
let team5 = { Name = "Chicago Bulls"; Coach = coach5; Stats = stats5 }

// list of teams
let teams = [team1; team2; team3; team4; team5]

/ Mapping the list
// function to calculate success percentage
let calculateSuccessPercentage (team : Team) =
    let totalGames = float (team.Stats.Wins + team.Stats.Losses)
    let successPercentage = (float team.Stats.Wins / totalGames) * 100.0
    successPercentage

// Using List.map to calculate success percentage for each team
let successPercentages = List.map calculateSuccessPercentage teams

// Accessing information about success percentages
for (team, successPercentage) in List.zip teams successPercentages do
    printfn "Team: %s, Success Percentage: %.2f%%" team.Name successPercentage