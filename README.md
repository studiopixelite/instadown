![Image](https://github.com/studiopixelite/covidtracker/blob/master/screenshots/1.png)

# Instadown
A C# library for downloading Instagram images, videos, and much more


# Target Framework
.NET Framework 4.5 and above

Dependencies - Newtonsoft.Json 12.0.3 and above

# How to save videos
public void SaveVideo()

{

    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
    m.inputUrl = "https://www.instagram.com/p/CCd0w4lJVKY/"; 
    
    m.DownloadVideo(path);
 }
 
Check InstadownDemo.cs in the Library folder in the repository to see how to use the library
