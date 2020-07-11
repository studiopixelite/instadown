using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Instadown // (C) 2020 Pixelite
{
    public class MediaClass
    {
        /// <summary>
        /// The input address url
        /// </summary>
        public string inputUrl;

        /// <summary>
        /// Download Instagram video as .mp4
        /// </summary>
        public void DownloadVideo(string path)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString($"{inputUrl}?__a=1"); 
            string TodayDate = $"{DateTime.Now.Day.ToString()}-{DateTime.Now.Month.ToString()}-{DateTime.Now.Year.ToString()}, {DateTime.Now.Hour.ToString()}.{DateTime.Now.Minute.ToString()}.{DateTime.Now.Second.ToString()}";
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(url);
            string vid = dyn["graphql"]["shortcode_media"]["video_url"];
            client.DownloadFile(vid, Path.Combine(path, $"IG_Video_{TodayDate}.mp4"));
        }

        /// <summary>
        /// Download Instagram image as .jpg
        /// </summary>
        /// <param name="path"></param>
        public void DownloadImage(string path)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString($"{inputUrl}?__a=1");
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(json);
            string disp = dyn["graphql"]["shortcode_media"]["display_url"];
            string TodayDate = $"{DateTime.Now.Day.ToString()}-{DateTime.Now.Month.ToString()}-{DateTime.Now.Year.ToString()}, {DateTime.Now.Hour.ToString()}.{DateTime.Now.Minute.ToString()}.{DateTime.Now.Second.ToString()}";
            WebClient igclient = new WebClient();
            Stream stream = client.OpenRead(disp);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                bitmap.Save(Path.Combine(path, $"IG_Image_{TodayDate}.jpg"), ImageFormat.Jpeg);
            }


            stream.Flush();
            stream.Close();
            igclient.Dispose();
        }
    }

    public class ProfileClass
    {
        /// <summary>
        /// The input address url
        /// </summary>
        public string inputUrl;

        /// <summary>
        /// Downloads the profile picture of an Instagram account
        /// </summary>
        /// <param name="path"></param>
        public void GetProfilePicture(string path)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString($"{inputUrl}?__a=1");
            string TodayDate = $"{DateTime.Now.Day.ToString()}-{DateTime.Now.Month.ToString()}-{DateTime.Now.Year.ToString()}, {DateTime.Now.Hour.ToString()}.{DateTime.Now.Minute.ToString()}.{DateTime.Now.Second.ToString()}";
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(url);
            string profilepic = dyn["graphql"]["user"]["edge_mutual_followed_by"]["profile_pic_url_hd"];
            WebClient igclient = new WebClient();
            Stream stream = client.OpenRead(profilepic);
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
            {
                bitmap.Save(Path.Combine(path, $"IG_ProfilePic_{TodayDate}.jpg"), ImageFormat.Jpeg);
            }


            stream.Flush();
            stream.Close();
            igclient.Dispose();
        }

        /// <summary>
        /// Gets the username of an Instagram account
        /// </summary>
        public string GetUserName()
        {
            WebClient client = new WebClient();
            string url = client.DownloadString($"{inputUrl}?__a=1");
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(url);
            string username = dyn["graphql"]["user"]["username"];
            return username;
        }

        /// <summary>
        /// Gets the number of followers an Instagram account has
        /// </summary>
        public string GetFollowers()
        {
            WebClient client = new WebClient();
            string url = client.DownloadString($"{inputUrl}?__a=1");
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(url);
            string followers = dyn["graphql"]["user"]["edge_followed_by"]["count"];
            return followers;
        }

        /// <summary>
        /// Gets the number of followed people an Instagram account has
        /// </summary>
        public string GetFollowed()
        {
            WebClient client = new WebClient();
            string url = client.DownloadString($"{inputUrl}?__a=1");
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(url);
            string followers = dyn["graphql"]["user"]["edge_follow"]["count"];
            return followers;
        }

        // <summary>
        /// Gets the number of followed people an Instagram account has
        /// </summary>
        public string GetPostsNumber()
        {
            WebClient client = new WebClient();
            string url = client.DownloadString($"{inputUrl}?__a=1");
            dynamic dyn = JsonConvert.DeserializeObject<dynamic>(url);
            string followers = dyn["graphql"]["user"]["edge_owner_to_timeline_media"]["count"];
            return followers;
        }

    }
}
