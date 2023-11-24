// Define the Cuisine discriminated union
type Cuisine =
    | Korean
    | Turkish

// Define the MovieType discriminated union
type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

// Define the Activity discriminated union
type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float

// suppose
let boardGameActivity = BoardGame
let chillActivity = Chill
let movieActivity = Movie Regular
let restaurantActivity = Restaurant Korean
let longDriveActivity = LongDrive (50, 0.1) // 50 km distance, 0.1 CAD fuel cost per km


// Define the calculateBudget function
let calculateBudget activity =
    match activity with
    | BoardGame | Chill -> 0.0
    | Movie movieType ->
        match movieType with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks | IMAXWithSnacks | DBOXWithSnacks -> 12.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (distance, fuelCostPerKm) -> float distance * fuelCostPerKm

// Calculate and print the budget for each activity
printfn "Board Game: %.2f CAD" (calculateBudget boardGameActivity)
printfn "Chill: %.2f CAD" (calculateBudget chillActivity)
printfn "Movie: %.2f CAD" (calculateBudget movieActivity)
printfn "Restaurant: %.2f CAD" (calculateBudget restaurantActivity)
printfn "Long Drive: %.2f CAD" (calculateBudget longDriveActivity)