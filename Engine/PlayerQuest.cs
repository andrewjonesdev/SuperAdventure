namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        public PlayerQuest(Quest details, bool isCompleted)
        {
            Details = details;
            IsCompleted = isCompleted;
        }
    }
}