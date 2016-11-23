# ShoeStore

## Synopsis

Shoe Store website. Which is created for an exercise in ASP.NET MVC, JQuery, CSS, BootStrap, Building and Application deployment.

## Technologies Used

 ASP.NET MVC, Razor, CSS, Inline data, C#, Bootstrap, JavaScript, JQuery Configured to host in IIS, 


## Building & Deployment

Building application and deployment is configured in two ways
  1. Web Publish profile has been created and configured. Profile name is ShoeStore. Which can be edited to change the target path ( Which can be any website, FTP, folder location etc)
  2. Batch file created along with post script. Which will deploy the necessary deployment files to the target path specified.    
    Batch file name is ProjectDirectory\build.bat.    
    Post Build command "$(ProjectDir)"build.bat  "$(ProjectDir)" "C:\Publish\ShoeStore\"     
    Syntax: 
        [batch file path]  [projectdirectory] [targetpath]
     
     Note: Here targetpath can be configured based on environment ( dev/QA/Stage/Prod )
  
    Since Post build event is configured. When we build the website. it will deploy to targetpath. 
   
   
   
