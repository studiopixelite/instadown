![Image](https://github.com/studiopixelite/instadown/blob/master/Library/Instadown%20By%20Pixelite.png?raw=true)

# Instadown
A C# library for downloading Instagram images, videos, profile pictures, and for getting info about an account


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
