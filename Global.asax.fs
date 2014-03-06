
namespace LunchLunch
open System
open System.Collections
open System.ComponentModel
open System.Web
open System.Web.SessionState

type Global() = 
        inherit System.Web.HttpApplication()
        abstract Application_End : Object * EventArgs -> unit
        default this.Application_End  (sender:Object, e:EventArgs) =
            ()
        
        abstract Session_End : Object * EventArgs -> unit
        default this.Session_End  (sender:Object, e:EventArgs) =
            ()
        
        abstract Application_Error : Object * EventArgs -> unit
        default this.Application_Error  (sender:Object, e:EventArgs) =
            ()
        
        abstract Application_AuthenticateRequest : Object * EventArgs -> unit
        default this.Application_AuthenticateRequest  (sender:Object, e:EventArgs) =
            ()
        
        abstract Application_EndRequest : Object * EventArgs -> unit
        default this.Application_EndRequest  (sender:Object, e:EventArgs) =
            ()
        
        abstract Application_BeginRequest : Object * EventArgs -> unit
        default this.Application_BeginRequest  (sender:Object, e:EventArgs) =
            ()
        
        abstract Session_Start : Object * EventArgs -> unit
        default this.Session_Start  (sender:Object, e:EventArgs) =
            ()
        
        abstract Application_Start : Object * EventArgs -> unit
        default this.Application_Start  (sender:Object, e:EventArgs) =
            ()
