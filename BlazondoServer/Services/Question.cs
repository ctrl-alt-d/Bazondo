namespace Blazondo.Questions
{
    
    public class Question
    {
        public enum LevelCode
        {
            groc = 1,
            taronja,
            verd,
            blau,
            marró,
            negre
        }        
        public LevelCode levelCode => this.level.ToEnum<LevelCode>();
        public string level {get; set;}
        public string negre {get; set;}
        public string tecnica {get; set;}
        public string video {get; set;}
        public string alt {get; set;}
        public string picture {get; set;}

    }
}