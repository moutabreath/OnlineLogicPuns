namespace OnlineLogicPuns
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int currentSeqLength = 0;
            bool insideSequence = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (!insideSequence)
                    {
                        insideSequence = true;
                    }
                    currentSeqLength++;

                }
                else
                {
                    if (insideSequence)
                    {
                        insideSequence = false;
                        if (currentSeqLength > max)
                        {
                            max = currentSeqLength;
                        }
                        currentSeqLength = 0;
                    }
                }
            }
            if (insideSequence)
            {
                if (currentSeqLength > max)
                {
                    max = currentSeqLength;
                }
            }
            return max;
        }
    }
}
