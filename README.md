![Image](https://github.com/studiopixelite/instadown/blob/master/Library/Instadown%20By%20Pixelite.png?raw=true)

# Instadown
A C# library for downloading Instagram images, videos, profile pictures, and getting info about an account

# Target Framework
.NET Framework 4.5 and above

Dependencies - Newtonsoft.Json 12.0.3 and above

# How to save videos
public void SaveVideo()

{

    ProfileClass p = new ProfileClass();
    
    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
    p.inputUrl = "https://www.instagram.com/p/CCd0w4lJVKY/"; 
    
    p.DownloadVideo(path);
 }
 
Check InstadownDemo.cs in the Library folder in the repository to see how to use the library

# How to download

Download the Instadown.dll file from the Library folder in the repository

In Visual Studio, right click on your project's references and click on "Add Reference"

Browse for where you placed the file and click OK.

# Donate 

Credit/Debit Card - https://paylink.ng/studiopixelite/

Bitcoin Wallet Address - 36uVDZ7XVukrbM5DitAdEx1eNnqQNUVNgf

Ethereum Wallet Address - 0x5256017bE8457eECC81F6F9a2cE0D2b4D03Fb767

Skrill - creativegreatonic@gmail.com
