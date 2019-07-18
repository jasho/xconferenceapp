using System;
using System.Collections.Generic;
using System.Linq;
using XConferenceApp.Models;

namespace XConferenceApp.Repositories
{
    public class SessionRepository : RepositoryBase<SessionModel, int>
    {
        protected override List<SessionModel> items { get; } = new List<SessionModel>
        {
            new SessionModel
            {
                Id = 1,
                Title = "The Development Platform Landscape in 2018",
                Description = "Join Richard Campbell as he takes you on a tour of the broad range of subjects explored while recording more than 1500 episodes of .NET Rocks over the past 10+ years. The development world today is evolving rapidly, but a look at the history of development can help inform the path we're on and where we're going. Along the way you'll hear some great stories from the various .NET Rocks episodes and get some ideas of how you can take your career and your company into the future of technology.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 19},
                TimeStart = new DateTime(2018,11, 22, 9, 0, 0),
                TimeEnd = new DateTime(2018,11, 22, 9, 50, 0)
            },
            new SessionModel
            {
                Id = 2,
                Title = "Demystifying the Core of .NET Core",
                Description = ".NET Core has revolutionized the way we build applications. Today, you can write .NET code once and run it anywhere using the tools, practices, and techniques that .NET community known and loved for years. In this session, you'll learn about architecture of .NET Core and .NET Standard which allows it to run on any platform like Linux, OSX and windows. And you will explore how to integrate the different utilities, libraries and concepts to maximize your .NET skills in the new world of cross-platform .NET.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 25},
                TimeStart = new DateTime(2018,11, 22, 10, 10, 0),
                TimeEnd = new DateTime(2018,11, 22, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 3,
                Title = "Internals of Exceptions",
                Description = "You know how to throw and catch exception. But do you know how are they implemented internally? Do you know what is SEH, VEH and VCH in Windows? Or do you know why C# introduced exceptions filters or how to catch everything, even StackOverflowException? In this presentation I show internal mechanisms used by Windows for handling exceptions. We will see constructs used by C++ and C# languages, CLR instructions and machine code details of those. There will be some live debugging and low to high level code.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 1 },
                TimeStart = new DateTime(2018,11, 22, 12, 20, 0),
                TimeEnd = new DateTime(2018,11, 22, 13, 10, 0)
            },
            new SessionModel
            {
                Id = 4,
                Title = "Immutable code in .NET",
                Description = "Our day to day thinking is quite imperative. Do this, then that, only if this...which is also the way we code. Although natural, imperative code has certain disadvantages when it comes to self-containment, ability to reason about a particular code fragment, testability and performance in certain conditions. So let's talk about adjusting our code and our way of thinking to more functional one. Let's see how certain limitations can open up new possibilities previously impossible to attain using just the imperative code. By implementing certain patterns or restricting the way we write existing code, we can achieve more",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 28 },
                TimeStart = new DateTime(2018,11, 22, 13, 30, 0),
                TimeEnd = new DateTime(2018,11, 22, 14, 20, 0)
            },
            new SessionModel
            {
                Id = 5,
                Title = "Bulletproof Transient Error Handling with Polly",
                Description = "Connected applications only work when connected. What happens if the network breaks temporarily? Will your system recover smoothly or pitch a fit? Using an OSS project called Polly (available on GitHub) you can handle this and many other transient situations with elegance and fluency. Polly let’s you define retry policies using standard patterns such as retry, retry forever, wait and retry, and circuit breaker. Learn how to make your system bulletproof with Polly and a little know-how.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 4 },
                TimeStart = new DateTime(2018,11, 22, 14, 40, 0),
                TimeEnd = new DateTime(2018,11, 22, 15, 30, 0)
            },
            new SessionModel
            {
                Id = 6,
                Title = "Practical CQRS and Event Sourcing on Azure",
                Description = "CQRS and Event Sourcing are both popular patterns that at the same time can be quiet overwhelming.   CQRS, or Command and Query Responsibility Segregation is a pattern in which you use different models for reads and writes. This separation enables you to better optimize both models as well as scaling them independently. CQRS is often used in combination with Event Sourcing. Event Sourcing is nothing more than storing current state as a series of events and rebuilding system state by replaying that series of events. While these patterns are conceptually fairly trivial, actual implementations often add a lot of complexity.   In this session I'll start from scratch with a simple and lean implementation of CQRS and Event Sourcing using Azure Storage. Next, I'll show how to extend the functionality of the solution by adding more complex features such as global ordering, messaging integration and multi-stream projections. Luckily, there are many Azure services that can be of great use while building CQRS/Event Sourced systems, such as Azure Service Bus and Azure Cosmos DB. Along the way, I’ll discuss lessons learned from running a production CQRS+ES based smart meter platform on Azure.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 22 },
                TimeStart = new DateTime(2018,11, 22, 16, 0, 0),
                TimeEnd = new DateTime(2018,11, 22, 16, 50, 0)
            },
            new SessionModel
            {
                Id = 7,
                Title = "From 'dotnet run' to 'Hello World!'",
                Description = "Have you ever stopped to think about all the things that have to take place when you execute a .NET program? As the quote from Neal Ford says \"Understand one level below your usual abstraction\", this talk will look at why this is important and how can it help you if we apply it to the .NET framework. We will delve into the internals of the recently open-sourced .NET Core Runtime, looking at what happens, when it happens and why. Using freely available diagnostic tools such as PerfView, libraries including ClrMD and even the source code itself! Along the way we'll examine the Execution Engine, Type Loader, Just-in-Time (JIT) Compiler and the CLR Hosting API, to see how all these components play a part in making a 'Hello World' app possible.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 15 },
                TimeStart = new DateTime(2018,11, 22, 17, 10, 0),
                TimeEnd = new DateTime(2018,11, 22, 18, 0, 0)
            },
            new SessionModel
            {
                Id = 8,
                Title = "Docker for .NET Developers",
                Description = "Is Docker forever on your list of things to explore? There's no better time than now… In this talk, Steve will introduce you to Docker, an application packaging and containerisation technology that opens new possibilities for development and deployment of your ASP.NET and .NET applications. Steve will share with you the Docker journey that his team is on, exploring their motivations for using Docker, the benefits they've achieved and the workflows they have developed. You will learn about the core terminology and concepts that .NET developers need to understand in order to begin working with Docker. Steve will share demos which show how easy it is to start leveraging Docker in your own ASP.NET Core projects. Finally, Steve will demo a complete CI-CD pipeline using Docker and Jenkins. Steve will explore the AWS EC2 Container Services (ECS) architecture they have built to enable rapid, continuous delivery of their microservices. You’ll leave this talk with the knowledge you need to get started using Docker and excited about the value that Docker can add to your software projects.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 24 },
                TimeStart = new DateTime(2018,11, 22, 9, 0, 0),
                TimeEnd = new DateTime(2018,11, 22, 9, 50, 0)
            },
            new SessionModel
            {
                Id = 9,
                Title = "Understanding the Serverless platform in Microsoft Azure",
                Description = "Serverless is more than FaaS (Functions-As-A-Service)! Serverless architectures could really disrupt the enterprise by transforming the ways developers build solutions by dramatically increasing productivity and reducing costs. Is Serverless truly for anyone or any kind of project? Attend and find out! In this session, you will hear about some of the technologies that Microsoft is offering around this space: Azure Functions, Azure Logic Apps and Azure Service Fabric Mesh. Also, you will see some of the related tools used to build and take advantage of this kind of solutions.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 20 },
                TimeStart = new DateTime(2018,11, 22, 10, 10, 0),
                TimeEnd = new DateTime(2018,11, 22, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 10,
                Title = "Mapping DDD Domain Models with EF Core 2.1",
                Description = "Entity Framework half-heartedly supported DDD patterns. But the new-from-scratch EF Core has brought new hope for DDD practitioners to map your well-designed domain classes to a database, reducing the cases where a separate data model is needed. EF Core 2.1 is very DDD friendly, even supporting things like fully encapsulated collections, backing fields and the return of support for value objects. In this hands we'll review some well-designed aggregates and explore how far EF Core 2.1 goes to act as the data model between your domain classes and your data store.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 11 },
                TimeStart = new DateTime(2018,11, 22, 12, 20, 0),
                TimeEnd = new DateTime(2018,11, 22, 13, 10, 0)
            },
            new SessionModel
            {
                Id = 11,
                Title = "CosmosDB 101: Basics and quickstart",
                Description = "Azure CosmosDB is one of the hottest names in technology these days. With global distribution, multi-model support. and numerous APIs for accessing your data including SQL, JavaScript, Gremlin, MongoDB, Cassandra and Azure Table Storage, CosmosDB offers a wide array of solutions for data storage on a global scale. This talk will cover a high level look at the various features and capabilities of CosmosDB and resources on getting started.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 23 },
                TimeStart = new DateTime(2018,11, 22, 13, 30, 0),
                TimeEnd = new DateTime(2018,11, 22, 14, 20, 0)
            },
            new SessionModel
            {
                Id = 12,
                Title = ".NET Debugging tricks you wish you knew",
                Description = "Do you know what developers do most of their day (except for surfing the internet)? Writing code? WRONG! They are debugging. The debugger is a powerful tool, but in this talk you'll learn tricks that will help find bugs in half the time and with less frustration. Because a happy developer is a productive developer. I'll show you to use tools that will point to you to right direction and features didn't know that are even there, for both development time debugging and post-mortem production analysis.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 25 },
                TimeStart = new DateTime(2018,11, 22, 14, 40, 0),
                TimeEnd = new DateTime(2018,11, 22, 15, 30, 0)
            },
            new SessionModel
            {
                Id = 13,
                Title = "Correcting Common Mistakes in Asynchronous .NET Code",
                Description = "How much do we really know about how async/await works in .NET? In this session, we will breakdown the inner-workings of .NET to understand what actually happens when we compile our async code! We’ll learn how a few easy improvements to our async code can create huge performance gains! The .NET compiler turns every async method into a class that contains its own state-machine nested inside of a try/catch block. This means that our app-size increases by 100 bytes every time we create an async method, and that every async method could potentially swallow exceptions leading to unintended behavior in our apps. Oh my! Join me as we take an existing app and optimize its async code together, showing off the performance gains in exception handling, improved run-time speed, and smaller app size!",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 3 },
                TimeStart = new DateTime(2018,11, 22, 16, 0, 0),
                TimeEnd = new DateTime(2018,11, 22, 16, 50, 0)
            },
            new SessionModel
            {
                Id = 14,
                Title = "Deploy Web Core 2.0 application to Azure Container Service (AKS) using Kubernetes",
                Description = "We will describe in this session the workflow to compile a Docker-based ASP.NET Core web application and to deploy it after to a Kubernetes cluster that is already running on the Azure Container Service (AKS), we will use Visual Studio Team Services (VSTS). We will describe other features that are available with Azure App Service such as scaling, auto-scaling, using slots in staging or production.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 18 },
                TimeStart = new DateTime(2018,11, 22, 17, 10, 0),
                TimeEnd = new DateTime(2018,11, 22, 18, 0, 0)
            },
            new SessionModel
            {
                Id = 15,
                Title = "Top 18 Azure security fails and how to avoid them",
                Description = "Karl Ots has assessed the security of over 100 Azure solutions. He has found that there are 18 security pitfalls that are common across all industry verticals and company sizes. In this session, he will share what these security pitfalls are, why do they matter and how to mitigate them.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 12 },
                TimeStart = new DateTime(2018,11, 22, 9, 0, 0),
                TimeEnd = new DateTime(2018,11, 22, 9, 50, 0)
            },
            new SessionModel
            {
                Id = 16,
                Title = "Managing your Secrets in a Cloud Environment",
                Description = "Connection Strings, Password, Tokens, Private keys, Certs and so on, if not properly management can end up in the wrong hands. In this talk we will explore secret managements and demonstrate the risks, and discuss best practices for keeping secrets safe using Azure Key Vault or Hashicorp Vault in your cloud. We wil also go through some of the design aspects of using secrets in your docker container and your orchestration solution in the cloud.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 26 },
                TimeStart = new DateTime(2018,11, 22, 10, 10, 0),
                TimeEnd = new DateTime(2018,11, 22, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 17,
                Title = "A lap around Azure Machine Learning services",
                Description = "Azure Machine Learning services (preview) is an integrated, end-to-end solution for professional data scientists to prepare data, develop experiments and deploy models at cloud scale. Come and explore the Azure Machine Learning landscape with technical hands-on demos going from data gathering and preparation to building experiments and distributing a machine learning model in the real world.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 16 },
                TimeStart = new DateTime(2018,11, 22, 12, 20, 0),
                TimeEnd = new DateTime(2018,11, 22, 13, 10, 0)
            },
            new SessionModel
            {
                Id = 18,
                Title = "Monitoring real-life Azure applications: When to use what and why",
                Description = "Modern applications leverage a variety of services, and often span across on premises, IaaS, PaaS and SaaS. Monitoring these environments is different from traditional systems. We have more and more data available from the platform with the likes of ARM Activity Logs, Azure Monitor, Log Analytics and Application Insights.   With a massive amount of signal and noise being generated in all these systems, how do we get our arms around what is happening? Is my application impacted in an ongoing Azure outage? Are my integrations intact? Which services from Azure should I use to monitor my application end-to-end? Come and hear how to answer these questions. After the session, you’ll have deeper understanding of end-to-end monitoring techniques in Azure solutions and know which services to choose for which scenario.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 12 },
                TimeStart = new DateTime(2018,11, 22, 13, 30, 0),
                TimeEnd = new DateTime(2018,11, 22, 14, 20, 0)
            },
            new SessionModel
            {
                Id = 19,
                Title = "8 Cloud Design Patterns you ought to know.",
                Description = "In software engineering, a design pattern is a general repeatable solution to a commonly occurring problem in software design. You probably know about the GoF patterns, but did you know there are also Cloud Design Patterns solutions to a commonly occurring problem when building applications in the Cloud. In this Talk we will go through 8 Cloud Design Patterns that will help you in your Design and Implementation, Data Management, Resiliency and Security; namely - External Configuration - Cache Aside - Federated Identity - Valet Key - Gatekeeper - Circuit Breaker - Retry - Strangler",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 26 },
                TimeStart = new DateTime(2018,11, 22, 14, 40, 0),
                TimeEnd = new DateTime(2018,11, 22, 15, 30, 0)
            },
            new SessionModel
            {
                Id = 20,
                Title = "Enable IoT with Edge Computing and Machine Learning",
                Description = "The next evolution in cloud computing is a smarter application not in the cloud. As the cloud has continued to evolve, the applications that utilize it have had more and more capabilities of the cloud. This presentation will show how to push logic and machine learning from the cloud to an edge application. Afterward, creating edge applications which utilize the intelligence of the cloud should become effortless.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 10 },
                TimeStart = new DateTime(2018,11, 22, 16, 0, 0),
                TimeEnd = new DateTime(2018,11, 22, 16, 50, 0)
            },
            new SessionModel
            {
                Id = 21,
                Title = "Building Awesome 8-bit Adventure Games with Microsoft Bot Framework v4",
                Description = "The Microsoft Bot Framework helps you create intelligent bots to naturally interact with your users over various channels, such as websites, Cortana and Skype. But you can create even more interesting scenarios! Being big fans of both bots and classic 8-bit point-and-click adventure games, we wanted to see if we could build such a game using the Microsoft Bot Framework. After all, the mechanics of classic adventure games are very much like interacting with a bot. This is especially true for the earlier text-based adventure games. The result is our Game-a-Tron 3000(tm) game engine which uses various Bot Framework features in combination with an HTML5 client to recreate the look and feel of the golden-era adventure games such as Monkey Island. We will show how the game engine was created, how the games can be played through different channels, and how we created a better user experience by adding LUIS for language understanding. You will learn how you can utilize the Bot Framework for your own scenarios while feeling nostalgic for the good old days when games came on floppy disks and graphics were more pixelated!",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 22 },
                TimeStart = new DateTime(2018,11, 22, 17, 10, 0),
                TimeEnd = new DateTime(2018,11, 22, 18, 0, 0)
            },
            new SessionModel
            {
                Id = 22,
                Title = "The State of .NET",
                Description = "The industry is in a state of flux. What does that mean for your software projects today and tomorrow? Will your skills be outdated? Will your current investment become obsolete? What should you focus on right now? And what will become important a year or two down the road? What technologies do you need to learn? This session attempts to answer these questions and more, by taking an unbiased look at current and future development with .NET and other relevant technologies. As part of the CODE/EPS team, Tiberiu is in an unique position to share information based on real world experience in projects that are either our own or one of the many projects we get to see in our role as mentors, trainers and consultants, as well as feedback we receive from CODE Magazine readers. This is NOT marketing hype! You will hear which technologies you should invest time and money in, and which ones to avoid.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 27 },
                TimeStart = new DateTime(2018,11, 23, 9, 0, 0),
                TimeEnd = new DateTime(2018,11, 23, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 23,
                Title = "Authentication and Authorization in ASP.NET Core 2",
                Description = "You’ve probably seen how a ASP.NET Core application works, but authentication and authorization are a different cup of tea. Microsoft completely re-did a large part of these security features in ASP.NET Core and expanded on that in version 2. ASP.NET Identity enables you to do authentication for a single application and has a lot of ready-to-go features, but isn't it better to do centralized authentication with a token service? And where do OpenIDConnect and OAuth2 come in? We'll explore these questions and I'll explain and show you both ASP.NET Core identity the IdentityServer framework that helps you write a token service. Authorization has undergone a complete overhaul in ASP.NET Core. There's still the authorize attribute, but the recommended way of using it is by utilizing policies. You'll see how that works as well. After this session you'll know what options you have for implementing authentication in ASP.NET Core 2. And you will understand how to implement these options. Also you'll know how to enforce authorization rules in your ASP.NET Core app.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 21 },
                TimeStart = new DateTime(2018,11, 23, 12, 20, 0),
                TimeEnd = new DateTime(2018,11, 23, 13, 10, 0)
            },
            new SessionModel
            {
                Id = 24,
                Title = "Powerful benchmarking in .NET",
                Description = "Performance is a feature. But it's hard to measure it right, especially when it comes to micro- benchmarking. BenchmarkDotNet has become the most popular .NET benchmarking library. But how does it actually work? What problems does it solve? Why do the most respected .NET performance experts trust it? Join one of the authors to learn about all the features, advantages and limitations.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 2 },
                TimeStart = new DateTime(2018,11, 23, 13, 30, 0),
                TimeEnd = new DateTime(2018,11, 23, 14, 20, 0)
            },
            new SessionModel
            {
                Id = 25,
                Title = "Adapting ASP.NET Core MVC to your needs",
                Description = "One of the things we - as developers - always hate, is feeling constrained by a framework. Unfortunately, historically, this has been a huge problem for ASP.NET developers. We were forced to do things in a very specific way, in a one-size-fits-all context. This had a number of negative effects, for example poor reusability, as it was difficult to achieve the code reuse we needed. In this talk, we’ll look at the ASP.NET Core world, and see how we it tries to address some of the deficiencies of its predecessor. We'll look at various MVC framework components and its extensibility points. We will explore its flexibility, and how you can bend the framework to your will. We will also look at how to facilitate building reusable features.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 7 },
                TimeStart = new DateTime(2018,11, 23, 14, 40, 0),
                TimeEnd = new DateTime(2018,11, 23, 15, 30, 0)
            },
            new SessionModel
            {
                Id = 26,
                Title = "Crossing the Streams with ASP.NET Core SignalR and Reactive Programming",
                Description = "The long awaited SignalR for ASP.NET Core is here. The essence of SignalR is that it generates streams of data to the client. Any conventional method of asynchronous programming with async/await in .NET or promises in JavaScript is not suitable for streams. Clients want to react to data just relevant for them or the user as soon as it arrives. In this session we take a look at what ASP.NET Core SignalR brings to the table especially compared to the non-Core version of SignalR. And, maybe more importantly, the correct way to consume the streams it generates in a reactive manner. You'll also find out that allthough crossing the streams is a bad thing in Ghostbusters is actually easy to do in ASP.NET Core SignalR without causing any explosions!",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 21 },
                TimeStart = new DateTime(2018,11, 23, 16, 0, 0),
                TimeEnd = new DateTime(2018,11, 23, 16, 50, 0)
            },
            new SessionModel
            {
                Id = 27,
                Title = "What Developers Want!",
                Description = "There is so much going on in the tech world nowadays, new programming languages, new APIs and new tools everyday. Trying to keep up with all of it can be challenging. So how can we guarantee a smooth developer experience? In this talk, I’d like to share with you what I’ve learnt in one year of advocacy. What developers really want from an API, from clean simple code to great documentation. How do we get developers excited about using our products.",
                Room = new RoomModel{ Id = 1 },
                Speaker = new SpeakerModel{ Id = 17 },
                TimeStart = new DateTime(2018,11, 23, 17, 10, 0),
                TimeEnd = new DateTime(2018,11, 23, 18, 0, 0)
            },
            new SessionModel
            {
                Id = 28,
                Title = "Building a mobile enterprise application with Xamarin.Forms, Docker, MVVM and .NET Core",
                Description = "Mobile applications are getting more and more complex and the requirements for apps change all the time. It’s vital that we build a flexible and modern architecture, both in the app as well as in the backend. Amongst others, this means that applications need to be built out of several, smaller components that work together seamlessly. In this session, we will explore an end-to-end architecture for building a modern enterprise mobile app and its backend. The app is built using Xamarin.Forms, based on the MVVM principles. This results in clear separation of concerns and promotes loose coupling, making changes to the functionality easier to test and implement. On the backend, the application talks with a microservice-based API, built with ASP.NET Core and hosted with Docker. After this session, you will have a good idea how you can create modern mobile apps.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 9 },
                TimeStart = new DateTime(2018,11, 23, 9, 0, 0),
                TimeEnd = new DateTime(2018,11, 23, 9, 50, 0)
            },
            new SessionModel
            {
                Id = 29,
                Title = "Building great apps with Xamarin.Forms",
                Description = "One code to run everywhere, Xamarin.Forms is the framework to build native apps for iOS, MacOS, Android, Windows and there are more platforms coming, like Linux and Tizen. But could you really build an app with great user experience for all platforms using Xamarin.Forms? You definitively can! During this session Daniel Hindrikes will show tips and tricks how to build an app with great performance and with great user experience to make an good app became an great app!",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 5 },
                TimeStart = new DateTime(2018,11, 23, 10, 10, 0),
                TimeEnd = new DateTime(2018,11, 23, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 30,
                Title = "Building great apps with Xamarin.Forms",
                Description = "One code to run everywhere, Xamarin.Forms is the framework to build native apps for iOS, MacOS, Android, Windows and there are more platforms coming, like Linux and Tizen. But could you really build an app with great user experience for all platforms using Xamarin.Forms? You definitively can! During this session Daniel Hindrikes will show tips and tricks how to build an app with great performance and with great user experience to make an good app became an great app!",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 5 },
                TimeStart = new DateTime(2018,11, 23, 10, 10, 0),
                TimeEnd = new DateTime(2018,11, 23, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 31,
                Title = "Mobile DevOps - Deliver great apps continuously",
                Description = "The world is changing faster than ever, and so do the expectations on applications, therefore, it is really important to deliver application fast and with high quality continuously. To have good tools and processes are really important to be able to keep a high speed when developing applications. During this session Daniel Hindrikes will show you how to use VSTS and AppCenter when developing mobile applications to support the DevOps lifecycle, including working with requirements, continuous integration, continuous delivery, automatic tests and monitoring.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 5 },
                TimeStart = new DateTime(2018,11, 23, 13, 30, 0),
                TimeEnd = new DateTime(2018,11, 23, 14, 20, 0)
            },
            new SessionModel
            {
                Id = 32,
                Title = "Porting MVVM Light to .NET Standard: Lessons learned",
                Description = ".NET Standard is the new way to create portable assemblies. After learning about portable class libraries in the past years, it is now time to upgrade our game and start coding for Linux, Mac OS and other platforms untouched by .NET until now. More and more libraries are getting ported to .NET Standard, sometimes really easily and sometimes more painfully. In this session, Laurent Bugnion, the creator of the popular open source MVVM Light Toolkit, will help you understand why .NET Standard can benefit you, and talk about his experiences converting his framework to .NET Standard.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 13 },
                TimeStart = new DateTime(2018,11, 23, 14, 40, 0),
                TimeEnd = new DateTime(2018,11, 23, 15, 30, 0)
            },
            new SessionModel
            {
                Id = 33,
                Title = "Logging Is Hot Again",
                Description = "If you think logging is boring, stop yawning and think again. Designed for the ages of monolithic synchronous applications running in data centers or on the desktop, traditional text-file-oriented logging frameworks such as log4net or nlog are becoming obsolete. New tools, best-practices and standards are emerging to make sense out of massively distributed and asynchronous applications that run in the cloud, in containers, or in mobile devices. Solutions for a world where storage and computing power are cheap and can be provisioned within minutes. Starting with the question “what do we want to log and why?”, this talk gives a bird’s eye overview of the new logging landscape. It introduces open-source solutions like Elasticsearch, Fluentd or OpenTracing, and commercial services like Application Insights. On a code level, it shows how PostSharp can help to generate highly detailed logs with minimal efforts. The key takeaway of this talk is a broad understanding of the business of logging and application instrumentation, so you’re ready to make choices on your own.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 8 },
                TimeStart = new DateTime(2018,11, 23, 16, 00, 0),
                TimeEnd = new DateTime(2018,11, 23, 16, 50, 0)
            },
            new SessionModel
            {
                Id = 34,
                Title = "Spanification",
                Description = "What is Span, how it works, what problems it solves and how to use it today to write faster .NET Core applications. I am going to cover the new .NET Core 2.1 APIs which consume Span and show you how to use them and change your old habits from the prior to Span times.",
                Room = new RoomModel{ Id = 2 },
                Speaker = new SpeakerModel{ Id = 2 },
                TimeStart = new DateTime(2018,11, 23, 17, 10, 0),
                TimeEnd = new DateTime(2018,11, 23, 18, 0, 0)
            },
            new SessionModel
            {
                Id = 35,
                Title = "Virtual Reality and IoT – Interacting with the changing world",
                Description = "Whether it’s called mixed reality, augmented reality, or virtual reality; changing the perceived reality of the user is here. This presentation will look at how to create IoT devices, send the data through the cloud, and use that data to drive a virtual or mixed reality experience. Creating applications that interact with the data created by the user’s environment should become straightforward after this introduction.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 10 },
                TimeStart = new DateTime(2018,11, 23, 9, 0, 0),
                TimeEnd = new DateTime(2018,11, 23, 9, 50, 0)
            },
            new SessionModel
            {
                Id = 36,
                Title = "Hitchhikers Guide to Growing Your Tech Skills",
                Description = "Myriad languages, tools, paradigms and patterns that developers swear by tempt and tease us on a daily basis. Even if you have already made the tough choices as to which ones to focus on, how can you incorporate the effort mastering them while still performing the work that your day job requires? How do you stay relevant and productive and continue to elevate your career? Don’t panic! It is possible. Still going strong after three decades of coding, Julie Lerman will share tips and tricks that she uses to continuously evolve her tech skills and keep on top of her game as a coder and a coach as well as one of the top authors on Pluralsight.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 11 },
                TimeStart = new DateTime(2018,11, 23, 10, 10, 0),
                TimeEnd = new DateTime(2018,11, 23, 11, 0, 0)
            },
            new SessionModel
            {
                Id = 37,
                Title = "Lifting and Shifting Legacy Web Services to Microservices in Azure Service Fabric",
                Description = "Let's face it: not all companies and developers can afford to start a project from scratch just for the sake of adopting a new architecture, since there are millions of lines of code running today in production based on legacy technologies such as ASMX and WCF. In the other hand, many companies will opt for a hybrid or on-premises scheme before jumping into the cloud! However, the only way to achieve business innovation is by modernizing your applications with technologies like containers and using cloud-ready application patterns. As you might guess: this is not a straightforward process.   In this session, you will see how you can modernize your existing code and bring it to a more resilient, scalable, reliable, monitorable and mature platform like Azure Service Fabric.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 20 },
                TimeStart = new DateTime(2018,11, 23, 12, 20, 0),
                TimeEnd = new DateTime(2018,11, 23, 13, 10, 0)
            },
            new SessionModel
            {
                Id = 38,
                Title = "ML.NET - Machine Learning made for .NET",
                Description = "Want to enhance your .NET apps with custom machine learning solutions like price prediction, fraud detection or sentiment analysis? Well, now you can! ML.NET is a machine learning framework built for .NET developers. It's free. It's open source. It's cross platform. Come get an introduction to Machine Learning on the .NET platform as we look at making use of your existing .NET and C# skills to easily integrate custom machine learning into your applications without any prior expertise in developing or tuning machine learning models.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 16 },
                TimeStart = new DateTime(2018,11, 23, 13, 30, 0),
                TimeEnd = new DateTime(2018,11, 23, 14, 20, 0)
            },
            new SessionModel
            {
                Id = 39,
                Title = "Building concurrent systems using Akka.NET",
                Description = "The Actor Model programming paradigm for building highly concurrent systems was defined back in the seventies. In this session I focus on Akka.NET, a modern open-source framework that can be used to build highly concurrent systems based on the Actor Model programming paradigm. I introduce the Actor Model concepts, followed by an overview of the Akka.NET framework. Finally I walk you through the code of a sample application built using Akka.NET.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 6 },
                TimeStart = new DateTime(2018,11, 23, 14, 40, 0),
                TimeEnd = new DateTime(2018,11, 23, 15, 30, 0)
            },
            new SessionModel
            {
                Id = 40,
                Title = "MSBuild: Understand and customize your .NET build",
                Description = "MSBuild is the powerful build system used in .NET. With .NET Core, it is now widely used cross-platform and has been open sourced. Since MSBuild has been powering .NET Core builds since 2017, it has unlocked remarkable possibilities that were not possible with project.json. It has a programming language of its own. This session introduces to this programming language, explains common build customization techniques, helps avoid pitfalls when setting up your custom build logic and explores strategies to investigate build errors.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 14 },
                TimeStart = new DateTime(2018,11, 23, 16, 0, 0),
                TimeEnd = new DateTime(2018,11, 23, 16, 50, 0)
            },
            new SessionModel
            {
                Id = 41,
                Title = "C# Scripting in the .NET Core world",
                Description = "While still being relatively niche, over the recent years C# scripting has grown to become a first class citizen in the Roslyn compiler and can now be enjoyed and applied in your applications in various ways. Together, we will dissect what’s going on under the hood in C# scripting and how you can make use of it in the cross platform, lightweight, .NET Core world (which, by the way, creates a perfect environment for low ceremony C# scripting). We'll also have a look at scripting via the new .NET CLI, how you can integrate it into your everyday development workflows and how you can debug the script assemblies.",
                Room = new RoomModel{ Id = 3 },
                Speaker = new SpeakerModel{ Id = 7 },
                TimeStart = new DateTime(2018,11, 23, 17, 10, 0),
                TimeEnd = new DateTime(2018,11, 23, 18, 0, 0)
            },
        };

        public override List<SessionModel> GetAll()
        {
            return base.GetAll().OrderBy(session => session.TimeStart).ToList();
        }

        public List<SessionModel> GetByDateAndRoomId(DateTime date, int roomId)
        {
            return GetAll().Where(session => session.TimeStart.Date == date.Date && session.Room.Id == roomId).ToList();
        }

        public List<SessionModel> GetBySpeakerId(int speakerId)
        {
            return GetAll().Where(session => session?.Speaker?.Id == speakerId).ToList();
        }
    }
}