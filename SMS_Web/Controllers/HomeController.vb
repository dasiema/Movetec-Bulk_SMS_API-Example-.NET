Imports Movetec_BulkSMS_API
Public Class HomeController
    Inherits System.Web.Mvc.Controller
    Private sms_api As New Movetec_BulkSMS_API.API
    'Disclaimer
    '    Copyright (c) 2021 Denis Asiema 

    'Permission Is hereby granted, free of charge, to any person
    'obtaining a copy Of this software And associated documentation
    'files (the "Software"), to deal in the Software without
    'restriction, including without limitation the rights to use,
    'copy, modify, merge, publish, distribute, sublicense, And/Or sell
    'copies of the Software, And to permit persons to whom the
    'Software Is furnished to do so, subject to the following
    'conditions:

    'The above copyright notice And this permission notice shall be
    'included in all copies Or substantial portions of the Software.

    'THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY Of ANY KIND,
    'EXPRESS Or IMPLIED, INCLUDING BUT Not LIMITED TO THE WARRANTIES
    'OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE And
    'NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS Or COPYRIGHT
    'HOLDERS BE LIABLE For ANY CLAIM, DAMAGES Or OTHER LIABILITY,
    'WHETHER IN AN ACTION OF CONTRACT, TORT Or OTHERWISE, ARISING
    'FROM, OUT OF Or IN CONNECTION WITH THE SOFTWARE Or THE USE Or
    'OTHER DEALINGS In THE SOFTWARE.

    Function Index() As ActionResult
        Dim _api_parameters As New Movetec_BulkSMS_API.API_Parameters_Model

        'Here I bind the api parameters from the web config file. This is optional, you can use a database object if you have your values stored in a database. 
        'Alternatively you can edit he thexboxes in the form for dynamic binding during app runtime.
        _api_parameters.id = 1
        _api_parameters.base_url = ConfigurationManager.AppSettings("base_url").ToString()
        _api_parameters.username = ConfigurationManager.AppSettings("username").ToString()
        _api_parameters.key = ConfigurationManager.AppSettings("api_key").ToString()
        _api_parameters.sender = ConfigurationManager.AppSettings("sender").ToString()
        _api_parameters.msgtype = ConfigurationManager.AppSettings("msgtype").ToString()
        _api_parameters.dlr = ConfigurationManager.AppSettings("dlr").ToString()


        Return View(_api_parameters)
    End Function

    <HttpPost>
    Function Index(ByVal sms_model As API_Parameters_Model)
        Try
            'I format the number in the correct format to send i.e +254. You can use the javascript inputmask function to validate this before form submission.
            sms_model.phone = "254" & sms_model.phone.Substring(sms_model.phone.Length - 9)
            sms_api.SendSMS(sms_model)
            Session("SuccessMsg") = "Sent!"
            Return View(sms_model)
        Catch ex As Exception
            Session("ErrorMsg") = "Error:" & ex.ToString
            ModelState.AddModelError("", Session("ErrorMsg"))
            Return View(sms_model)
        End Try

    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
