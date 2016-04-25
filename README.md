# Tango-Defender
Project tango game

Previous Repository
https://github.com/TangoDevs/Mock1


##About Tango Defender and technologies we used

##Introduction
Our Project Tango Defender is an Augmented Reality Game which allows the user to place and object in Real 3D space and the user is fully able to move around the object and interact with it. Using Project Tango from Google the object will stay in the same relative position within the real world. Our project also makes use of technologies that we used in our course, such as Databases, Azure Servers, Mobile Apps Development and Data Structures and A.I path finding algorithms.

##What is Google Project Tango?

Project Tango is a platform by Google technology that uses computer vision to let mobile devices, such as smartphones and tablets, to detect their position relative to the objects around them without using GPS. This allows developers to create user experiences that includes the following, indoor navigation, augmented reality, and windows into virtual 3D worlds and many more which it can be used.The first product to surface from Google's ATAP skunkworks group, Project Tango was made by a team led by computer scientist Johnny Lee, who was also a core contributor to Microsoft's Kinect. Google has designed two devices to demonstrate the Project Tango technology: the Peanut phone, which is no longer available to buy, and the Yellowstone 7-inch tablet which we are using at the moment. More than 5,000 of the Yellowstone devices had been sold as of april 2016, mainly to researchers and software developers interested in building applications for the platform. In the summer of 2016, Qualcomm and Intel both announced that they are releasing Project Tango mobile phones to the public consumption.

##What We used Google Project Tango for?
Motion Tracking
Motion tracking allows a device to understand position and orientation using Project Tango's custom sensors. This gives you real-time information about the 3D motion of a device.
Depth Perception
Depth sensors can tell you the shape of the world around you. Understanding depth lets your virtual world interact with the real world in new ways.
Area Learning
Project Tango devices can use visual cues to help recognize the world around them. They can self-correct errors in motion tracking and relocalize in areas they've seen before.

##Why we used Google Project Tango
The idea to use the Tango came from us attending one of bi-monthly Google Developers Galway meetups. There there was an employee from Google who was giving a talk on the Tango. This was very new to us and it was amazing to see Augmented Reality used in the way the Tango uses it. We looked into getting a developer kit and the ideas just flowed naturally. The main reason we decided to use Project Tango was because Google have pushed to make this the de facto camera in the phones/tablets they will be making in the future. So getting into this now will open us up to the market that is currently not being developed for. There are some 5000 thousand developer kits purchased worldwide and only about 500 active members on the official forums, we are 2 of that 5000. We feel strongly that this is the future of not only mobile applications but how we will interact with the world around us.

##What is Unity?
Unity, a cross-platform game engine created by Unity Technologies and used to help develop video games for PC, consoles, mobile devices and websites.With an emphasis on portability, the engine targets the following API that we used: OpenGL ES on Android and iOS. Unity permits specification of texture compression and resolution settings for each platform that the game engine supports, and provides additional support for reflection mapping, screen space ambient occlusion (SSAO) and many more.

##What we used in Unity

Google Project Tango Api for Augmented Reality
A* Algorithm 
Animation
Azure Server Hookup(Bitrave)

##Google Project Tango Api for Augmented Reality

We used this to enable us to produce apps for the Tango. In the api it provides us with the scripts and prefabs so that we can use the Tango with our game. Although it does provide these it is important to mention when using this you will have to read through the scripts and see what is going on otherwise when your app fails you will not know why it fails with this api. This is more of an experimental type of technology used in unity it is very powerful and effective.


##A* Algorithm

We used A* pathfinding algorithm in Tango Defender. The basics on how it works is, it builds a 2d grid on the 3d world. We apply a layer to the objects that we don't want the enemies to be able to pass through. If you imagine it with white and red blocks, the red blocks being the non walkable areas and the white being the walkable areas the grid will be made up of red and white blocks. The enemies will be able to pass through the white and will calculate a run to the target. So down to the algorithm in use, the enemy will call the pathfinding.cs where this script will run and find the g-cost and h-cost of each node next to it and by this it can calculate which node is better to chose to get to the target node. It uses a the distance between the next node the end node to chose which is better. It is a simplified version and very effective a* algorithm it does use both g-cost and h-cost but it doesn't use it to the extent it can be, for example it could be used with a* with jump start where this algorithm is faster we chose to implement the normal a* because for the purpose of our project we didn't need it to run as fast as some of the advanced algorithms.


##Animation
With this we used the unity particle emitter which as you can see in the game  produces a blast when the fireball hits a collider. We used this to get a nice effect to the game where the user sees the fireball blowing up and having a great with minimal computation time.


##Azure Server Hookup(Bitrave)
The Bitrave hookup is an addon on to Unity that provides an API for sending and receiving information from an Azure Server. We used it to connect to a Database on a Mobile Service we set up on the Azure Cloud. Using the API we sent and received scores from the Leaderboard database. We connected using the unique URL address of the server as well as the auto-generate application key that Azure provided us. 





##Advantages of using Unity

In our opinion, the first advantage is C# language itself. C# is a high-level programming language which allows developers an introduction to the game development process easily. It is essential because unlike other game engines using languages like C++, C# has many elements that have already been imported. All that is left is for developers to utilize them.
A great community is necessary for game development, which leads us to our second advantage. It means that each engine’s function has a clear explanation with examples on the developer’s website.
Unity is cross platform, which in turn our third advantage. It means that the same code, developed in Unity engine, can be ported on various platforms such as PC, Mac, Android, iOS, Web, game consoles with minimum adjustments. It helps a lot to cut down the effort needed for the progress of the game.
 
##What is Blender?

Blender is free and open-source 3D computer graphics/Visualization  software product used for design and construct animated films, visual effects, art, 3D printed models, interactive 3D applications and video games. Blender's technologies include 3D modeling, UV unwrapping, rigging and skinning, particle simulation, soft body simulation, sculpting, animating, rendering, video editing and compositing. It also features an integrated game engine.

##The Process we used to when using Blender

3D modeling
Rigging
Weight Painting
Animation & Video Editing

##3D modeling

This is the art of designing the model for the game. We used various commands to achieve and we used the mirror effect so that we didn't have to redraw both side. There is many effects and techniques that we used to create each model. We did try many effects to get the characters form and shape. We used some sculpting tools in blender to achieve the overall shape each model.

##Rigging

Rigging is the part where we add bones to the mesh, these bones allow the mesh to move as the bones do. The bones have inverse kinematics  that allows it to move other bones around it. Bones also have pivot point bones so that it moves around a certain area and this is particularly important for animation.

##Weight Painting

In this part we paint what part of the mesh reacts to what bones that are moving. In blender is does automatically do weight painting but we had to alter it to have a more realistic mesh movement. This is probably the hardest part of the process as it takes time and precision to create the perfect movement to the model.

##Animation & Video Editing

In this part we had to move bones and insert keyframes to save the animation. We used the bones to get the desired effect for the animation. We also did some text animation as you can see by the first scene in the project there is an animation of text changing formation to the next word. Animation is blender is particularly powerful you can do animation of near anything if you have the knowledge of how to do it and have the imagination on how to achieve it. 


##Advantages of using Blender

Workflow speed in the assignment was great using blender. As you gain knowledge using it you'll see how fast this UI is compared to other 3d Modeling software such  as maya. The polygon modeller is fast aswell,subdivision surface works really efficiently. Facinating  bones system,automatic weighting tool is amazing, although not perfect still very good.You can do amazing post processing with the node system.Blender has a fantastic sculpting tool. With all this and the fact that blender is free software this is why blender  is better.

##What is Azure Server?
Microsoft Azure. Microsoft Azure is a cloud computing platform and infrastructure created by Microsoft for building, deploying, and managing applications and services through a global network of Microsoft-managed datacenters.
 
##What we used Azure For.
We decided that we would use their Mobile Service and create a database that would hold the Leaderboard of high scores. Upon creating the Mobile Service we got the connection string and an auto generated Application Key that we used to connection out app to the unique Mobile Service.

##Why we used Azure
Azure Server was something we had previously used with other coursework throughout the year, so it was very familiar to us. The folks over at BitRave developed a rather simplistic API for connecting to a Azure Server.

##What is Git?
Git is a version control system that is universally used for software development. With an emphasis on speed this is the best for distributed revision control system, data integrity, and support for distributed, non-linear workflows.Git was initially designed and developed in 2005 by Linux kernel developers (including Linus Torvalds) for Linux kernel development.

##What is Github?
GitHub is a web-based Git repository hosting service. It offers all of the distributed revision control and source code management (SCM) functionality of Git as well as adding its own features. Unlike Git, which is strictly a command-line tool, GitHub provides a Web-based graphical interface and desktop as well as mobile integration. It also provides access control and several collaboration features such as bug tracking, feature requests, task management, and wikis for every project.

##What we used Github for?

Source control
Collaboration    
Bug tracking


##Why we used Github

Github is like Twitter for programmers. Everyone’s on there. You can look at what they’re working on and easily peruse their code and make suggestions or changes.It’s really open source. “Open source” is not so open if you can’t easily study it. With github, all of the code is easily inspected, as is its entire history. Github lowers the barriers to collaboration. It’s easy to offer suggested changes to others’ code through github. We were able to fix a mistake in the Tango Defender, because it’s hosted on github.

##What is Leap Motion?

Leap Motion, Inc. is an American company that manufactures and markets a computer hardware sensor device that supports hand and finger motions as input, analogous to a mouse, but requires no hand contact or touching. In 2016, the company released new software designed for hand tracking in virtual reality.In basic terms it scans an area from which it is placed and it takes in hand movements and it detects these movements and acts accordance to the screen it an be used for slide for example it take the gesture of a right swipe and move to the next slide or left to the previous. It can also be used in medicine where it could theoretically have a virtual patient and the doctor can get used to doing a procedure for an operation.


##Why we didn't use Leap Motion

In the end it was too ambitious of us to try to get this new technology to work with the Tango so we decided not to use to although we did research some of how to use the leap motion. It could be used in our 4th year project as it is a fascinating new technology that would be amazing to integrate to the project Tango tablet.
