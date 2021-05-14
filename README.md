# Movetec Bulk_SMS_API Example .NET
 In this project I briefly demonstrate how to send an SMS to any mobile carrier in Kenya using the Movetec SMS API.
 
 Here I create an API Class Library with parameters to the Movetec Bulk SMS API and reference it to a sample ASP.NET web application. 
 
 I use the System.Net.Http library to send a header request to the Movetec SMS endpoint. 
 
The parameters that are being passed to the endpoint are being picked from the web.config file, however you may bind them from your database object if you are working with a dataset. You may also edit the bindings dynamically from the Web UI interface that is referencing the API Class.
 
I will later create classes that will capture the status response from the endpoint which can be used for validation, or further actions.
 
 You can register and get your Movetech SMS API Keys here:
 https://sms.movesms.co.ke/userregister
 
 Then simply replace the keys in the web.config file with your assigned API Keys.
 
 Details about the development environment:
 
 IDE: Visual Studio 2019
 Language: VB .NET
 Framework: .NET 4.5.1 (Class Library) | ASP.NET MVC 5 (Web UI) 
 
 
 'Disclaimer
'    Copyright (c) 2021 Dennis Asiema - https://github.com/dasiema

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
 
