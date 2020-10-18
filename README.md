# ClassVRoom
 
## Presentation
[click here for our presentation] (https://docs.google.com/presentation/d/1flvb4qvtppEq6nSock9wvEjVf2PZqFlWFGt5oXDCe6Y/edit#slide=id.ga3b0c4c515_5_0 )

The presentation outlines:
- Reasoning for project
- Business Analysis (price comparison, competition, potential)
- Prototype
- Tech stack
- Future plans

## Inspiration
Due to the online environment, there has been a sharp **decrease in classroom engagement**, which leads to more difficulty in learning and less productive conversations. Most of us fit into this category as we are easily distracted and sometimes go back to bed because there is no interaction. When speaking to younger children, they also expressed that they were having the same problems. With the limited features of online meetings and internet bandwidth, many students find themselves distracted because there are no repercussions. The goal of ClassVRoom is to create a more **immersive, engaging environment** for students and teachers to work together and communicate collaboratively.

## What it does
ClassVRoom is a powerful tool for teachers to get students engaged and interested in learning. Students and teachers would be placed in a virtual environment, **free from distractions**, and get immersed in the lessons at hand. Teachers not only can screen-share and use their webcam, but they can also take students into whiteboard rooms and on virtual field trips. These field trips give students a new perspective, interest in the topic at hand, and possibly increase their learning performance. 

## How we built it
Our project is built mostly on Unity and hosted on Photon’s servers. Using Unity, we configured networks to enable multiple users in the same environment, created teaching tools, and the environment surrounding the users. Most, if not all, the scripting and code behind each asset is written in C#. Our team also had a few designers who were able to design environments, assets, and avatars for users to interact with. 

## Challenges we ran into
When building the application, we ran into a number of issues with Unity development. The majority of our team knew little to no Unity, which made developing very difficult. But we pushed through, watched a number of tutorials, and read a ton of documentation. **Progress happened very slowly, but progress was made!** Some of the challenges we faced includes:
- We tried to implement EchoAR after attending the workshops. We spent a great deal of time implementing EchoAR and incorporating it with  our project.  However after numerous attempts at getting the networking and objects into our server, we felt that we were getting stuck too often. We successfully **networked our applications**, but failed to import and interact with objects because colorful objects turned solid yellow and were floating. We were more comfortable working with Photon and Unity, as there was more documentation and available help. Working with EchoAR and implementing our network on their servers was an extremely difficult task that we unfortunately couldn’t overcome quickly. So we shifted back to Photon, a VR server for network 2+ players together, and slowly made progress
- 3D model designs. When working on designing our environments and avatars, we had a difficult time cross developing on different softwares. We had designed a number of environments and objects on Maya, however there were inconsistencies when importing to Unity. Many of the textures and components created in Maya disappeared! To this day (~6 hrs later), we don’t know the solution, but we found workarounds by playing with the textures and materials within Unity itself. 

## Accomplishments that we're proud of
There are a number of successes from our team! From learning and actually implementing features into a VR space to creating beautiful landscapes on Maya. We learned a lot about the creation of a VR application from 3D modeling to networking. Each one of us pushed ourselves to the limit and had to learn very quickly to get the features we wanted. We are most proud of developing a solution that aims to **enhance the virtual learning experience for students**. With the collaborative efforts of the team, we managed to successfully implementing the main functionalities of ClassVRoom within the hacking hours of DubHacks.

## What we learned
We learned a lot of technical skills as well as soft skills. For many of us, this is our first major hackathon where the event is longer than a few hours, so being **mentally prepared and ready has been really difficult**. However, it was a good learning experience that prepares us to work effectively in the fast paced tech industry. We, as a team, also developed a strong understanding of creating together and making progress together. There were many points during this hackathon where we encountered difficulties due to the lack of experience in using the softwares, but after learning more about Unity and 3D modeling, we were able to **complete our goals one step at a time**.

## What's next for ClassVRoom
The next steps for ClassVRoom is to create more environments and more tools for teachers to use. Over the past 14 hours, we ideated, designed, and implemented a minimal viable product(MVP) that had the very basics of our application. So the next steps for the team is to take a step back, reevaluate what we have done, fix any minor bugs, and develop more features. We acknowledge that technology is difficult, especially for young children and older users. So we plan on taking all the precautions we can to minimize bugs. 

Some features we want implemented include having an **individualized student dashboard**, where students can take notes and look at handouts. We also hope to have interactive environments where students can play with chemistry experiments or math formulas. These interactive environments would either be created by our development team or by  teachers on our design platform (coming to you soon!). 

We also acknowledge that the next couple years will be unpredictable. This product is partially catered for students to concentrate better now, but we also considered that it will be a **product that lasts**. As mentioned in the slide deck, field trips are difficult to plan and financially difficult. But they’re important pieces to a child’s primary school experience. They’re a transformative experience and studies have shown that field trips = more curious and interested students. So to solve this issue, we have enabled teachers to take students on a guided virtual environment to immerse themselves into the topic at hand. Whether it’d be visiting historical ruins like Machu Picchu or diving deep into the ocean, students can instantly visit places without being bounded by ability and cost.

**Development in VR education is just starting and I believe that ClassVRoom has potential to be a big player in this market.**
