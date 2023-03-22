using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos and add comments for each
        Video video1 = new Video("Five Messages That All of God’s Children Need to Hear| Dieter F. Uchtdorf | 2021", "BYU Speeches", 2101);
        video1.AddComment("Mariah Baird", "\n  'The lord often accomplishes the most, with those who feel the least accomplished.'\n   I needed to hear that today. Definitely an answer to a prayer.\n");
        video1.AddComment("Russ Pearson", "\n   Thank you Pres Uchtdorf!!, needed this wonderful message of hope and love!\n");
        video1.AddComment("Sharon Grace Mosquite", "\n   So grateful of the opportunity to hear such uplifting words from one of my\n   favorite leader ...Elder Uchtdorf. Your message really touched my heart and lifted\n   my spirit. Thank you so much.\n");
        videos.Add(video1);

        Video video2 = new Video("Overcome the World and Find Rest | Russell M. Nelson | October 2022 General Conference", "General Conference", 1123);
        video2.AddComment("Beatrice Savasta", "\n   I am touched by this superbly, spiritually edifying talk. Thank you,  President Nelson,\n   for your loving concern for us. I rejoice to feel you are God's prophet on earth today\n   and have been praying for your continued vitality to bless us and remain in our lives\n   as painlessly as possible.\n");
        video2.AddComment("Golden Cooper", "\n   This man is so sweet I don’t belong to your church but this video was recommended and hearing \n   his sweet voice made me wish he was my grandpa. May God bless you!\n");
        video2.AddComment("John Mays", "\n   Whenever I feel angry this talk always calms me down and helps me think clearly. So grateful for the prophet!\n");
        videos.Add(video2);

        Video video3 = new Video("Nephi Sees a Vision of Future Events | 1 Nephi 10–15", "Book of Mormon Videos", 899);
        video3.AddComment("Trevor Evans", "\n   I’m not sure how much it cost to produce this video but to me it is worth a million times more.\n   What a privilege to be called, Sisters and Brothers, to be part of the gathering of\n   Israel and to be disciples of Christ. Each missionary who chooses to serve is a modern day miracle.\n");
        video3.AddComment("Joscelyn Pease", "\n   Absolutely incredible! We are so blessed to have so much truth and evidence of Heavenly Father \n   and Jesus Christ and the Plan of Salvation. I am so grateful to all those that have \n   showed us the way and are such great examples of righteousness. I am so grateful for the Book of\n    Mormon, it has shaped and changed my life.\n");
        video3.AddComment("Danny Rocket", "\n   I literally had tears streaming down my face watching this, not a first but all of a sudden the spirit \n   touched my heart and the tears started. This is how I know the gospel is true. This\n   is how I know Jesus Christ is the lamb of God.\n");
        video3.AddComment("Phillip Lambert", "\n   This is beautiful. The Gospel is truly Plain and Precious.\n");
        videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: {0}", video._title);
            Console.WriteLine("Author: {0}", video._author);
            Console.WriteLine("Length: {0} seconds", video._length);
            Console.WriteLine("Number of Comments: {0}", video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("{0}: {1}", comment._name, comment._text);
            }
            Console.WriteLine();
        }
    }
}
