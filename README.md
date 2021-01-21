![Image](https://github.com/studiopixelite/instadown/blob/master/Library/Instadown%20By%20Pixelite.png?raw=true)

# Instadown
A C# library for downloading Instagram images, videos, profile pictures, and getting info about an account


# Requirements
.NET Framework 4.6 and above, or
.NET Core 3.1 and above

# Dependencies 
. Newtonsoft.Json 12.0.3 and above
. System.Drawing.Common 5.0.0 and above

# How to save videos
public void SaveVideo()

{

    MediaClass m = new MediaClass();
    
    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    
    m.inputUrl = "https://www.instagram.com/p/CCd0w4lJVKY/"; 
    
    m.DownloadVideo(path);
 }
 
Check InstadownDemo.cs in the Library folder in the repository to see how to use the library

# How to download

Download the Instadown.dll file from the Library folder in the repository

In Visual Studio, right click on your project's references and click on "Add Reference"

Browse for where you placed the file and click OK.

Or

Go to NuGet - https://www.nuget.org/packages/Instadown/

# Donate 

Credit/Debit Card - https://paystack.com/buy/instadowndonations

Cryptocurrency - https://commerce.coinbase.com/checkout/ea196a3e-ecc2-4f0b-9ebe-e800ec435a8a

Skrill - creativegreatonic@gmail.com
