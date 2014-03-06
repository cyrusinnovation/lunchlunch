
namespace LunchLunch
open System
open System.Web
open System.Web.UI

type  (* partial *)Default() = 
        inherit System.Web.UI.Page()
        abstract button1Clicked : obj * EventArgs -> unit
        default this.button1Clicked  (sender:obj, args:EventArgs) =
            button1.Text <- "Click Me"
