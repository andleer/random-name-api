namespace RandomName.Api.Services;

public class NameGeneratorService
{

    public IEnumerable<string> GenerateNames(int count)
    {
        var firstNames = Random.Shared.GetItems(NameGeneratorData.FirstNames, count);
        var lastNames = Random.Shared.GetItems(NameGeneratorData.LastNames, count);

        return Enumerable.Zip(firstNames, lastNames).Select(i => $"{i.First} {i.Second}");
    }
}
