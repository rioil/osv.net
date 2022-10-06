namespace OSV.Client.Test.TestData;

public class QueryAffectedTestData : TheoryData<Query>
{
    public QueryAffectedTestData()
    {
        this.Add(new()
        {
            Package = new Package { Name = "jinja2", Ecosystem = Ecosystem.PyPI },
            Version = "2.4.1",
        });
        this.Add(new()
        {
            Package = new Package { Name = "log4net" },
            Version = "2.0.9",
        });
    }
}
