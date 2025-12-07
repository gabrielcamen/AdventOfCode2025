namespace Day1;

public class SecretEntrance
{
    #region Public members
    public int GetPassword(string inputFileName, bool firstChallenge)
    {
        const int initialDialPosition = 50;
        const int numberOfDials = 100;
        const int correctDialPosition = 0;
        var currentDialPosition = initialDialPosition;
        var rotations = File.ReadAllLines(Path.Combine(AppContext.BaseDirectory, inputFileName)).ToList();
        var counterOfCorrectDials = 0;
        foreach (var rotation in rotations)
        {
            var previousPosition = currentDialPosition;
            var turnDirection = rotation.First();
            var turnNumber = int.Parse(rotation[1..]);
            var goneThru = false;
            if (turnDirection == 'L')
            {
                currentDialPosition -= turnNumber;
                while (currentDialPosition < 0)
                {
                    currentDialPosition += numberOfDials;
                    if (firstChallenge)
                        continue;
                    if (previousPosition != 0)
                    {
                        counterOfCorrectDials++;
                    }
                    previousPosition = currentDialPosition;
                    goneThru = true;
                }
            }
            else
            {
                currentDialPosition += turnNumber;
                while (currentDialPosition >= numberOfDials)
                {
                    currentDialPosition -= numberOfDials;
                    if (firstChallenge)
                        continue;
                    if (previousPosition != 0)
                    {
                        counterOfCorrectDials++;
                    }
                    previousPosition = currentDialPosition;
                    goneThru = true;
                }
            }
            
            if (!goneThru && currentDialPosition == correctDialPosition)
                counterOfCorrectDials++;
        }

        return counterOfCorrectDials;
    }
    #endregion
}
