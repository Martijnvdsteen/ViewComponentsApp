namespace ViewComponentsApp.Models
{
    public class SocialIcon
    {
        public int ID { get; set; }
        public string IconName { get; set; }
        public string IconBgColor { get; set; }
        public string IconTargetUrl { get; set; }
        public string IconClass { get; set; }

        public static List<SocialIcon> AppSocialIcons()
        {
            List<SocialIcon> icons = new List<SocialIcon>();
            icons.Add(new SocialIcon { ID = 1, IconName = "Google", IconBgColor = "#dd4b39", IconTargetUrl = "www.google.com", IconClass = "Google" });
            icons.Add(new SocialIcon { ID = 2, IconName = "Facebook", IconBgColor = "#3B5998", IconTargetUrl = "www.facebook.com", IconClass = "Facebook" });
            icons.Add(new SocialIcon { ID = 3, IconName = "Linked In", IconBgColor = "#007bb5", IconTargetUrl = "www.linkedin.com", IconClass = "Linkedin" });
            icons.Add(new SocialIcon { ID = 4, IconName = "YouTube", IconBgColor = "#007bb5", IconTargetUrl = "www.youtube.com", IconClass = "Youtube" });
            icons.Add(new SocialIcon { ID = 5, IconName = "Twitter", IconBgColor = "#55acee", IconTargetUrl = "www.twitter.com", IconClass = "Twitter" });

            return icons;
        }
    }
}
