using NConfig.Filters.Evaluation;

namespace NConfig.Exceptions
{
    public class ItemsWithConflictingHighestScoreException : NConfigException
    {
        public ItemWithScore[] ItemsWithConflictingScore { get; private set; }
        public ItemWithScore[] AllItems { get; private set; }
        public int HighestScore { get; private set; }

        public ItemsWithConflictingHighestScoreException(ItemWithScore[] itemsWithConflictingScore, ItemWithScore[] allItems, int highestScore)
            : base(string.Format(
            "items with conflicting highest score of {0} exists, cannot determine default", highestScore))
        {
            ItemsWithConflictingScore = itemsWithConflictingScore;
            AllItems = allItems;
            HighestScore = highestScore;
        }
    }
}