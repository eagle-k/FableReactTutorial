module Program

open Browser.Types
open Fable.React
open Feliz


[<ReactComponent>]
let Square () =
    Html.button [
        prop.className "square"
        (* TODO *)
    ]

[<ReactComponent>]
let Board () =
    let renderSquare i = Square()

    let status = "Next player: X"

    Html.div [
        Html.div [
            prop.className "status"
            prop.text status
        ]
        Html.div [
            prop.className "board-row"
            prop.children [
                renderSquare 0
                renderSquare 1
                renderSquare 2
            ]
        ]
        Html.div [
            prop.className "board-row"
            prop.children [
                renderSquare 3
                renderSquare 4
                renderSquare 5
            ]
        ]
        Html.div [
            prop.className "board-row"
            prop.children [
                renderSquare 6
                renderSquare 7
                renderSquare 8
            ]
        ]
    ]

[<ReactComponent>]
let Game () =
    Html.div [
        prop.className "game"
        prop.children [
            Html.div [
                prop.className "game-board"
                prop.children [ Board() ]
            ]
            Html.div [
                prop.className "game-info"
                prop.children [
                    Html.div [ (* status *) ]
                    Html.ol [ (* TODO *) ]
                ]
            ]
        ]
    ]


open Browser.Dom

ReactDOM.render (Game, document.getElementById "root")
