Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Parent() As ActionResult
        ViewData("Message") = "Your parents page."

        Return View()
    End Function

    Function KidsLearn() As ActionResult
        ViewData("Message") = "Your kidslearn page."

        Return View()
    End Function

    Function Whatsnew() As ActionResult
        ViewData("Message") = "Your whatsnew page."

        Return View()
    End Function
End Class
