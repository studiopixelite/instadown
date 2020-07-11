using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instadown;

namespace Instadown // (C) 2020 Pixelite
{
    class InstadownDemo
    {
        MediaClass m = new MediaClass();
        ProfileClass p = new ProfileClass();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        
        public void SaveImage()
        {
            // It is very compulsory to place this in your code in this same url format before downloading
            m.inputUrl = "https://www.instagram.com/p/CCd0w4lJVKY/"; 
            m.DownloadImage(path);
        }

      
        public void SaveVideo()
        {
            // It is very compulsory to place this in your code in this same url format before downloading
            m.inputUrl = "https://www.instagram.com/p/CCd0w4lJVKY/"; 
            m.DownloadVideo(path);
        }

        public void SaveProfilePic()
        {
            // It is very compulsory to place the profile url in your code in this same format
            p.inputUrl = "https://www.instagram.com/p/CCd0w4lJVKY/"; 
            p.GetProfilePicture(path);
        }

        public void UserName()
        {
            // It is very compulsory to place the profile url in your code in this same format
            p.inputUrl = "https://www.instagram.com/studiopixelite/"; 
            string username = p.GetUserName(); // This makes your desired string to be the username of the user
        }

        public void Followers()
        {
            // It is very compulsory to place the profile url in your code in this same format
            p.inputUrl = "https://www.instagram.com/studiopixelite/"; 
            string followers = p.GetFollowers(); // This makes your desired string to be equals to the number of followers a user have
        }

        public void Followed()
        {
            // It is very compulsory to place the profile url in your code in this same format
            p.inputUrl = "https://www.instagram.com/studiopixelite/";
            string followers = p.GetFollowed(); // This makes your desired string to be equals to the number of followed people a user have
        }

        public void Posts()
        {
            // It is very compulsory to place the profile url in your code in this same format
            p.inputUrl = "https://www.instagram.com/studiopixelite/";
            string followers = p.GetPostsNumber(); // This makes your desired string to be equals to the number of posts a user have
        }
    }
}
