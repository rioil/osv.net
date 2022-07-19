﻿namespace OSV.Test.TestData;

using OSV.Models;

public class QueryAffectedBatchTestData : TheoryData<BatchQuery>
{
    public QueryAffectedBatchTestData() => this.Add(new()
    {
        Queries = new[]
        {
            new Query
            {
                Package = new Package
                {
                    Name = "jinja2",
                    Ecosystem = Ecosystem.PyPI,
                },
                Version = "2.4.1",
            },
        },
    });
}
