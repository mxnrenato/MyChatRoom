# MyChatRoom
My Chat Room is a web application for chat rooms divided according to a theme. It is built on .NET (5.0) under the MVC design pattern (Model, View, Controller), in order to implement the functionalities in real time, the SignalR library was used.

## Installation:
No data persistence is used during the first version of MyChatRoom, so installing it is as easy as cloning the repository: 
`git clone git@github.com:mxnrenato/MyChatRoom.git`
When building the application from VS2019 you must enter the url that the startup.cs file specifies.
`https://localhost:port/chat/index`
`/ chat` is the endpoint specified in the startup.cs file.

## Demonstration

![image](https://github.com/mxnrenato/MyChatRoom/blob/master/MyChatRoom/wwwroot/showVideo.gif)

## Updates

During the next updates I will be implementing data persistence with SQLServer in addition to improving the design of the application.

## Credits
The application is the result of following the [Hdeleton.Net](https://hdeleon.net/ "Hdeleton.Net") tutorials.
