// Learn more about F# at http://fsharp.org

// https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/fsharp

// A child is playing with a ball on the nth floor of a tall building. The height of this floor, h, is known.
// He drops the ball out of the window. The ball bounces (for example), to two-thirds of its height (a bounce of 0.66).
// His mother looks out of a window 1.5 meters from the ground.
// How many times will the mother see the ball pass in front of her window (including when it's falling and bouncing?
// Three conditions must be met for a valid experiment:
// Float parameter "h" in meters must be greater than 0
// Float parameter "bounce" must be greater than 0 and less than 1
// Float parameter "window" must be less than h.
// If all three conditions above are fulfilled, return a positive integer, otherwise return -1.

open System

[<EntryPoint>]
let main argv =
    let rec countBounces (times : int) (window : float) (bounce : float) (height : float) : int =
      match height with
      | h when h < window -> times
      | _ -> countBounces (times + 2) window bounce (height * bounce)

    let rec bouncingBall (h: float) (bounce: float) (window: float) =
        match h, bounce, window with
        | h, bounce, window when h <= 0. || (bounce <= 0. || bounce >= 1.) || window >= h -> -1
        | _ ->
            let bounces = countBounces 0 (float window) (float bounce) (float h)
            match bounces with
              | 0 -> -1
              | _ -> bounces - 1

    printfn "%i" (bouncingBall 3.0 0.66 1.5)
    printfn "%i" (bouncingBall 30.0 0.66 1.5)
    printfn "%i" (bouncingBall 30.0 0.75 1.5)
    printfn "%i" (bouncingBall 330.0 0.4 10.0)
    printfn "%i" (bouncingBall 40.0 0.4 10.0)
    printfn "%i" (bouncingBall 10.0 0.6 10.0)
    0 // return an integer exit code
