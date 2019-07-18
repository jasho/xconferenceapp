using System.Collections.Generic;
using XConferenceApp.Models;

namespace XConferenceApp.Repositories
{
    public class SpeakerRepository : OrderableRepositoryBase<SpeakerModel, int>
    {
        protected override List<SpeakerModel> items { get; } = new List<SpeakerModel>{
            new SpeakerModel
            {
                Id = 1,
                Order = 1,
                FirstName = "Adam",
                LastName = "Furmanek",
                DescriptionShort = "Software Developer at Amazon, Seattle",
                DescriptionLong = @"I am Adam Furmanek and I have been working as a .NET developer for 5 years. Right now I am at Amazon working with Scala, Spark and Machine Learning. I am always interested in digging deeper, exploring machine code and going through implementation details to better understand internals of the technologies I use every day. That's why I like debugging, decompiling and disassembling the code to understand memory models, concurrency problems and other details hidden deeply inside. In my free time I play ping-pong, watch Woody Allen's movies and blog stuff at http://blog.adamfurmanek.pl",
                PhotoUrl = "https://sessionize.com/image?f=f24abd088841c371d3deac3739632ccd,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.a2310ab4-9594-4c80-96e1-b14928f03fee.jpg"
            },
            new SpeakerModel
            {
                Id = 2,
                Order = 2,
                FirstName = "Adam",
                LastName = "Sitnik",
                DescriptionShort = ".NET Performance geek",
                DescriptionLong = @"#BenchmarkDotNet contributor, Software Engineer at Microsoft on the .NET Performance and Reliability Team. Ex-MMA practitioner, AFOL, rabbit owner and a huge classic star wars fan.",
                PhotoUrl = "https://sessionize.com/image?f=9c305cefdda3d4d2d6baa74a571e459f,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.4ac6f8ae-2d22-488a-a995-2094cbd55ccc.jpg"
            },
            new SpeakerModel
            {
                Id = 3,
                Order = 3,
                FirstName = "Brandon",
                LastName = "Minnick",
                DescriptionShort = "Xamarin + Azure Developer Advocate at Microsoft",
                DescriptionLong = @"Brandon works as a Xamarin + Azure Developer Advocate at Microsoft where he gets to work closely with the developer community and help fellow mobile app and cloud developers make 5-star apps. An avid mobile app developer, Brandon has contributed to countless apps, including publishing iOS, Android and UWP apps to the respective app stores.",
                PhotoUrl = "https://sessionize.com/image?f=d7293c2e862f4c7a6b574a7e3ae31786,400,400,True,False,85-7297-4724-80a4-2afec2b6b9c0.813e6e51-eb03-413c-94ca-79ef6fdc41dd.jpg"
            },
            new SpeakerModel
            {
                Id = 4,
                Order = 4,
                FirstName = "Carl",
                LastName = "Franklin",
                DescriptionShort = "Microsoft Regional Director, Microsoft MVP",
                DescriptionLong = "Carl Franklin je viceprezidentem společnosti App vNext zabývající se vývojem softwaru s ohledem na nejnovější metodiky a technologie. Carl je 20 letý veterán softwarového průmyslu, spolumoderátor a zakladatel .NET Rocks!, prvního a asi nejsledovanějšícho podcastu pro vývojáře. Je také Microsoft MVP pro Kinect, Microsoft Regional Director a výkonný ředitel společnosti Pwop Studios - produkčního a postprodukčního studia s kompletním servisem, které se nachází v Connecticutu. MVP za Kinect získal díky svým projektům na rozpoznávání gest - KinectTools a GesturePak.",
                PhotoUrl = "https://sessionize.com/image?f=6e99e91fe345dbcdd51c22b3b8b3fa7c,400,400,True,False,85-7297-4724-80a4-2afec2b6b9c0.2b71e4d7-b5a9-450e-a595-346bf9b307f7.jpg"
            },
            new SpeakerModel
            {
                Id = 5,
                Order = 5,
                FirstName = "Daniel",
                LastName = "Hindrikes",
                DescriptionShort = "Ninja at tretton37",
                DescriptionLong = @"Daniel one of the most experienced Xamarin developers in Sweden. He started to develop mobile apps long before that, mostly on the Android- (both with Xamarin and with Java) and Windows platforms. But he’s is a full stack developer, but focus on with mobile- and cloud solution as an architect and developer. Right now he is really passionate about how AI can make great applications fantastic. Daniel working for tretton37 in Sweden and he has experience for working with both local- and global customers.",
                PhotoUrl = "https://sessionize.com/image?f=6c71686c5b6c4e1ca8d9efb1c2431acf,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.2c3599d5-bd0d-4088-981c-548036cb318c.jpg"
            },
            new SpeakerModel
            {
                Id = 6,
                Order = 6,
                FirstName = "Edwin",
                MiddleName = "van",
                LastName = "Wijk",
                DescriptionShort = "Principal Software Architect at Info Support & Microsoft MVP",
                DescriptionLong = @"I've been working in IT since 1999 and I'm currently working as Principal Software Architect and Microsoft Competence Center lead at Info Support in The Netherlands. I'm a Microsoft MVP in the Visual Studio & Development Technologies category. My primary areas of expertise are: building distributed systems, systems integration, (web-scale) software architecture and patterns, software craftsmanship, .NET (Core) development, Azure and devops. I like sharing my knowledge about these subjects by blogging, publishing videos and speaking on events.",
                PhotoUrl = "https://sessionize.com/image?f=0d793fa27fa4e6e1cc58dc606b7dde6d,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.005fe033-7f57-477c-b476-1c23022cf712.jpg"
            },
            new SpeakerModel
            {
                Id = 7,
                Order = 7,
                FirstName = "Filip",
                LastName = "W",
                DescriptionShort = "OSS FTW",
                DescriptionLong = @"Filip is a popular .NET blogger, author, prolific open source contributor and a Microsoft MVP. Over the past few years, his blog has been one of the most popular ASP.NET resources on the internet. Filip specializes in the Roslyn compiler, cross platform .NET development, modern web technologies and is experienced in delivering robust web solutions. He worked on projects in many corners of the world (Canada, Switzerland, Finland, Poland, Scotland). Follow him on Twitter @filip_woj.",
                PhotoUrl = "https://sessionize.com/image?f=a6f70431a351428e70f463fe0fb51b08,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.41d3aaf7-1742-460e-ac90-e11b3b7d50b6.jpg"
            },
            new SpeakerModel
            {
                Id = 8,
                Order = 8,
                FirstName = "Gael",
                LastName = "Fraiteur",
                DescriptionShort = "Founder and Principal Engineer at PostSharp Technologies",
                DescriptionLong = @"Gael Fraiteur has been passionately programming since childhood; building and selling his first commercial software at age 12. He is Founder and Principal Engineer at PostSharp Technologies based in Prague, Czech Republic. Gael is a widely recognized expert in aspect-oriented programming and pattern-aware compilers. He speaks at developer conferences in Europe and the United States.",
                PhotoUrl = "https://sessionize.com/image?f=19e3b484e162cb765d221bb8f98bc8c7,400,400,True,False,85-7297-4724-80a4-2afec2b6b9c0.14bab8da-1edf-47ee-a2d6-b9284b4455fc.jpg"
            },
            new SpeakerModel
            {
                Id = 9,
                Order = 9,
                FirstName = "Gill",
                LastName = "Cleeren",
                DescriptionShort = ".NET Solution Architect",
                DescriptionLong = @"Gill Cleeren is a Microsoft Regional Director, Visual Studio MVP, Xamarin MVP and Pluralsight author. Gill focuses on web and mobile development and loves Xamarin. Gill is a frequent speaker at many international conferences such as TechDays, TechEd, NDC, VSLive, DevConnections and many more. He also is the founder of Techorama, the biggest IT conference in Belgium and he runs Visug, the .NET user group in Belgium as well. You can find his website at www.snowball.be.",
                PhotoUrl = "https://sessionize.com/image?f=fe94d6123adfcda145097618ab81f2cd,400,400,True,False,85-7297-4724-80a4-2afec2b6b9c0.ef2cc5b9-de1f-4d1b-9fab-3cc798e5b717.jpg"
            },
            new SpeakerModel
            {
                Id = 10,
                Order = 10,
                FirstName = "Jared",
                LastName = "Rhodes",
                DescriptionShort = "Cloud, Mobile, IoT",
                DescriptionLong = @"As a Microsoft MVP for Azure, I focus on IoT, Mobile, and Cloud; trying to find the subsection of those and make them work together. Lately, I have working with AI and Edge computing as the they evolve together. I enjoy public speaking, walks on the beach, and no linker errors.",
                PhotoUrl = "https://sessionize.com/image?f=625793df085b9def6f140399bbb62f0f,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.2d755115-db5c-4156-b1fe-8ac04b06cb2c.jpg"
            },
            new SpeakerModel
            {
                Id = 11,
                Order = 11,
                FirstName = "Julie",
                LastName = "Lerman",
                DescriptionShort = "Software Coach, Pluralsight Author, .NET & DDD",
                DescriptionLong = @"Julie Lerman is a Microsoft Regional Director, Docker Captain and long-time Microsoft MVP who now counts her years as a coder in decades. She makes her living as a mentor and consultant to software teams around the world. You can find Julie presenting on Entity Framework, Domain Driven Design and other topics at user groups and conferences around the world. Julie blogs at thedatafarm.com/blog, is the author of the highly acclaimed “Programming Entity Framework” books, the MSDN Magazine Data Points column and popular videos on Pluralsight.com. Follow Julie on twitter at julielerman.",
                PhotoUrl = "https://sessionize.com/image?f=ee10ed4854b8661f449014cbe245e64f,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.afb43ed8-8934-4df2-af68-01b054a5bb6f.jpg"
            },
            new SpeakerModel
            {
                Id = 12,
                Order = 12,
                FirstName = "Karl",
                LastName = "Ots",
                DescriptionShort = "Azure MVP & Managing Consultant at Kompozure",
                DescriptionLong = @"Karl Ots is a cloud and cybersecurity consultant, as well as international speaker and trainer, with a broad range of deep Azure expertise. He believes that cloud technologies are the key to successful digital transformation. He applies his passion and expertise to his work as a Managing Consultant at Kompozure, the Azure-only consultancy. Karl is also an Azure MVP. With professional experience in technology field since 2007, Karl has been working with Microsoft Azure since 2011 in a variety of forums ranging from deep customer engagements to speaking at 1:1000 events. Karl is a Microsoft Certified Trainer (MCT) and a Certified Information Systems Security Professional (CISSP).",
                PhotoUrl = "https://sessionize.com/image?f=5fa8a8af3b08b96de23aa9202d1cce59,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.3b46829c-6c32-468a-9cac-c823e0e9ea14.jpg"
            },
            new SpeakerModel
            {
                Id = 13,
                Order = 13,
                FirstName = "Laurent",
                LastName = "Bugnion",
                DescriptionShort = "Senior Global Azure Advocate at Microsoft",
                DescriptionLong = "Laurent pracuje jako Senior Global Azure Advocate pro Microsoft poté, co téměř deset let pracoval ve společnostech IdentityMine a Valorem. Je jedním z nejvýznamnějších expertů v oblastech XAML a C#. Zajímá se především o WPF, Xamarin (iOS a Android), Unity a ASP.NET. Ve svém volném čase Laurent přispívá do technických publikací jako je například MSDN Magazine, nebo na svůj blog (http://blog.galasoft.ch). Často přednáší na konferencích jako jsou Microsoft MIX, Build, TechEd, Visual Studio Live, TechDays a mnohé další. Před nástupem do společnosti Microsoft byl Laurent Microsoft MVP a Microsoft Regional Director. Je autorem známého open source frameworku MVVM Light pro WPF a Xamarin a dále autorem populárního kurzu o MVVM Light na Pluralsightu.",
                PhotoUrl = "https://sessionize.com/image?f=578a075dc387b47c041bcf33b8ac5b9b,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.742afb98-6331-4888-b581-cb30733add24.jpg"
            },
            new SpeakerModel
            {
                Id = 14,
                Order = 14,
                FirstName = "Martin",
                LastName = "Ullrich",
                DescriptionShort = "Engineer at cssteam.at",
                DescriptionLong = "My name is Martin Ullrich. I am a software enginner working on diverse tech stacks but focusing mostly on .NET in C#, Web Technologies and iOS/Swift. I am a build system enthusiast and always work on improving DevOps processes at our company to make life easier for developers. I was awarded Microsoft MVP for community and open-source work around .NET Core Tooling.",
                PhotoUrl = "https://sessionize.com/image?f=9b34ea44e8527f646fe9c02a3648db6f,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.92bef4fa-4170-45d7-a9d6-aeb67082eb5a.jpg"
            },
            new SpeakerModel
            {
                Id = 15,
                Order = 15,
                FirstName = "Matt",
                LastName = "Warren",
                DescriptionShort = "Microsoft MVP",
                DescriptionLong = "Matt is a C# dev who loves nothing more than finding and fixing performance issues. He’s worked with Azure, ASP.NET MVC and WinForms on projects such as a web-site for storing government weather data, medical monitoring devices and an inspection system that ensured kegs of beer didn’t leak! He’s an Open Source Contributor to BenchmarkDotNet and RavenDB.",
                PhotoUrl = "https://sessionize.com/image?f=b7651c38507928b8ffce51a1408e40e2,400,400,True,False,85-7297-4724-80a4-2afec2b6b9c0.42f1c55b-2a28-47ee-a53f-bb65a74cebe4.jpg"
            },
            new SpeakerModel
            {
                Id = 16,
                Order = 16,
                FirstName = "Peter",
                LastName = "Drougge",
                DescriptionShort = "Senior Technical Evangelist, Microsoft",
                DescriptionLong = "Peter works as a Technical Evangelist at Microsoft, primarily focusing on Cloud, Web and Machine Learning topics. Empowered with the life motto of \"practice what you preach\" he's a firm believer that you grow by learning and sharing knowledge and he loves a good challenge. Before joining Microsoft he spent more than a decade in various IT roles in the financial sector.",
                PhotoUrl = "https://sessionize.com/image?f=4126e1fdd8e654ba1002f252fbd80e7c,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.83aa8e0c-3c2d-4384-b654-5acccf6db4eb.jpg"
            },
            new SpeakerModel
            {
                Id = 17,
                Order = 17,
                FirstName = "Rabeb",
                LastName = "Othmani",
                DescriptionShort = "Developer Advocate at Nexmo",
                DescriptionLong = "Rabeb is a developer advocate at Nexmo focusing on cloud communication APIs and conversational AI. Other than writing code for a living, Rabeb advocates to bring more women and minorities into tech. She is leading the Women Who Code Network in Bristol.",
                PhotoUrl = "https://www.updateconference.net/Resources/Images/Speakers/OtherSizes/Rabeb_Othmani_370.png"
            },
            new SpeakerModel
            {
                Id = 18,
                Order = 18,
                FirstName = "Rebai",
                LastName = "Hamida",
                DescriptionShort = "MVP REBAI Hamida",
                DescriptionLong = "Microsoft MVP in Visual Studio and Development Technologies, MCC ,MVB DZone,Technical Writer,Architect, Tech Speaker, .NET Consultant.",
                PhotoUrl = "https://sessionize.com/image?f=35af525374ee68014749a077a94ecc1e,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.fb1d4339-e5df-46c9-836c-40b711e38fcf.jpg"
            },
            new SpeakerModel
            {
                Id = 19,
                Order = 19,
                FirstName = "Richard",
                LastName = "Campbell",
                DescriptionShort = "Microsoft Regional Director, Microsoft MVP",
                DescriptionLong = @"Richard Campbell si začal hrát s mikropočítači v roce 1977 ve věku 10 let. Pohyboval se snad na všech úrovních počítačového průmyslu, od výroby až po prodej, vývoj a rozsáhlou implementaci infrastruktury. Byl svědkem a účastníkem vize Billa Gatese ""PC na každém stole"". Již řadu let působil jako konzultant v mnoha zemích, mimo jiné pro společnosti Barnes & Noble, Dow Chemical, Johnson & Johnson Health Care Services, Reuters, Subaru / Isuzu nebo U.S. Air Force. Pomáhal s návrhem architektury, škálováním systémů či mentoringem vývojových týmů. Úzce spolupracoval též s firmami rizikového kapitálu a private equity firmami. Je Microsoft Regional Director a Microsoft MVP za oblast ASP.NET.",
                PhotoUrl = "https://www.updateconference.net/Resources/Images/Speakers/OtherSizes/richard_profile_370.jpg"
            },
            new SpeakerModel
            {
                Id = 20,
                Order = 20,
                FirstName = "Rodrigo",
                MiddleName = "Díaz",
                LastName = "Concha",
                DescriptionShort = "Microsoft Regional Director & MVP. WPF, XAML & Xamarin Lover. Consultant, Trainer, Book Author, Speaker, Traveler and Sybarite. Building life-changing software!",
                DescriptionLong = @"I’m Rodrigo Díaz Concha, a Microsoft Regional Director living in Mexico. I'm a Carnegie Mellon® Software Engineering Institute Certified Software Architecture Professional. For 9 consecutive years I have been recognized as a Microsoft MVP -currently in the Windows Development and Visual Studio development and technologies categories. In addition, I'm a Scrum Alliance Certified ScrumMaster, MCT, MCSD, MCTS, MCPD and MCP. I'm the author of ""Xamarin.Forms en Acción: Aplicaciones de negocio"" (Xamarin.Forms in action: Business applications), the very first book about Xamarin.Forms in Spanish language. With more than 18 years of experience, I have architected international award-winner software solutions. Currently, I'm the lead Solutions Architect for different national and international private companies and government institutions. Also, I'm a frequent speaker at Microsoft and non-Microsoft events all over Latin America.",
                PhotoUrl = "https://www.updateconference.net/Resources/Images/Speakers/OtherSizes/RODRIGO_DIAZ_370.jpg"
            },
            new SpeakerModel
            {
                Id = 21,
                Order = 21,
                FirstName = "Roland",
                LastName = "Guijt",
                DescriptionShort = "Microsoft MVP, Pluralsight author",
                DescriptionLong = "Roland is a Microsoft MVP enjoying a constant curiosity around new techniques in software development. His focus is on all things .NET and browser technologies. As a long-time trainer, he led many courses on these topics and spoke about them at international conferences. He also travels around the globe to offer his self-developed workshops and is a popular Pluralsight author. The word that comes to mind when he thinks about software development is passion!",
                PhotoUrl = "https://sessionize.com/image?f=840749421c446e5f240abd03bafbc271,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.6c4d17a0-bf64-4add-a063-afbeeed12232.jpg"
            },
            new SpeakerModel
            {
                Id = 22,
                Order = 22,
                FirstName = "Sander",
                LastName = "Molenkamp",
                DescriptionShort = "Principal Cloud Architect @ Info Support",
                DescriptionLong = "Sander Molenkamp is Cloud Solution Architect at Info Support. He has been helping customers designing and developing solutions using Microsoft technology for more than 18 years and has a passion for cloud native architectures. He’s a Microsoft Azure MVP and co-organizer of the Dutch Azure Meetup. At Info Support, Sander is a Microsoft Competence Center lead, where amongst other things he enjoys hosting the dotnetFlix podcast.",
                PhotoUrl = "https://sessionize.com/image?f=43f06e1d29bad64de34a02032414aa8f,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.ae9cd8fc-75fa-497c-8a88-23d5ee3d3cf8.jpg"
            },
            new SpeakerModel
            {
                Id = 23,
                Order = 23,
                FirstName = "Santosh",
                LastName = "Hari",
                DescriptionShort = "Technologist, Microsoft Azure MVP, President @Onetug #OrlandoCC",
                DescriptionLong = "Santosh Hari is a Microsoft Azure MVP and a public speaker who gives talks frequently at meetups, conferences and codecamps. He works for a startup where, he leverages his software skills to help provide high quality, affordable wireless broadband to the developing world. He also runs a software consulting company with his wife. Santosh also volunteers for Orlando .NET User Group as President and co-organizer of the annual Orlando Codecamp.",
                PhotoUrl = "https://sessionize.com/image?f=351030d90d06dcd4eec22023c2ed0d39,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.868a5661-b073-4688-8c71-22be92a36245.jpg"
            },
            new SpeakerModel
            {
                Id = 24,
                Order = 24,
                FirstName = "Steve",
                LastName = "Gordon",
                DescriptionShort = "Microsoft MVP and Senior Software Developer at Madgex Ltd",
                DescriptionLong = @"Steve Gordon is a Microsoft MVP, senior developer and community lead based in Brighton, UK. He works for Madgex (www.madgex.com) developing and supporting their new product portfolio built on ASP.NET Core technologies. Steve is passionate about community and all things .NET related, having worked with ASP.NET on and off for over 15 years. Steve is currently developing microservice based products and services, using ASP.NET Core and Docker. He enjoys sharing his knowledge through his blog, in videos and at by presenting talks at user groups and conferences. Steve is excited to be a part of the .NET community and has recently founded .NET South East, a .NET Meetup group based in Brighton. He enjoys contributing to and maintaining OSS projects, most actively helping save lives with open source software and the Humanitarian Toolbox (www.htbox.org). You can find Steve online at his blog www.stevejgordon.co.uk and on Twitter as @stevejgordon.",
                PhotoUrl = "https://sessionize.com/image?f=7f3cd2cf5c3868b83d1ca9d13680da16,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.6020f38e-e2ec-424f-874f-faad411547e1.jpg"
            },
            new SpeakerModel
            {
                Id = 25,
                Order = 25,
                FirstName = "Tamir",
                LastName = "Dresher",
                DescriptionShort = "Cloud Division Leader, CodeValue",
                DescriptionLong = "Tamir Dresher is a software architect, consultant, instructor and technology addict that leads the Cloud Division at CodeValue Israel. With more than 10 years of experience of developing and architecting systems both on-premise and on the cloud, Tamir holds the title of Microsoft MVP in Visual Studio and Development Technologies, and he is the author of the book \"Rx.NET in Action\" published by Manning (http://manning.com/dresher/). He blogs at http://blogs.microsoft.co.il/iblogger/ and you can reach out to him via Twitter @tamir_dresher.",
                PhotoUrl = "https://sessionize.com/image?f=3da35bcae7fb846462994270e21e7c5f,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.4a3d3647-6c39-45cd-bb2a-ef60d353b99e.jpg"
            },
            new SpeakerModel
            {
                Id = 26,
                Order = 26,
                FirstName = "Taswar",
                LastName = "Bhatti",
                DescriptionShort = "Multilingual System Architect at Gemalto (Security to be free)",
                DescriptionLong = "Taswar Bhatti is a System Architect for SafeNet Gemalto. He holds a BSc in Mathematics and Computing Science from University of Alberta, and is well versed in architectural design, security and building scalable internet web applications; not to mention he is also a Microsoft MVP. Taswar is also fluent in many spoken languages: Cantonese, English, Turkish, and Urdu/Hindi.",
                PhotoUrl = "https://sessionize.com/image?f=b5e3284ed3661b902fad7e32f4e8564d,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.42f4e917-9b1f-4b3f-b502-ead447501bf8.jpg"
            },
            new SpeakerModel
            {
                Id = 27,
                Order = 27,
                FirstName = "Tiberiu",
                LastName = "Covaci",
                DescriptionShort = "Microsoft Regional Director, Tech Lead at CODE Magazine/EPS",
                DescriptionLong = "For over 20 years Tiberiu dedicated his life to improve the quality of the software written by other people, by helping them to understand the technological choices they are presented with. His efforts include training, mentoring, advising, motivating, and working side by side with their development team. Over the time he helped many of his partners and customers to choose the right technological solution for the right problem.",
                PhotoUrl = "https://sessionize.com/image?f=d9c71bce0d1dbc3b0edc1cf5fe2af747,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.5dc6d2d0-7ec3-4721-bdc1-f63c6426b3da.jpg"
            },
            new SpeakerModel
            {
                Id = 28,
                Order = 28,
                FirstName = "Toni",
                LastName = "Petrina",
                DescriptionShort = "Developer | Speaker",
                DescriptionLong = "Started in QBasic, went through C++ to C#, finally settled in ECMAScript. Worked on desktop, mobile and web apps, currently working as full stack developer. Frequent speaker at conferences, user groups and local events. He spends most of the time at the keyboard typing yet another demo or application. If you take his keyboard away from him, he will talk endlessly about code...and functional programming. Been coding for over a decade to know if something is a programming fad or not. And no, functional programming is not a fad at all. Strong proponent of Open Source and all things chocolate.",
                PhotoUrl = "https://sessionize.com/image?f=5ee8e554d445c92239407317a5cb042d,400,400,True,False,eb-aabb-4fe5-a4f2-b110ddf4cae3.a33e81ab-8f97-4610-adc8-751338cd497a.jpg"
            }
        };
    }
}